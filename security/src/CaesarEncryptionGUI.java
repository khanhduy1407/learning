import javax.swing.*;
import java.awt.*;

public class CaesarEncryptionGUI extends JFrame {
    private JTextField messageTextField;
    private JTextField shiftTextField;
    private JTextArea resultTextArea;

    public CaesarEncryptionGUI() {
        setTitle("Caesar Encryption");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(400, 300);
        setLocationRelativeTo(null);

        // Panel chứa các thành phần giao diện
        JPanel mainPanel = new JPanel();
        mainPanel.setLayout(new GridLayout(4, 1));

        // Panel cho nhập thông tin tin nhắn
        JPanel inputPanel = new JPanel();
        inputPanel.setLayout(new FlowLayout());
        JLabel messageLabel = new JLabel("Message: ");
        messageTextField = new JTextField(20);
        inputPanel.add(messageLabel);
        inputPanel.add(messageTextField);
        mainPanel.add(inputPanel);

        // Panel cho nhập thông tin shift
        JPanel shiftPanel = new JPanel();
        shiftPanel.setLayout(new FlowLayout());
        JLabel shiftLabel = new JLabel("Shift: ");
        shiftTextField = new JTextField(5);
        shiftPanel.add(shiftLabel);
        shiftPanel.add(shiftTextField);
        mainPanel.add(shiftPanel);

        // Panel cho kết quả
        JPanel resultPanel = new JPanel();
        resultPanel.setLayout(new BorderLayout());
        JLabel resultLabel = new JLabel("Result: ");
        resultTextArea = new JTextArea(8, 30);
        resultTextArea.setEditable(false);
        JScrollPane scrollPane = new JScrollPane(resultTextArea);
        resultPanel.add(resultLabel, BorderLayout.NORTH);
        resultPanel.add(scrollPane, BorderLayout.CENTER);
        mainPanel.add(resultPanel);

        // Panel cho các nút chức năng
        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new FlowLayout());
        JButton encryptButton = new JButton("Encrypt");
        JButton decryptButton = new JButton("Decrypt");
        buttonPanel.add(encryptButton);
        buttonPanel.add(decryptButton);
        mainPanel.add(buttonPanel);

        // Xử lý sự kiện khi nhấn nút Encrypt
        encryptButton.addActionListener(e -> {
            String message = messageTextField.getText();
            int shift = Integer.parseInt(shiftTextField.getText());

            String encryptedMessage = improvedCaesarEncrypt(message, shift);
            resultTextArea.setText(encryptedMessage);
        });

        // Xử lý sự kiện khi nhấn nút Decrypt
        decryptButton.addActionListener(e -> {
            String encryptedMessage = resultTextArea.getText();
            int shift = Integer.parseInt(shiftTextField.getText());

            String decryptedMessage = improvedCaesarDecrypt(encryptedMessage, shift);
            resultTextArea.setText(decryptedMessage);
        });

        add(mainPanel);
    }

    // Hàm mã hóa Caesar cải tiến
    private String improvedCaesarEncrypt(String message, int shift) {
        StringBuilder substitutedMessage = new StringBuilder();
        for (int i = 0; i < message.length(); i++) {
            char c = message.charAt(i);
            if (Character.isLetter(c)) {
                char base = Character.isUpperCase(c) ? 'A' : 'a';
                c = (char) (((c - base + shift) % 26) + base);
            }
            substitutedMessage.append(c);
        }

        StringBuilder encryptedMessage = new StringBuilder();
        for (int i = 0; i < substitutedMessage.length(); i += 2) {
            if (i + 1 < substitutedMessage.length()) {
                encryptedMessage.append(substitutedMessage.charAt(i + 1)).append(substitutedMessage.charAt(i));
            } else {
                encryptedMessage.append(substitutedMessage.charAt(i));
            }
        }

        return encryptedMessage.toString();
    }

    // Hàm giải mã Caesar cải tiến
    private String improvedCaesarDecrypt(String encryptedMessage, int shift) {
        StringBuilder substitutedMessage = new StringBuilder();
        for (int i = 0; i < encryptedMessage.length(); i += 2) {
            if (i + 1 < encryptedMessage.length()) {
                substitutedMessage.append(encryptedMessage.charAt(i + 1)).append(encryptedMessage.charAt(i));
            } else {
                substitutedMessage.append(encryptedMessage.charAt(i));
            }
        }

        StringBuilder decryptedMessage = new StringBuilder();
        for (int i = 0; i < substitutedMessage.length(); i++) {
            char c = substitutedMessage.charAt(i);
            if (Character.isLetter(c)) {
                char base = Character.isUpperCase(c) ? 'A' : 'a';
                c = (char) (((c - base - shift + 26) % 26) + base);
            }
            decryptedMessage.append(c);
        }

        return decryptedMessage.toString();
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> new CaesarEncryptionGUI().setVisible(true));
    }
}
