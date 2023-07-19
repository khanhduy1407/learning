package lab05;

import javax.crypto.Cipher;
import javax.crypto.KeyAgreement;
import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
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

public class AliceForm extends JFrame {
  private JTextField aliceKeyField;
  private JTextField bobKeyField;
  private JTextField kabKeyField;
  private JTextField encryptedKabField;
  private JButton generateAKeyButton;
  private JButton displayKbButton;
  private JButton generateSharedKeyButton;
  private JButton encryptKabButton;
  private JButton encryptDecryptButton;

  KeyAgreement aliceKeyAgree;
  PublicKey bobPubKey;
  Cipher aliceDesKey;

  public AliceForm() {
    setTitle("Alice Form");
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    JPanel contentPanel = new JPanel();
    contentPanel.setBorder(new EmptyBorder(20, 20, 20, 20));
    contentPanel.setLayout(new GridBagLayout());
    GridBagConstraints gbc = new GridBagConstraints();
    gbc.insets = new Insets(5, 5, 5, 5);

    // Create input fields
    JLabel aliceKeyLabel = new JLabel("Alice Key:");
    aliceKeyField = new JTextField(10);

    JLabel bobKeyLabel = new JLabel("Bob Key:");
    bobKeyField = new JTextField(10);

    JLabel kabKeyLabel = new JLabel("KAB Key:");
    kabKeyField = new JTextField(10);

    JLabel encryptedKabLabel = new JLabel("Encrypted KAB:");
    encryptedKabField = new JTextField(10);
//    encryptedKabField.setEditable(false);

    // Create buttons
    generateAKeyButton = new JButton("Generate A Key");
    displayKbButton = new JButton("Display KB");
    generateSharedKeyButton = new JButton("Generate Shared Key");
    encryptKabButton = new JButton("Encrypt KAB");
    encryptDecryptButton = new JButton("Encrypt/Decrypt");

    // Add components to the frame
    gbc.gridx = 0;
    gbc.gridy = 0;
    gbc.anchor = GridBagConstraints.LINE_START;
    contentPanel.add(aliceKeyLabel, gbc);

    gbc.gridy = 1;
    contentPanel.add(bobKeyLabel, gbc);

    gbc.gridy = 2;
    contentPanel.add(kabKeyLabel, gbc);

    gbc.gridy = 3;
    contentPanel.add(encryptedKabLabel, gbc);

    gbc.gridx = 1;
    gbc.gridy = 0;
    gbc.fill = GridBagConstraints.HORIZONTAL;
    gbc.weightx = 1.0;
    contentPanel.add(aliceKeyField, gbc);

    gbc.gridy = 1;
    contentPanel.add(bobKeyField, gbc);

    gbc.gridy = 2;
    contentPanel.add(kabKeyField, gbc);

    gbc.gridy = 3;
    contentPanel.add(encryptedKabField, gbc);

    gbc.gridx = 2;
    gbc.gridy = 0;
    gbc.fill = GridBagConstraints.NONE;
    gbc.weightx = 0.0;
    contentPanel.add(generateAKeyButton, gbc);

    gbc.gridy = 1;
    contentPanel.add(displayKbButton, gbc);

    gbc.gridy = 2;
    contentPanel.add(generateSharedKeyButton, gbc);

    gbc.gridy = 3;
    contentPanel.add(encryptKabButton, gbc);

    gbc.gridy = 4;
    gbc.anchor = GridBagConstraints.LINE_END;
    contentPanel.add(encryptDecryptButton, gbc);

    // Set action listeners for buttons
    generateAKeyButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          AlgorithmParameterGenerator paramGen = AlgorithmParameterGenerator.getInstance("DH");
          paramGen.init(512);
          AlgorithmParameters params = paramGen.generateParameters();

          DHParameterSpec dhSkipParamSpec = (DHParameterSpec) params.getParameterSpec(DHParameterSpec.class);

          System.out.println("Generate a DH keypair ...");
          KeyPairGenerator aliceKpairGen = KeyPairGenerator.getInstance("DH");
          aliceKpairGen.initialize(dhSkipParamSpec);
          KeyPair aliceKpair = aliceKpairGen.generateKeyPair();

          System.out.println("Initialize the KeyAgreement with the DH private key");
          aliceKeyAgree = KeyAgreement.getInstance("DH");
          aliceKeyAgree.init(aliceKpair.getPrivate());

          byte[] alicePubKeyEnc = aliceKpair.getPublic().getEncoded();
          FileOutputStream fos = new FileOutputStream("A.pub");
          fos.write(alicePubKeyEnc);
          fos.close();
          aliceKeyField.setText(alicePubKeyEnc.toString());
        } catch (Exception ex) { }
      }
    });

    displayKbButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          FileInputStream fis = new FileInputStream("B.pub");
          byte[] bkeyB = new byte[fis.available()];
          fis.read(bkeyB);
          fis.close();
          bobKeyField.setText(bkeyB.toString());
        } catch (Exception ex) { }
      }
    });

    generateSharedKeyButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          FileInputStream fis = new FileInputStream("B.pub");
          byte[] bobPubKeyEnc = new byte[fis.available()];
          fis.read(bobPubKeyEnc);
          fis.close();

          KeyFactory aliceKeyFac = KeyFactory.getInstance("DH");
          X509EncodedKeySpec x509KeySpec = new X509EncodedKeySpec(bobPubKeyEnc);
          bobPubKey = aliceKeyFac.generatePublic(x509KeySpec);
          System.out.println("Execute PHASE1 of key agreement ...");
          aliceKeyAgree.doPhase(bobPubKey, true);
          byte[] aliceSharedSecret = aliceKeyAgree.generateSecret();

          System.out.println("Khoa chung: secret (DEBUG ONLY): " + CryptoUtil.toHexString(aliceSharedSecret));
          kabKeyField.setText(CryptoUtil.toHexString(aliceSharedSecret));
        } catch (Exception ex) { }
      }
    });

    encryptKabButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          aliceKeyAgree.doPhase(bobPubKey, true);
          KeyGenerator keyGenerator = KeyGenerator.getInstance("DES");
          SecretKey secretKey = keyGenerator.generateKey();
          aliceDesKey = Cipher.getInstance("DES");
          aliceDesKey.init(Cipher.ENCRYPT_MODE, secretKey);
          encryptedKabField.setText(aliceDesKey.toString());
          // Khoa chung A-B
          BufferedWriter bw = null;
          // Ghi van ban da ma hoa
          String filename = "KhoaA.txt";
          // Luu van ban
          bw = new BufferedWriter(new FileWriter(filename));
          bw.write(aliceDesKey.toString());
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
        new AliceForm();
      }
    });
  }
}
