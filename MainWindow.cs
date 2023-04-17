using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.XWPF.UserModel;

namespace LedLyricWinForm
{
    public partial class MainWindow : Form
    {

        private LineLyricText lyricText;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void 加载字幕文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;
            var fileExtension = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件 (*.txt)|*.txt|word文档 (*.doc,*.docx)|*.doc;*.docx";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                fileExtension = System.IO.Path.GetExtension(filePath);

                switch (fileExtension)
                {
                    case ".doc":
                        fileContent=this.readWord(filePath); 
                        break;
                    case ".docx":
                        fileContent=this.readWord(filePath);
                        break;
                    case ".txt":
                        fileContent = this.readText(openFileDialog);
                        break;


                }


                //var fileStream = openFileDialog.OpenFile();

                //StreamReader sr = new StreamReader(fileStream);
                //fileContent = sr.ReadToEnd();
                this.textBox1.Text = fileContent;
            }

        }

        private string readWord(string word)
        {
            var sb=new StringBuilder();
            var fs = new FileStream(word, FileMode.Open);
            XWPFDocument document = new XWPFDocument(fs);
            foreach(var para in document.Paragraphs)
            {
               sb.AppendLine(para.ParagraphText);
            }
            return sb.ToString();   
        }

        private string readText(OpenFileDialog openFileDialog)
        {
            var fileStream = openFileDialog.OpenFile();
            StreamReader sr = new StreamReader(fileStream);
            return sr.ReadToEnd();

        }

        private void 字幕显示设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.lyricText !=null)
            {
                if(this.lyricText.IsDisposed)
                {
                    this.lyricText = new LineLyricText();
                }
                this.lyricText.Show(); 
            }
            else
            {
                this.lyricText = new LineLyricText();
                this.lyricText.Show();
            }
        }


        private void textBox1_CursorChanged(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            var line = textBox1.SelectionStart;
            Console.WriteLine(line);
        }


        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.textBox1.Focus();
            int index = textBox1.SelectionStart;
            int line = textBox1.GetLineFromCharIndex(index);
            string text = textBox1.Lines[line];
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                System.Diagnostics.Debug.WriteLine(text);
                if (this.lyricText != null)
                {
                    this.lyricText.setLineTextBoxValue(text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.lyricText != null)
            {
                this.lyricText.Close(); 
            }
        }
    }
}
