using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_rich_text_editor
{
    public partial class FrmMain : Form
    {
        MemoryStream userinput = new MemoryStream();

        public FrmMain()
        {
            InitializeComponent();
            FillFontNames();
        }

        private void FillFontNames()
        {
            
        }

        /// <summary>
        /// method used to add all shortcuts
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.B) && e.Control)
            {
                SetBold();
            }
        }
        /// <summary>
        /// method to set/unset the selected text to bold text
        /// </summary>
        private void SetBold()
        {
            string font_name = MainText.SelectionFont.Name;
            float font_size = MainText.SelectionFont.Size;
            bool isBold = MainText.SelectionFont.Bold;
            if (isBold)
                MainText.SelectionFont = new Font(font_name, font_size, FontStyle.Regular);
            else
                MainText.SelectionFont = new Font(font_name, font_size, FontStyle.Bold);
        }
        /// <summary>
        /// method to set/unset the selected text to italic text
        /// </summary>
        private void SetItalic()
        {
            string font_name = MainText.SelectionFont.Name;
            float font_size = MainText.SelectionFont.Size;
            bool isItalic = MainText.SelectionFont.Italic;
            if (isItalic)
                MainText.SelectionFont = new Font(font_name, font_size, FontStyle.Regular);
            else
                MainText.SelectionFont = new Font(font_name, font_size, FontStyle.Italic);
        }
        /// <summary>
        /// method to set/unset the selected text to underlined text
        /// </summary>
        private void SetUnderline()
        {
            string font_name = MainText.SelectionFont.Name;
            float font_size = MainText.SelectionFont.Size;
            bool isUnderline = MainText.SelectionFont.Underline;
            if (isUnderline)
                MainText.SelectionFont = new Font(font_name, font_size, FontStyle.Regular);
            else
                MainText.SelectionFont = new Font(font_name, font_size, FontStyle.Underline);
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            SetBold();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            SetItalic();
        }

        private void btnUnderlined_Click(object sender, EventArgs e)
        {
            SetUnderline();
        }

        private void ChangeFont()
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = MainText.Font;
            fontDialog1.Color = MainText.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                MainText.SelectionFont = fontDialog1.Font;
                MainText.ForeColor = fontDialog1.Color;
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void OpenFile()
        {
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK 
                && openFileDialog1.FileName.Length > 0)
            {
                MainText.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btnLeftAlign_Click(object sender, EventArgs e)
        {
            MainText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnCenterAlign_Click(object sender, EventArgs e)
        {
            MainText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnRightAlign_Click(object sender, EventArgs e)
        {
            MainText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void SaveFile()
        {
            if (!string.IsNullOrEmpty(MainText.Text))
            {
                DialogResult dr = MessageBox.Show("Do you wanto to save this file?", "Save file",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    saveFileDialog1.DefaultExt = "*.rtf";
                    saveFileDialog1.Filter = "RTF Files|*.rtf";
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                        && saveFileDialog1.FileName.Length > 0)
                    {
                        MainText.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void NewFile()
        {
            SaveFile();
            MainText.Clear();
            MainText.Focus();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void mnuNewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void mnuLoadFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void mnuSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void CloseSystem()
        {
            SaveFile();
            DialogResult dr = MessageBox.Show("", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseSystem();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            CloseSystem();
        }

        private void mnuBold_Click(object sender, EventArgs e)
        {
            SetBold();
        }

        private void mnuItalic_Click(object sender, EventArgs e)
        {
            SetItalic();
        }

        private void mnuUnderline_Click(object sender, EventArgs e)
        {
            SetUnderline();
        }

        private void mnuChangeFont_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void mnuLeftAlign_Click(object sender, EventArgs e)
        {
            MainText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mnuCenterAlign_Click(object sender, EventArgs e)
        {
            MainText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void mnuRightAlign_Click(object sender, EventArgs e)
        {
            MainText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            if(about.DialogResult == DialogResult.OK)
            {
                about.Dispose();
            }
        }

        private void AddImage()
        {
            openFileDialog1.Filter = "Images (*.jpg)|*.jpg |Images (*.png)|*.png";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Path = openFileDialog1.FileName;
                Clipboard.SetImage(Image.FromFile(Path));
                MainText.Paste();
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            AddImage();
        }

        private void mnuAddImage_Click(object sender, EventArgs e)
        {
            AddImage();
        }
        
    }
}
