using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setting_GUI
{


    public partial class Form1 : Form
    {
        Boolean flag = false;//đánh giấu có thay đổi không
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //load giá trị setting trước
            lbl_Path1.Text = "c:\\";
            lbl_Path2.Text = "c:\\";
            txt_Timer.Text = "1000";
        }
        /// <summary>
        /// button path 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Path1_Click(object sender, EventArgs e)
        {
            if (LoadFolder()!=null)
            {
                lbl_Path1.Text = LoadFolder();
                flag = true;
            }
        }

        /// <summary>
        /// button path 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Path2_Click(object sender, EventArgs e)
        {
            if (LoadFolder() != null)
            {
                lbl_Path2.Text = LoadFolder();
                flag = true;
            }
        }

        /// <summary>
        /// save setting to ini file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveSetting_Click(object sender, EventArgs e)
        {
            string rb = null;
            if (rb_Overwrite.Checked)
            {
                rb = "Overwrite";
            }
            else
            {
                rb = "NewFile";
            }
            //kiểm tra thay đổi thì phải lưu trước khi save ini
            if (!flag)
            {
                try
                {
                    StreamWriter strWrite = new StreamWriter("d:\\setting.ini", false);
                    strWrite.WriteLine(lbl_Path1.Text + "\n" + lbl_Path2.Text + "\n" + txt_Timer.Text + "\n" + rb);
                    strWrite.Flush();
                    strWrite.Close();
                    MessageBox.Show("Success !!!");
                }
                catch
                {
                    MessageBox.Show("Error Can't Write File !!!");
                }
            }
            else
                MessageBox.Show("Please Save");
        }

        /// <summary>
        /// load setting from ini file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LoadSetting_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Load setting from ini file", "Load Setting MessageBox", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                string iniPath = null;
                //lay duong dan file ini
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Load INI File";
                openFileDialog.InitialDirectory = @"d:";
                openFileDialog.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    iniPath = Path.GetDirectoryName(openFileDialog.FileName) + Path.GetFileName(openFileDialog.FileName);
                 
                    // đọc file ini lên 
                    var lines = File.ReadAllLines(iniPath);
                    lbl_Path1.Text = lines[0];
                    lbl_Path2.Text = lines[1];
                    txt_Timer.Text = lines[2];
                    if (lines[3] == "Overwrite")
                    {
                        rb_Overwrite.Checked = true;
                    }
                    else
                    {
                        rb_NewFile.Checked = true;
                    }
                }
            }
        }

        /// <summary>
        /// Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //thực hiện hàm lưu lại setting
            DialogResult result = MessageBox.Show("Save Setting ???", "Save Setting MessageBox", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                flag = false;
            }
        }

        /// <summary>
        /// close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //kiểm tra lưu thay đổi chưa nếu chưa lưu thì thông báo
            //lưu rồi thì đóng
            if (flag)
            {
                DialogResult result = MessageBox.Show("Unsaved Setting !!! Close setting ???", "Close Setting MessageBox", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }
            else
                this.Close();
        }


        /// <summary>
        /// load Folder path
        /// </summary>
        /// <returns></returns>
        private string LoadFolder()
        {
            string path = null;
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = folderDlg.SelectedPath;
            }
            return path;
        }

        private void txt_Time_TextChanged(object sender, EventArgs e)
        {
            flag = true;
        }



    }
}
