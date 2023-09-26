using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03_02
{
  public partial class Form1 : Form
  {
    private string currentFilePath = null; // Biến để lưu đường dẫn tập tin hiện tại

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Tạo dữ liệu cho ComboBox Font
      string[] fontNames = FontFamily.Families.Select(f => f.Name).ToArray();
      comboBoxFont.Items.AddRange(fontNames);

      // Tạo dữ liệu cho ComboBox Size
      int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
      comboBoxSize.Items.AddRange(fontSizes.Select(size => size.ToString()).ToArray());

      // Thiết lập giá trị mặc định cho ComboBox Font và ComboBox Size
      comboBoxFont.SelectedItem = "Tahoma";
      comboBoxSize.SelectedItem = "14";
    }

    private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FontDialog fontDlg = new FontDialog();
      fontDlg.ShowColor = true;
      fontDlg.ShowApply = true;
      fontDlg.ShowEffects = true;
      fontDlg.ShowHelp = true;
      if (fontDlg.ShowDialog() != DialogResult.Cancel)
      {
        richText.ForeColor = fontDlg.Color;
        richText.Font = fontDlg.Font;
      }
    }

    private void tạoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      newFile();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      newFile();
    }

    private void newFile()
    {
      // Xóa nội dung hiện có của RichTextBox
      richText.Clear();

      // Thiết lập lại giá trị mặc định cho Font và Size
      comboBoxFont.SelectedItem = "Tahoma";
      comboBoxSize.SelectedItem = "14";

      // Đặt lại việc hiển thị dấu nháy ở vị trí đầu tiên của RichTextBox
      richText.Select(0, 0);
    }

    private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
    {
      readFile();
    }

    private void readFile()
    {
      richText.Clear();

      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = "Tập tin văn bản (*.txt;*.rtf)|*.txt;*.rtf|Tất cả các tập tin (*.*)|*.*";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          string filePath = openFileDialog.FileName;

          // Kiểm tra loại tập tin và đọc nội dung
          if (filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
          {
            // Đối với tập tin .txt
            richText.LoadFile(filePath, RichTextBoxStreamType.PlainText);
          }
          else if (filePath.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
          {
            // Đối với tập tin .rtf
            richText.LoadFile(filePath, RichTextBoxStreamType.RichText);
          }
          else
          {
            MessageBox.Show("Loại tập tin không được hỗ trợ.");
          }
        }
      }
    }

    private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
    {
      saveData();
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      saveData();
    }

    private void saveData()
    {
      if (string.IsNullOrEmpty(currentFilePath))
      {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
          saveFileDialog.Filter = "Tập tin RTF (*.rtf)|*.rtf";
          if (saveFileDialog.ShowDialog() == DialogResult.OK)
          {
            currentFilePath = saveFileDialog.FileName;
            richText.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
            MessageBox.Show("Đã lưu thành công.");
          }
        }
      }
      else
      {
        richText.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
        MessageBox.Show("Đã lưu thành công.");
      }
    }

    private void boldButton_Click(object sender, EventArgs e)
    {
      if (richText.SelectionFont != null)
      {
        Font currentFont = richText.SelectionFont;
        FontStyle newStyle = FontStyle.Bold | (currentFont.Italic ? FontStyle.Italic : FontStyle.Regular);
        richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
      }
    }

    private void italicButton_Click(object sender, EventArgs e)
    {
      if (richText.SelectionFont != null)
      {
        Font currentFont = richText.SelectionFont;
        FontStyle newStyle = FontStyle.Italic | (currentFont.Bold ? FontStyle.Bold : FontStyle.Regular);
        richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
      }
    }

    private void underlineButton_Click(object sender, EventArgs e)
    {
      if (richText.SelectionFont != null)
      {
        richText.SelectionCharOffset = richText.SelectionCharOffset == 0 ? 2 : 0;
        richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style ^ FontStyle.Underline);
      }
    }
  }
}
