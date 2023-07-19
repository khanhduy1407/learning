package lab05;

import javax.crypto.Cipher;
import javax.crypto.KeyAgreement;
import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
import javax.crypto.interfaces.DHPublicKey;
import javax.crypto.spec.DHParameterSpec;
import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedWriter;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.security.*;
import java.security.spec.X509EncodedKeySpec;

public class BobForm extends JFrame {
  private JTextField bobKeyField;
  private JTextField aliceKeyField;
  private JTextField kabKeyField;
  private JTextField encryptedKabField;
  private JButton generateBKeyButton;
  private JButton displayKaButton;
  private JButton generateSharedKeyButton;
  private JButton encryptKabButton;
  private JButton encryptDecryptButton;

  KeyAgreement bobKeyAgree;
  PublicKey alicePubKey;
  Cipher bobDesKey;

  public BobForm() {
    setTitle("Bob Form");
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    JPanel contentPanel = new JPanel();
    contentPanel.setBorder(new EmptyBorder(20, 20, 20, 20));
    contentPanel.setLayout(new GridBagLayout());
    GridBagConstraints gbc = new GridBagConstraints();
    gbc.insets = new Insets(5, 5, 5, 5);

    // Create input fields
    JLabel bobKeyLabel = new JLabel("Bob Key:");
    bobKeyField = new JTextField(10);

    JLabel aliceKeyLabel = new JLabel("Alice Key:");
    aliceKeyField = new JTextField(10);

    JLabel kabKeyLabel = new JLabel("KAB Key:");
    kabKeyField = new JTextField(10);

    JLabel encryptedKabLabel = new JLabel("Encrypted KAB:");
    encryptedKabField = new JTextField(10);
//    encryptedKabField.setEditable(false);

    // Create buttons
    generateBKeyButton = new JButton("Generate B Key");
    displayKaButton = new JButton("Display KA");
    generateSharedKeyButton = new JButton("Generate Shared Key");
    encryptKabButton = new JButton("Encrypt KAB");
    encryptDecryptButton = new JButton("Encrypt/Decrypt");

    // Add components to the frame
    gbc.gridx = 0;
    gbc.gridy = 0;
    gbc.anchor = GridBagConstraints.LINE_START;
    contentPanel.add(bobKeyLabel, gbc);

    gbc.gridy = 1;
    contentPanel.add(aliceKeyLabel, gbc);

    gbc.gridy = 2;
    contentPanel.add(kabKeyLabel, gbc);

    gbc.gridy = 3;
    contentPanel.add(encryptedKabLabel, gbc);

    gbc.gridx = 1;
    gbc.gridy = 0;
    gbc.fill = GridBagConstraints.HORIZONTAL;
    gbc.weightx = 1.0;
    contentPanel.add(bobKeyField, gbc);

    gbc.gridy = 1;
    contentPanel.add(aliceKeyField, gbc);

    gbc.gridy = 2;
    contentPanel.add(kabKeyField, gbc);

    gbc.gridy = 3;
    contentPanel.add(encryptedKabField, gbc);

    gbc.gridx = 2;
    gbc.gridy = 0;
    gbc.fill = GridBagConstraints.NONE;
    gbc.weightx = 0.0;
    contentPanel.add(generateBKeyButton, gbc);

    gbc.gridy = 1;
    contentPanel.add(displayKaButton, gbc);

    gbc.gridy = 2;
    contentPanel.add(generateSharedKeyButton, gbc);

    gbc.gridy = 3;
    contentPanel.add(encryptKabButton, gbc);

    gbc.gridy = 4;
    gbc.anchor = GridBagConstraints.LINE_END;
    contentPanel.add(encryptDecryptButton, gbc);

    // Set action listeners for buttons
    generateBKeyButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          boolean read = false;

          while (!read) {
            try {
              FileInputStream fis = new FileInputStream("A.pub");
              fis.close();
              read = true;
            } catch (Exception ex) { }
          }

          FileInputStream fis = new FileInputStream("A.pub");
          byte[] alicePubKeyEnc = new byte[fis.available()];
          fis.read(alicePubKeyEnc);
          fis.close();
          KeyFactory bobKeyFac = KeyFactory.getInstance("DH");
          X509EncodedKeySpec x509KeySpec = new X509EncodedKeySpec(alicePubKeyEnc);
          alicePubKey = bobKeyFac.generatePublic(x509KeySpec);
          DHParameterSpec dhParamSpec = ((DHPublicKey) alicePubKey).getParams();
          System.out.println("Generate DH keypair ...");
          KeyPairGenerator bobKpairGen = KeyPairGenerator.getInstance("DH");
          bobKpairGen.initialize(dhParamSpec);
          KeyPair bobKpair = bobKpairGen.generateKeyPair();
          System.out.println("Initializing KeyAgreement engine ...");
          bobKeyAgree = KeyAgreement.getInstance("DH");
          bobKeyAgree.init(bobKpair.getPrivate());
          byte[] bobPubKeyEnc = bobKpair.getPublic().getEncoded();
          FileOutputStream fos = new FileOutputStream("B.pub");
          fos.write(bobPubKeyEnc);
          fos.close();
          bobKeyField.setText(bobPubKeyEnc.toString());
        } catch (Exception ex) { }
      }
    });

    displayKaButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          FileInputStream fis = new FileInputStream("A.pub");
          byte[] akeyP = new byte[fis.available()];
          fis.read(akeyP);
          fis.close();
          aliceKeyField.setText(akeyP.toString());
        } catch (Exception ex) { }
      }
    });

    generateSharedKeyButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          bobKeyAgree.doPhase(alicePubKey, true);
          byte[] bobSharedSecret = bobKeyAgree.generateSecret();
          System.out.println("Khoa chung: Shared secret (DEBUG ONLY): " + CryptoUtil.toHexString(bobSharedSecret));
          kabKeyField.setText(CryptoUtil.toHexString(bobSharedSecret));
        } catch (Exception ex) { }
      }
    });

    encryptKabButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          bobKeyAgree.doPhase(alicePubKey, true);
          KeyGenerator keyGenerator = KeyGenerator.getInstance("DES");
          SecretKey secretKey = keyGenerator.generateKey();
          bobDesKey = Cipher.getInstance("DES");
          bobDesKey.init(Cipher.ENCRYPT_MODE, secretKey);
          encryptedKabField.setText(bobDesKey.toString());
          // Khoa chung A-B
          BufferedWriter bw = null;
          // Ghi van ban da ma hoa
          String filename = "KhoaB.txt";
          // Luu van ban
          bw = new BufferedWriter(new FileWriter(filename));
          bw.write(bobDesKey.toString());
          bw.close();
        } catch (Exception ex) {
          System.out.println("Lỗi: " + ex);
        }
      }
    });

    encryptDecryptButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        DESCS des = new DESCS();
        des.setVisible(true);
      }
    });

    setContentPane(contentPanel);
    pack();
    setVisible(true);
  }

  public static void main(String[] args) {
    SwingUtilities.invokeLater(new Runnable() {
      public void run() {
        new BobForm();
      }
    });
  }
}
