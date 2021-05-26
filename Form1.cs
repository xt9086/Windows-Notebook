using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notebook
{
    public partial class Form1 : Form
    {
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "无标题-记事本";
            tbTextArea.SetBounds(this.ClientRectangle.Left, this.ClientRectangle.Top + MainMenu.Height, this.ClientRectangle.Right, this.ClientRectangle.Bottom);
        }    //使初始时文本框与记事本边框对齐

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tbTextArea.SetBounds(this.ClientRectangle.Left, this.ClientRectangle.Top + MainMenu.Height, this.ClientRectangle.Right, this.ClientRectangle.Bottom);
        }     //使文本框随着记事本边框的变化而始终对齐

        private void FileNew_Click(object sender, EventArgs e)
        {
            this.Text = "无标题-记事本";
            tbTextArea.Text = "";
            fileName = "";
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            StreamReader myStream = null;    //读写器对象
            OpenFileDialog dg = new OpenFileDialog();   //创建文件  
            dg.Filter = "文本文档(*.txt)|*.txt";   //格式
            if (dg.ShowDialog() == DialogResult.OK)    //判断，弹出对话框
            {
                fileName = dg.FileName;   //得到文件名
                this.Text = fileName + "-记事本";
                myStream = new StreamReader(fileName);
                tbTextArea.Text = myStream.ReadToEnd();    //读出并显示在文本框
                myStream.Close();   //关闭
            }
        }

        private void FileSaveAs_Click(object sender, EventArgs e)
        {
            StreamWriter myStream;
            SaveFileDialog dg = new SaveFileDialog();//声明对象创建
            dg.Filter = "文本文档(*.txt)|*.txt";
            if (dg.ShowDialog() == DialogResult.OK)//显示保存对话框
            {
                fileName = dg.FileName;
                myStream = new StreamWriter(fileName);//将读写器对象和文件流对象联系起来
                myStream.Write(tbTextArea.Text);
                this.Text = fileName + "-记事本";//读写器对象得到文件
                myStream.Close();
            }
        }

        private void FileSave_Click(object sender, EventArgs e)
        {

            if (fileName == "")                 //调用另存为
            {
                FileSaveAs_Click(sender, e);
            }
            else                                                      //判断是否为新建 
            {
                StreamWriter st1 = new StreamWriter(fileName);
                st1.Write(tbTextArea.Text);
                st1.Close();
            }
        }

        private void FileQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditUndo_Click(object sender, EventArgs e)
        {
            tbTextArea.Undo();
        }

        private void EditCut_Click(object sender, EventArgs e)
        {
            tbTextArea.Cut();
        }

        private void EditCopy_Click(object sender, EventArgs e)
        {
            tbTextArea.Copy();
        }

        private void EditPaste_Click(object sender, EventArgs e)
        {
            tbTextArea.Paste();
        }

        private void ChoiceFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)          //判断返回值类型
            {
                tbTextArea.Font = dlg.Font;
            }
        }

        private void ChoiceBack_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)          //判断返回值类型
            {
                tbTextArea.BackColor = dlg.Color;
            }
        }

        private void ChoiceForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)           //判断返回值类型
            {
                tbTextArea.ForeColor = dlg.Color;
            }
        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"文本编辑器"+Environment.NewLine+"15计算机1班周晓天"+Environment.NewLine+"版本1.1","文本编辑器",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void EditTimeDate_Click(object sender, EventArgs e)
        {
            this.tbTextArea.AppendText(DateTime.Now.ToString());
        }

        private void EditSelectAll_Click(object sender, EventArgs e)
        {
            tbTextArea.SelectAll();
        }

    }
}