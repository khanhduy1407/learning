package lab06;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.math.BigInteger;

public class RSAGUI extends JFrame implements ActionListener {
  private final JTextArea plainInput;
  private final JTextArea cipherInput;
  private final JButton encryptButton;
  private final JButton decryptButton;

  RSA rsa = new RSA(8);
  BigInteger[] cipherText = null;
  BigInteger n = null;
  BigInteger d = null;
  String message = null;

  public RSAGUI() {
    setTitle("RSA Encryption/Decryption");
    setSize(400, 300);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setLocationRelativeTo(null);
    setResizable(false); // Prevent resizing of the window

    try {
      // Set Nimbus look and feel for a modern UI
      UIManager.setLookAndFeel("javax.swing.plaf.nimbus.NimbusLookAndFeel");
    } catch (Exception ex) {
      ex.printStackTrace();
    }

    JPanel panel = new JPanel(new GridBagLayout());
    GridBagConstraints constraints = new GridBagConstraints();
    constraints.insets = new Insets(5, 5, 5, 5);

    JLabel plainLabel = new JLabel("Plain text:");
    plainInput = new JTextArea();
    plainInput.setLineWrap(true); // Enable word wrap for multiple lines
    JScrollPane plainScrollPane = new JScrollPane(plainInput);
    plainScrollPane.setPreferredSize(new Dimension(250, 100));

    JLabel cipherLabel = new JLabel("Cipher text:");
    cipherInput = new JTextArea();
    cipherInput.setLineWrap(true); // Enable word wrap for multiple lines
    JScrollPane cipherScrollPane = new JScrollPane(cipherInput);
    cipherScrollPane.setPreferredSize(new Dimension(250, 100));

    encryptButton = new JButton("Encrypt");
    encryptButton.setPreferredSize(new Dimension(100, 30)); // Set fixed height for the button
    encryptButton.addActionListener(this);

    decryptButton = new JButton("Decrypt");
    decryptButton.setPreferredSize(new Dimension(100, 30)); // Set fixed height for the button
    decryptButton.addActionListener(this);

    // Add components to the panel using GridBagLayout
    constraints.gridx = 0;
    constraints.gridy = 0;
    panel.add(plainLabel, constraints);

    constraints.gridx = 1;
    panel.add(plainScrollPane, constraints);

    constraints.gridx = 0;
    constraints.gridy = 1;
    panel.add(cipherLabel, constraints);

    constraints.gridx = 1;
    panel.add(cipherScrollPane, constraints);

    // Center align buttons in a separate JPanel
    JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.CENTER));
    buttonPanel.add(encryptButton);
    buttonPanel.add(decryptButton);

    constraints.gridx = 0;
    constraints.gridy = 2;
    constraints.gridwidth = 2; // Span across two columns
    panel.add(buttonPanel, constraints);

    add(panel);
    pack();
    setVisible(true);
  }

  public static void main(String[] args) {
    new RSAGUI();
  }

  @Override
  public void actionPerformed(ActionEvent e) {
    if (e.getSource() == encryptButton) {
      btnEncryptActionPerformed(e);
    } else if (e.getSource() == decryptButton) {
      btnDecryptActionPerformed(e);
    }
  }

  private void btnEncryptActionPerformed(ActionEvent e) {
    String vanban = plainInput.getText();
    System.out.println("Van ban ca ma hoa: " + vanban);
    n = rsa.getN();
    d = rsa.getD();
    cipherText = rsa.encrypt(vanban);
    StringBuilder bf = new StringBuilder();
    for (int i = 0; i < cipherText.length; i++) {
      bf.append(cipherText[i].toString(16).toUpperCase());
      if (i != cipherText.length - 1) {
        System.out.println(" ");
      }
    }
    message = bf.toString();
    System.out.println("CipherText: " + message);
    cipherInput.setText(message);
  }

  private void btnDecryptActionPerformed(ActionEvent e) {
    plainInput.setText(message);
    String dhash = rsa.decrypt(cipherText, n, d);
    System.out.println("Van ban goc: " + dhash);
    cipherInput.setText(dhash);
  }
}
