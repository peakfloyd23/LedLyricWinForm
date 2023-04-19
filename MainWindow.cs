using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.XWPF.UserModel;
using SixLabors.ImageSharp.Processing.Processors.Transforms;

namespace LedLyricWinForm
{
    public partial class MainWindow : Form
    {

        private LineLyricText lyricText;

        private LyricSettingConfig lyricSettingConfig;

        private string CurrentLyricFile;

        private string CurrentLyricFileExtension;

        private int SelectedIndex = -1;

        private Dictionary<string, string> lyricFileMap = new Dictionary<string, string>();



        public MainWindow()
        {
            InitializeComponent();
            this.initLyricFileList();
            this.initLyricSetting();

        }

        /**加载字幕menu点击动作，加载文件，读取文件，为textbox赋值*/
        private void 加载字幕文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件 (*.txt)|*.txt|word文档 (*.doc,*.docx)|*.doc;*.docx";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentLyricFile = openFileDialog.FileName;
                CurrentLyricFileExtension = System.IO.Path.GetExtension(CurrentLyricFile);
                var fileName = System.IO.Path.GetFileName(CurrentLyricFile);

                switch (CurrentLyricFileExtension)
                {
                    case ".doc":
                        fileContent = this.readWord(CurrentLyricFile);
                        break;
                    case ".docx":
                        fileContent = this.readWord(CurrentLyricFile);
                        break;
                    case ".txt":
                        fileContent = this.readText(openFileDialog);
                        break;


                }
                //var fileStream = openFileDialog.OpenFile();
                //StreamReader sr = new StreamReader(fileStream);
                //fileContent = sr.ReadToEnd();

                this.textBox1.Text = fileContent;
                this.lyricFileMap.Add(fileName, CurrentLyricFile);
                this.lyricList.Items.Add(fileName);
                if (this.lyricText != null&&this.textBox1.Lines.Length > 0)
                {
                    this.lyricText.setLineTextBoxValue(this.textBox1.Lines[0]);
                }
                this.saveLyricFileList();
            }
        }

        /**读取word文档，返回字符串*/
        private string readWord(string word)
        {
            var sb = new StringBuilder();
            var fs = new FileStream(this.CurrentLyricFile, FileMode.Open, FileAccess.Read);
            XWPFDocument document = new XWPFDocument(fs);
            foreach (var para in document.Paragraphs)
            {
                sb.AppendLine(para.ParagraphText);
            }
            document.Close();
            fs.Close();
            fs.Dispose();
            return sb.ToString();
        }


        /**读取txt字幕，返回字符串*/
        private string readText(OpenFileDialog openFileDialog)
        {
            var fileStream = openFileDialog.OpenFile();
            StreamReader sr = new StreamReader(fileStream);
            var text = sr.ReadToEnd();
            sr.Close();
            fileStream.Close();
            return text;

        }

        /**读取txt字幕，返回字符串*/
        private string readText(string file)
        {
            var fileStream = new FileStream(file, FileMode.Open);
            StreamReader sr = new StreamReader(fileStream);
            var text = sr.ReadToEnd();
            sr.Close();
            fileStream.Close();
            return text;

        }
        /**打开字幕显示设置界面*/
        private void 字幕显示设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LyricFontSetting setting = new LyricFontSetting();
            setting.FormClosing += Setting_FormClosing;
            setting.Show();

        }

        private void Setting_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.initLyricSetting();
        }

        /** 打开字幕显示窗口*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.initLyricSetting();

            if (this.lyricText != null)
            {
                if (this.lyricText.IsDisposed)
                {
                    this.lyricText = new LineLyricText();
                }
            }
            else
            {
                this.lyricText = new LineLyricText();
            }

            if (this.lyricSettingConfig != null)
            {
                var point = new Point(this.lyricSettingConfig.XPosition, this.lyricSettingConfig.YPosition);
                var size = new Size(this.lyricSettingConfig.Width, this.lyricSettingConfig.Height);
                this.lyricText.Location = point;
                this.lyricText.Size = size;
                JsonElement je = (JsonElement)this.lyricSettingConfig.font;
                Font font = LyricSettingConfig.GetRealFont(je);
                JsonElement c = (JsonElement)(this.lyricSettingConfig.color);
                Color color = LyricSettingConfig.GetColor(c);
                this.lyricText.setTextBoxFont(font);
                this.lyricText.setTextColor(color);
                this.lyricText.setTextBoxPosition(point);
                this.lyricText.setTextBoxSize(size);
            }
            if (this.textBox1.Lines.Length > 0)
            {
                this.lyricText.setLineTextBoxValue(this.textBox1.Lines[0]);
            }
            this.lyricText.Show();
        }


        private void textBox1_CursorChanged(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            var line = textBox1.SelectionStart;
            Console.WriteLine(line);
        }


        /**监听上下方向键的动作事件*/

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.textBox1.Focus();
            int index = textBox1.SelectionStart;
            int line = textBox1.GetLineFromCharIndex(index);
            if (line < textBox1.Lines.Length)
            {
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

        }


        /**关闭字幕条按钮动作*/
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.lyricText != null)
            {
                this.lyricText.Close();
            }
        }

        private void initLyricFileList()
        {
            List<LyricFile> list = LyricFile.loadLyricFiles("lyrics.json");
            if (null != list)
            {
                foreach (LyricFile lyricFile in list)
                {
                    lyricFileMap.Add(lyricFile.FileName, lyricFile.FilePath);
                    this.lyricList.Items.Add(lyricFile.FileName);
                }
            }
        }

        private void saveLyricFileList()
        {
            List<LyricFile> files = new List<LyricFile>();
            foreach (KeyValuePair<string, string> kvp in this.lyricFileMap)
            {
                var lyricFile = new LyricFile();
                lyricFile.FileName = kvp.Key;
                lyricFile.FilePath = kvp.Value;
                files.Add(lyricFile);
            }
            LyricFile.saveLyricFileList(files);
        }

        private void initLyricSetting()
        {
            this.lyricSettingConfig = LyricSettingConfig.loadConfig("config.json");
        }

        private void saveLyric()
        {
            switch (CurrentLyricFileExtension)
            {
                case ".doc":
                    this.writeWordLyric();
                    break;
                case ".docx":
                    this.writeWordLyric();
                    break;
                case ".txt":
                    this.writeTxtLyric();
                    break;
                default: break;


            }
        }

        private void writeTxtLyric()
        {
            FileStream fileStream = new FileStream(this.CurrentLyricFile, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteAsync(this.textBox1.Text);
            writer.Flush();
            fileStream.Close();
        }

        private void writeWordLyric()
        {
            FileStream fileStream = new FileStream(this.CurrentLyricFile, FileMode.OpenOrCreate, FileAccess.Write);
            XWPFDocument document = new XWPFDocument();
            foreach (var line in this.textBox1.Lines)
            {
                XWPFParagraph para = document.CreateParagraph();
                XWPFRun run = para.CreateRun();
                run.SetText(line);
            }
            document.Write(fileStream);
            document.Close();
            fileStream.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.CurrentLyricFile != null)
            {
                this.saveLyric();
            }
        }




        private void lyricList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lyricList.IndexFromPoint(e.Location);
            lyricList.SelectedIndex = index;
            if (lyricList.SelectedIndex >= 0)
            {
                var filename = lyricList.SelectedItem.ToString();
                var filepath = this.lyricFileMap[filename];
                if (filepath != null)
                {
                    CurrentLyricFile = filepath;
                    CurrentLyricFileExtension = System.IO.Path.GetExtension(CurrentLyricFile);
                    var fileContent = string.Empty;

                    switch (CurrentLyricFileExtension)
                    {
                        case ".doc":
                            fileContent = this.readWord(CurrentLyricFile);
                            break;
                        case ".docx":
                            fileContent = this.readWord(CurrentLyricFile);
                            break;
                        case ".txt":
                            fileContent = this.readText(CurrentLyricFile);
                            break;
                    }
                    this.textBox1.Text = fileContent;
                    if (this.lyricText != null && this.textBox1.Lines.Length > 0)
                    {
                        this.lyricText.setLineTextBoxValue(this.textBox1.Lines[0]);
                    }
                }
            }
        }

        private void lyricList_MouseUp(object sender, MouseEventArgs e)
        {
            SelectedIndex = lyricList.IndexFromPoint(e.Location);
            if (SelectedIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    lyricList.SelectedIndex = SelectedIndex;
                    contextMenuStrip1.Show(this.lyricList,e.Location);
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.SelectedIndex >= 0)
            {
                var filename = lyricList.SelectedItem.ToString();
                this.lyricFileMap.Remove(filename);
                this.lyricList.Items.Remove(lyricList.SelectedItem);
                this.saveLyricFileList();
            }
        }
    }
}
