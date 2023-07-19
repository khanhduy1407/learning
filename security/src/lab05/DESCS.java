package lab05;

import javax.crypto.*;
import javax.crypto.spec.DESKeySpec;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class DESCS extends JFrame implements ActionListener {

  private JTextField keyTextField;
  private JTextArea inputTextArea;
  private JTextArea outputTextArea;

  private JButton encryptButton;
  private JButton unlockAButton;
  private JButton unlockBButton;
  private JButton decryptButton;
  private JButton saveButton;
  private JButton showAllButton;

  private JFileChooser fileChooser;

  public DESCS() {
    setTitle("DES Encryption/Decryption");
    setSize(400, 400);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setResizable(false);

    JPanel mainPanel = new JPanel();
    mainPanel.setLayout(new GridBagLayout());
    GridBagConstraints gridBagConstraints = new GridBagConstraints();
    gridBagConstraints.fill = GridBagConstraints.HORIZONTAL;
    gridBagConstraints.insets = new Insets(5, 5, 5, 5);

    JLabel keyLabel = new JLabel("Key:");
    gridBagConstraints.gridx = 0;
    gridBagConstraints.gridy = 0;
    gridBagConstraints.gridwidth = 1;
    mainPanel.add(keyLabel, gridBagConstraints);

    keyTextField = new JTextField(20);
    gridBagConstraints.gridx = 1;
    gridBagConstraints.gridy = 0;
    gridBagConstraints.gridwidth = 3;
    mainPanel.add(keyTextField, gridBagConstraints);

    JLabel inputLabel = new JLabel("Plain Text:");
    gridBagConstraints.gridx = 0;
    gridBagConstraints.gridy = 1;
    gridBagConstraints.gridwidth = 1;
    mainPanel.add(inputLabel, gridBagConstraints);

    inputTextArea = new JTextArea(15, 20);
    JScrollPane inputScrollPane = new JScrollPane(inputTextArea);
    gridBagConstraints.gridx = 0;
    gridBagConstraints.gridy = 2;
    gridBagConstraints.gridwidth = 4;
    mainPanel.add(inputScrollPane, gridBagConstraints);

    JLabel outputLabel = new JLabel("Cipher Text:");
    gridBagConstraints.gridx = 0;
    gridBagConstraints.gridy = 3;
    gridBagConstraints.gridwidth = 1;
    mainPanel.add(outputLabel, gridBagConstraints);

    outputTextArea = new JTextArea(15, 20);
    outputTextArea.setEditable(false);
    JScrollPane outputScrollPane = new JScrollPane(outputTextArea);
    gridBagConstraints.gridx = 0;
    gridBagConstraints.gridy = 4;
    gridBagConstraints.gridwidth = 4;
    mainPanel.add(outputScrollPane, gridBagConstraints);

    encryptButton = new JButton("Encrypt");
    gridBagConstraints.gridx = 0;
    gridBagConstraints.gridy = 5;
    gridBagConstraints.gridwidth = 1;
    mainPanel.add(encryptButton, gridBagConstraints);

    unlockAButton = new JButton("Unlock A");
    gridBagConstraints.gridx = 1;
    gridBagConstraints.gridy = 5;
    gridBagConstraints.gridwidth = 1;
    mainPanel.add(unlockAButton, gridBagConstraints);

    unlockBButton = new JButton("Unlock B");
    gridBagConstraints.gridx = 2;
    gridBagConstraints.gridy = 5;
    gridBagConstraints.gridwidth = 1;
    mainPanel.add(unlockBButton, gridBagConstraints);

    decryptButton = new JButton("Decrypt");
    gridBagConstraints.gridx = 3;
    gridBagConstraints.gridy = 5;
    gridBagConstraints.gridwidth = 1;
    mainPanel.add(decryptButton, gridBagConstraints);

    saveButton = new JButton("Save");
    gridBagConstraints.gridx = 0;
    gridBagConstraints.gridy = 6;
    gridBagConstraints.gridwidth = 2;
    mainPanel.add(saveButton, gridBagConstraints);

    showAllButton = new JButton("Show All");
    gridBagConstraints.gridx = 2;
    gridBagConstraints.gridy = 6;
    gridBagConstraints.gridwidth = 2;
    mainPanel.add(showAllButton, gridBagConstraints);

    fileChooser = new JFileChooser();

    encryptButton.addActionListener(this);
    unlockAButton.addActionListener(this);
    unlockBButton.addActionListener(this);
    decryptButton.addActionListener(this);
    saveButton.addActionListener(this);
    showAllButton.addActionListener(this);

    add(mainPanel);
  }

  public void actionPerformed(ActionEvent e) {
    try {
      if (e.getSource() == encryptButton) {
          encryptText();
      } else if (e.getSource() == unlockAButton) {
        unlockA();
      } else if (e.getSource() == unlockBButton) {
        unlockB();
      } else if (e.getSource() == decryptButton) {
        decryptText();
      } else if (e.getSource() == saveButton) {
        saveToFile();
      } else if (e.getSource() == showAllButton) {
        showAll();
      }
    } catch (Throwable ex) {
      ex.printStackTrace();
    }
  }

  private static void doCopy(InputStream is, OutputStream os) throws IOException {
    byte[] bytes = new byte[64];
    int numBytes;
    while ((numBytes = is.read(bytes)) != -1) {
      os.write(bytes, 0, numBytes);
    }
    os.flush();
    os.close();
    is.close();
  }

  public void encryptOrDecrypt(String key, int mode, InputStream is, OutputStream os) throws Throwable {
    DESKeySpec dks = new DESKeySpec(key.getBytes());
    SecretKeyFactory skf = SecretKeyFactory.getInstance("DES");
    SecretKey desKey = skf.generateSecret(dks);
    Cipher cipher = Cipher.getInstance("DES"); // DES/ECB/PKCS5Padding for SunJCE

    if (mode == Cipher.ENCRYPT_MODE) {
      cipher.init(Cipher.ENCRYPT_MODE, desKey);
      CipherInputStream cis = new CipherInputStream(is, cipher);
      doCopy(cis, os);
    } else if (mode == Cipher.DECRYPT_MODE) {
      cipher.init(Cipher.DECRYPT_MODE, desKey);
      CipherOutputStream cos = new CipherOutputStream(os, cipher);
      doCopy(is, cos);
    }
  }

  public void encrypt(String key, InputStream is, OutputStream os) throws Throwable {
    encryptOrDecrypt(key, Cipher.ENCRYPT_MODE, is, os);
  }

  public void decrypt(String key, InputStream is, OutputStream os) throws Throwable {
    encryptOrDecrypt(key, Cipher.DECRYPT_MODE, is, os);
  }

  private void encryptText() throws Throwable {
    String key = keyTextField.getText();

    FileInputStream fis = new FileInputStream("Des.txt");
    FileOutputStream fos = new FileOutputStream("EnDes.txt");
    encrypt(key, fis, fos);
    JOptionPane.showMessageDialog(null, "Đã mã hóa văn bản");
  }

  private void unlockA() {
    try {
      BufferedReader br = null;

      String filename = "KhoaA.txt"; // GEN-
      br = new BufferedReader(new FileReader(filename));
      StringBuffer sb = new StringBuffer();

      JOptionPane.showMessageDialog(null, "Đã mở file");
      char[] ca = new char[5];
      while (br.ready()) {
        int len = br.read(ca);
        sb.append(ca, 0, len);
      }
      br.close();
      // xuat chuoi
      System.out.println("Du lieu la: " + sb);
      String chuoi = sb.toString();
      keyTextField.setText(chuoi);
    } catch (IOException ex) {
      Logger.getLogger(DESCS.class.getName()).log(Level.SEVERE, null, ex);
    }
  }

  private void unlockB() {
    try {
      BufferedReader br = null;

      String filename = "KhoaB.txt"; // GEN-
      br = new BufferedReader(new FileReader(filename));
      StringBuffer sb = new StringBuffer();

      JOptionPane.showMessageDialog(null, "Đã mở file");
      char[] ca = new char[5];
      while (br.ready()) {
        int len = br.read(ca);
        sb.append(ca, 0, len);
      }
      br.close();
      // xuat chuoi
      System.out.println("Du lieu la: " + sb);
      String chuoi = sb.toString();
      keyTextField.setText(chuoi);
    } catch (IOException ex) {
      Logger.getLogger(DESCS.class.getName()).log(Level.SEVERE, null, ex);
    }
  }

  private void decryptText() {
    FileInputStream fis2 = null;
    try {
      String key = keyTextField.getText();

      fis2 = new FileInputStream("EnDes.txt");
      FileOutputStream fos2 = new FileOutputStream("DeDes.txt");
      decrypt(key, fis2, fos2);
      BufferedReader br = null;
      String filename = "DeDes.txt"; // GEN-
      br = new BufferedReader(new FileReader(filename));
      StringBuffer sb = new StringBuffer();
      JOptionPane.showMessageDialog(null, "Đã giải mã");
      char[] ca = new char[5];
      while (br.ready()) {
        int len = br.read(ca);
        sb.append(ca, 0, len);
      }
      br.close();
      // xuat chuoi
      System.out.println("Du lieu la: " + sb);
      String chuoi = sb.toString();
      outputTextArea.setText(chuoi);
    } catch (Throwable ex) { }
  }

  private void saveToFile() {
    try {
      BufferedWriter bw = null;

      String filename = "Des.txt";
      String s = inputTextArea.getText();
      bw = new BufferedWriter(new FileWriter(filename));
      bw.write(s);
      bw.close();
      JOptionPane.showMessageDialog(null, "Đã lưu file");
      outputTextArea.setText(s);
    } catch (IOException ex) {
      Logger.getLogger(DESCS.class.getName()).log(Level.SEVERE, null, ex);
    }
  }

  private void showAll() {
    try {
      BufferedReader br = null;

      String filename = "Des.txt"; // GEN-
      br = new BufferedReader(new FileReader(filename));
      StringBuffer sb = new StringBuffer();

      JOptionPane.showMessageDialog(null, "Đã mở file");
      char[] ca = new char[5];
      while (br.ready()) {
        int len = br.read(ca);
        sb.append(ca, 0, len);
      }
      br.close();
      String ff = "EnDes.txt";
      br = new BufferedReader(new FileReader(ff));
      StringBuffer sb1 = new StringBuffer();
      char[] ca1 = new char[5];
      while (br.ready()) {
        int len = br.read(ca1);
        sb1.append(ca1, 0, len);
      }
      // xuat chuoi
      System.out.println("Du lieu la: " + sb);
      String chuoi = sb.toString();
      String chuoi1 = sb1.toString();
      inputTextArea.setText(chuoi);
      outputTextArea.setText(chuoi1);
    } catch (IOException ex) { }
  }

  public static void main(String[] args) {
    SwingUtilities.invokeLater(() -> {
      DESCS program = new DESCS();
      program.setVisible(true);
    });
  }
}
