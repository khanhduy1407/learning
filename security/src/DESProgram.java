import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.security.InvalidKeyException;
import java.security.NoSuchAlgorithmException;
import java.security.spec.InvalidKeySpecException;
import java.util.Base64;

import javax.crypto.*;
import javax.crypto.spec.*;

public class DESProgram extends JFrame implements ActionListener {
    private JTextField keyTextField;
    private JTextArea inputTextArea;
    private JTextArea outputTextArea;

    private JButton encryptButton;
    private JButton decryptButton;
    private JButton saveButton;
    private JButton openButton;
    private JButton showAllButton;

    private JFileChooser fileChooser;

    public DESProgram() {
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

        decryptButton = new JButton("Decrypt");
        gridBagConstraints.gridx = 1;
        gridBagConstraints.gridy = 5;
        gridBagConstraints.gridwidth = 1;
        mainPanel.add(decryptButton, gridBagConstraints);

        saveButton = new JButton("Save");
        gridBagConstraints.gridx = 2;
        gridBagConstraints.gridy = 5;
        gridBagConstraints.gridwidth = 1;
        mainPanel.add(saveButton, gridBagConstraints);

        openButton = new JButton("Open");
        gridBagConstraints.gridx = 3;
        gridBagConstraints.gridy = 5;
        gridBagConstraints.gridwidth = 1;
        mainPanel.add(openButton, gridBagConstraints);

        showAllButton = new JButton("Show All");
        gridBagConstraints.gridx = 0;
        gridBagConstraints.gridy = 6;
        gridBagConstraints.gridwidth = 4;
        mainPanel.add(showAllButton, gridBagConstraints);

        fileChooser = new JFileChooser();

        encryptButton.addActionListener(this);
        decryptButton.addActionListener(this);
        saveButton.addActionListener(this);
        openButton.addActionListener(this);
        showAllButton.addActionListener(this);

        add(mainPanel);
    }

    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == encryptButton) {
            encryptText();
        } else if (e.getSource() == decryptButton) {
            decryptText();
        } else if (e.getSource() == saveButton) {
            saveToFile();
        } else if (e.getSource() == openButton) {
            openFromFile();
        } else if (e.getSource() == showAllButton) {
            showAll();
        }
    }

    private SecretKey generateKey(String keyString) throws NoSuchAlgorithmException, InvalidKeyException, InvalidKeySpecException {
        byte[] keyData = keyString.getBytes(StandardCharsets.UTF_8);
        DESKeySpec spec = new DESKeySpec(keyData);
        SecretKeyFactory keyFactory = SecretKeyFactory.getInstance("DES");
        return keyFactory.generateSecret(spec);
    }

    private String encrypt(String plainText, SecretKey key) throws NoSuchAlgorithmException, NoSuchPaddingException,
            InvalidKeyException, IllegalBlockSizeException, BadPaddingException {
        Cipher cipher = Cipher.getInstance("DES/ECB/PKCS5Padding");
        cipher.init(Cipher.ENCRYPT_MODE, key);
        byte[] encryptedBytes = cipher.doFinal(plainText.getBytes(StandardCharsets.UTF_8));
        return Base64.getEncoder().encodeToString(encryptedBytes);
    }

    private String decrypt(String cipherText, SecretKey key) throws NoSuchAlgorithmException, NoSuchPaddingException,
            InvalidKeyException, IllegalBlockSizeException, BadPaddingException {
        Cipher cipher = Cipher.getInstance("DES/ECB/PKCS5Padding");
        cipher.init(Cipher.DECRYPT_MODE, key);
        byte[] decryptedBytes = cipher.doFinal(Base64.getDecoder().decode(cipherText));
        return new String(decryptedBytes, StandardCharsets.UTF_8);
    }

    private void encryptText() {
        try {
            String plainText = inputTextArea.getText();
            String keyString = keyTextField.getText();

            SecretKey key = generateKey(keyString);
            String encryptedText = encrypt(plainText, key);

            outputTextArea.setText(encryptedText);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, "Encryption error: " + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private void decryptText() {
        try {
            String cipherText = inputTextArea.getText();
            String keyString = keyTextField.getText();

            SecretKey key = generateKey(keyString);
            String decryptedText = decrypt(cipherText, key);

            outputTextArea.setText(decryptedText);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, "Decryption error: " + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private void saveToFile() {
        int returnVal = fileChooser.showSaveDialog(this);
        if (returnVal == JFileChooser.APPROVE_OPTION) {
            File file = fileChooser.getSelectedFile();
            try (BufferedWriter writer = new BufferedWriter(new FileWriter(file))) {
                String text = outputTextArea.getText();
                writer.write(text);
                JOptionPane.showMessageDialog(this, "File saved successfully.", "Success", JOptionPane.INFORMATION_MESSAGE);
            } catch (IOException e) {
                JOptionPane.showMessageDialog(this, "Error saving file: " + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
            }
        }
    }

    private void openFromFile() {
        int returnVal = fileChooser.showOpenDialog(this);
        if (returnVal == JFileChooser.APPROVE_OPTION) {
            File file = fileChooser.getSelectedFile();
            try {
                Path path = Paths.get(file.getAbsolutePath());
                String text = Files.readString(path);
                inputTextArea.setText(text);
            } catch (IOException e) {
                JOptionPane.showMessageDialog(this, "Error opening file: " + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
            }
        }
    }

    private void showAll() {
        String keyString = keyTextField.getText();
        String plainText = inputTextArea.getText();
        String cipherText = outputTextArea.getText();

        String message = "Key: " + keyString + "\n\n" +
                "Plain Text:\n" + plainText + "\n\n" +
                "Cipher Text:\n" + cipherText;

        JOptionPane.showMessageDialog(this, message, "All Data", JOptionPane.INFORMATION_MESSAGE);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            DESProgram program = new DESProgram();
            program.setVisible(true);
        });
    }
}
