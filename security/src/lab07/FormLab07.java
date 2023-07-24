package lab07;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.security.MessageDigest;

/**
 * Bài thực hành số 7: Mã hóa MD5
 *
 * @author Nguyễn Khánh Duy (2180602080)
 */
public class FormLab07 extends JFrame implements ActionListener {
  private final JTextField usernameField;
  private final JPasswordField passwordField;
  private final JTextArea result1Area;
  private final JTextArea result2Area;
  private final JTextArea usernamePassArea;

  public FormLab07() {
    setTitle("HASH MD5");
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

    JLabel usernameLabel = new JLabel("Username:");
    usernameField = new JTextField();
    usernameField.setPreferredSize(new Dimension(200, 30));

    JLabel passwordLabel = new JLabel("Password:");
    passwordField = new JPasswordField();
    passwordField.setPreferredSize(new Dimension(200, 30));

    JLabel result1Label = new JLabel("Result 1:");
    result1Area = new JTextArea();
    result1Area.setLineWrap(true);
    result1Area.setEditable(false);
    JScrollPane result1ScrollPane = new JScrollPane(result1Area);
    result1ScrollPane.setPreferredSize(new Dimension(200, 80));

    JLabel result2Label = new JLabel("Result 2:");
    result2Area = new JTextArea();
    result2Area.setLineWrap(true);
    result2Area.setEditable(false);
    JScrollPane result2ScrollPane = new JScrollPane(result2Area);
    result2ScrollPane.setPreferredSize(new Dimension(200, 80));

    JLabel usernamePassLabel = new JLabel("Chuỗi: username + pass");
    usernamePassArea = new JTextArea();
    usernamePassArea.setLineWrap(true);
    usernamePassArea.setEditable(false);
    JScrollPane usernamePassScrollPane = new JScrollPane(usernamePassArea);
    usernamePassScrollPane.setPreferredSize(new Dimension(200, 80));

    JButton loginButton = new JButton("Đăng nhập");
    loginButton.setPreferredSize(new Dimension(150, 30));
    loginButton.addActionListener(this);

    JButton registerButton = new JButton("Đăng ký");
    registerButton.setPreferredSize(new Dimension(150, 30));
    registerButton.addActionListener(this);

    // Add components to the panel using GridBagLayout
    constraints.gridx = 0;
    constraints.gridy = 0;
    panel.add(usernameLabel, constraints);

    constraints.gridx = 1;
    panel.add(usernameField, constraints);

    constraints.gridx = 0;
    constraints.gridy = 1;
    panel.add(passwordLabel, constraints);

    constraints.gridx = 1;
    panel.add(passwordField, constraints);

    constraints.gridx = 0;
    constraints.gridy = 2;
    panel.add(result1Label, constraints);

    constraints.gridx = 1;
    panel.add(result1ScrollPane, constraints);

    constraints.gridx = 0;
    constraints.gridy = 3;
    panel.add(result2Label, constraints);

    constraints.gridx = 1;
    panel.add(result2ScrollPane, constraints);

    constraints.gridx = 0;
    constraints.gridy = 4;
    panel.add(usernamePassLabel, constraints);

    constraints.gridx = 1;
    panel.add(usernamePassScrollPane, constraints);

    constraints.gridx = 0;
    constraints.gridy = 5;
    constraints.gridwidth = 2; // Span across two columns
    panel.add(loginButton, constraints);

    constraints.gridx = 0;
    constraints.gridy = 6;
    panel.add(registerButton, constraints);

    add(panel);
    pack();
    setVisible(true);
  }

  public static void main(String[] args) {
    new FormLab07();
  }

  @Override
  public void actionPerformed(ActionEvent e) {
    if (e.getActionCommand().equals("Đăng nhập")) {
      dangNhap();
    } else if (e.getActionCommand().equals("Đăng ký")) {
      dangKy(e);
    }
  }

  private void dangKy(ActionEvent e) {
    try {
      // TODO add your handling code here:
      String user = usernameField.getText();
      String pass = passwordField.getText();
      String bam = "";
      bam = user + pass;
      MessageDigest md = MessageDigest.getInstance("MD5");
      md.update(bam.getBytes());
      byte[] byteData = md.digest();
      // convert the byte to hex format method 1
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < byteData.length; i++) {
        sb.append(Integer.toString((byteData[i] & 0xff) + 0x100, 16).substring(1));
      }
      System.out.println("Digest(in hex format):: " + sb.toString());
      result1Area.setText(sb.toString());
      // convert the byte to hex format method 2
      StringBuilder hexString = new StringBuilder();
      for (int i = 0; i < byteData.length; i++) {
        String hex = Integer.toHexString(0xff & byteData[i]);
        if (hex.length() == 1) {
          hexString.append('0');
        }
        hexString.append(hex);
      }
      System.out.println("Digest(in hex format):: " + hexString.toString());
      result2Area.setText(hexString.toString());
      usernamePassArea.setText(bam);
      // viết chức năng ghi file
      BufferedWriter bw = null;
      // ghi văn bản đã mã hóa
      String fileName = "MD5.txt";
      // Lưu văn bản
      bw = new BufferedWriter(new FileWriter(fileName));
      bw.write(hexString.toString());
      bw.close();
      JOptionPane.showMessageDialog(this, "Đăng ký thành công. Vui lòng đăng nhập lại!!!");
    } catch (Exception ex) {
      System.out.println("Lỗi băm username và password: " + ex);
    }
  }

  private void dangNhap() {
    // TODO add your handling code here:
    String user = usernameField.getText();
    String pass = passwordField.getText();
    String bam = "";
    bam = user + pass;
    BufferedReader br = null;
    String fileName = "MD5.txt";
    try {
      br = new BufferedReader(new FileReader(fileName));
      StringBuilder sb = new StringBuilder();
      char[] ca = new char[5];
      while (br.ready()) {
        int len = br.read(ca);
        sb.append(ca, 0, len);
      }
      br.close();
      // hiển thị file đã lưu
      System.out.println("Chứng thực: " + sb);
      String chuoi = sb.toString();

      // thực hiện băm username và password cho người dùng đăng nhập
      MessageDigest md = MessageDigest.getInstance("MD5");
      md.update(bam.getBytes());
      byte[] byteData = md.digest();
      StringBuffer hexString = new StringBuffer();
      for (int i = 0; i < byteData.length; i++) {
        String hex = Integer.toHexString(0xff & byteData[i]);
        if (hex.length() == 1) {
          hexString.append('0');
        }
        hexString.append(hex);
      }
      System.out.println("Băm username và password: " + hexString.toString());
      // thực hiện so sánh username và password
      boolean k = hexString.toString().equals(chuoi);
      if (k) {
        JOptionPane.showMessageDialog(this, "Đăng nhập thành công!!!");
        result1Area.setText(hexString.toString());
        result2Area.setText(chuoi);
        usernamePassArea.setText("Username: " + user + "\nPassword: " + pass);
      } else {
        JOptionPane.showMessageDialog(this, "Đăng nhập thất bại!!!");
      }
    } catch (Exception ex) {
      System.out.println("Lỗi đăng nhập: " + ex);
    }

  }
}
