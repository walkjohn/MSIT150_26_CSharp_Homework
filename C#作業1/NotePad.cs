using System;
using System.CodeDom.Compiler;
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

namespace C_作業1
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
            txtNP1.LanguageOption = RichTextBoxLanguageOptions.UIFonts; 
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by De OY","關於此記事本");
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by De OY", "關於此記事本");
        }

        private void 開啟OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNP1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 新增OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            txtNP1.Clear();
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,txtNP1.Text,Encoding.Default);
            }
        }

        private void 儲存SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtNP1.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(openFileDialog1.FileName, txtNP1.Text, Encoding.Default);
            }
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNP1.Cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNP1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNP1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNP1.SelectAll();
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtNP1.ForeColor = colorDialog1.Color;
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtNP1.Font = fontDialog1.Font;
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            txtNP1.Clear();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNP1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtNP1.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(openFileDialog1.FileName, txtNP1.Text, Encoding.Default);
            }
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            txtNP1.Cut();
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            txtNP1.Copy();
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            txtNP1.Paste();
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labForTime.Text = DateTime.Now.ToString();
        }
    }
}
