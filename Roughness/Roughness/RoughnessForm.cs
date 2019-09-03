using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Roughness
{
    public partial class RoughnessForm : Form
    {
        public RoughnessForm()
        {
            InitializeComponent();
        }
        Thread BgCal;
        bool IsProcessing = false;

        //用户选择文件路径
        private void GetFilePath(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog
                {
                    InitialDirectory = Environment.SpecialFolder.Desktop.ToString(),
                    CheckFileExists = true,
                    Filter = "asc Files (*.asc)|*.asc",
                    FilterIndex = 1,
                };
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    FilePathTextBox.Text = OFD.FileName;
                    GetFileHead();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //转换操作控制
        private void GetR(object sender, EventArgs e)
        {
            try
            {
                if (sender == ConvertButton)
                {
                    BgCal = new Thread(Calc)
                    {
                        Priority = ThreadPriority.Normal
                    };
                    BgCal.Start();  //在新线程上执行转换任务，不会卡界面
                    StartProcessing();
                }
                if (sender == CancelButton)
                {
                    if (BgCal.IsAlive)
                    {
                        BgCal.Abort();
                        StopProcessing();
                        ProgressLabel.Text = "你烟了";
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                StopProcessing();
            }
        }

        //多线程调用方法
        private void Calc()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(RoughnessTextBox.Text) || String.IsNullOrWhiteSpace(NoDataValueTextBox.Text))
                {
                    throw new FormatException("输入的糙率或NoData值不正确！");
                }
                string CurrentLine = null;
                double CLine = 0;
                double TLine = 0;

                using (StreamReader sr = new StreamReader(FilePathTextBox.Text))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        CurrentLine = sr.ReadLine();
                        if (i == 1)
                        {
                            TLine = Convert.ToInt32(CurrentLine.Substring(14).Replace("\r\n", String.Empty)); //自动读取行数
                        }
                    }
                    using (StreamWriter sw = new StreamWriter(FilePathTextBox.Text.Replace(".asc", "_out.asc")))
                    {
                        sw.Write(FileContentRichTextBox.Text);
                    }

                    while ((CurrentLine = sr.ReadLine()) != null)   //读取直到文档末尾
                    {
                        string[] DEMValues = CurrentLine.Split(' ');
                        string Converted;
                        for (int j = 0; j < DEMValues.Length - 1; j++)
                        {
                            if (DEMValues[j] != NoDataValueTextBox.Text)
                            {
                                DEMValues[j] = RoughnessTextBox.Text;
                            }
                        }
                        Converted = String.Join(" ", DEMValues);
                        Converted += " ";
                        using (StreamWriter sw = new StreamWriter(FilePathTextBox.Text.Replace(".asc", "_out.asc"), true))
                        {
                            sw.WriteLine(Converted);
                            CLine++;
                            ConvertProgressBar.Value = (CLine / TLine) * 100 <= 100 ? Convert.ToInt32((CLine / TLine) * 100) : 50;
                            ProgressLabel.Text = "Processing: " + CLine.ToString() + " / " + TLine.ToString();
                            this.Refresh();
                            if (CLine >= TLine)
                            {
                                StopProcessing();
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                StopProcessing();
            }
        }

        private void GetFileHead()
        {
            FileContentRichTextBox.Clear();
            using (StreamReader sr = new StreamReader(FilePathTextBox.Text))
            {
                for (int i = 0; i < 6; i++)
                {
                    string CurrentLine = sr.ReadLine();
                    if (i == 5)
                    {
                        double TLine = Convert.ToDouble(CurrentLine.Substring(14).Replace("\r\n", String.Empty)); //自动读取NoDATA值
                        NoDataValueTextBox.Text = TLine.ToString();
                    }
                    FileContentRichTextBox.Text += CurrentLine + "\r\n";
                    this.Refresh();
                }
            }
        }

        private void ShowAuthor(object sender, EventArgs e)
        {
            MessageBox.Show("DEM转糙率程序，由Rikakoist制作。更多工具请访问https://github.com/Rikakoist。", "2333~", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void PreDragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DragToLocateFile(object sender, DragEventArgs e)
        {
            try
            {
                if (!IsProcessing)
                {
                    string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                    if (files.GetLength(0) > 1)
                    {
                        throw new Exception("每次仅可加载一个数据文件！");
                    }
                    var Extension = System.IO.Path.GetExtension(files[0]);
                    if (Extension.Equals(".asc", StringComparison.CurrentCultureIgnoreCase))
                    {
                        FilePathTextBox.Text = System.IO.Path.GetFullPath(files[0]);   //定位到当前文件夹 
                        GetFileHead();
                    }
                    else
                    {
                        throw new Exception("请选择.asc文件！");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                StopProcessing();
            }
        }

        private void StartProcessing()
        {
            ConvertButton.Enabled = false;
            CancelButton.Enabled = true;
            IsProcessing = true;
            FilePathButton.Enabled = false;
            FilePathTextBox.Enabled = false;
            NoDataValueTextBox.Enabled = false;
            RoughnessTextBox.Enabled = false;
        }

        private void StopProcessing()
        {
            ConvertButton.Enabled = true;
            CancelButton.Enabled = false;
            IsProcessing = false;
            FilePathButton.Enabled = true;
            FilePathTextBox.Enabled = true;
            NoDataValueTextBox.Enabled = true;
            RoughnessTextBox.Enabled = true;
        }
    }
}
