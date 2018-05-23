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

namespace Setting_GUI1
{
    public partial class Form1 : Form
    {
        public delegate void SendMessage(String value);//su dung delegate de truyen gia tri tu form2 sang form1

        public Form1()
        {
            InitializeComponent();
            LoadSetting();
        }
        /// <summary>
        /// btn_SendPath
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendPath_Click(object sender, EventArgs e)
        {
            string temp = LoadFolder();//nếu trả về chuổi rỗng thì không thay đổi text 
            if (temp!=null)
            {
                lbl_SendPath.Text = temp;
            }
            
        }
        /// <summary>
        /// btn_ReservePath
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ReservePath_Click(object sender, EventArgs e)
        {
            string temp = LoadFolder();
            if (temp != null)
            {
                lbl_ReservePath.Text = temp;
            }

        }
        /// <summary>
        /// btn_LogPath
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogPath_Click(object sender, EventArgs e)
        {
            string temp = LoadFolder();//nếu trả về chuổi rỗng thì không thay đổi text 
            if (temp != null)
            {
                lbl_LogPath.Text = temp;
            }
            
        }
       
        /// <summary>
        /// btn_CheckFolderTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btn_CheckFolderTimer_Click(object sender, EventArgs e)
        {
            CheckFolderTimer form = new CheckFolderTimer(SetValue);
            form.ShowDialog();

        }
        private void SetValue(String value)
        {
            this.lbl_CheckFolderTimer.Text = value;
        }


        /// <summary>
        /// btn_SendCompletePath
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendCompletePath_Click(object sender, EventArgs e)
        {
            string temp = LoadFolder();//nếu trả về chuổi rỗng thì không thay đổi text 
            if (temp != null)
            {
                lbl_SendCompletePath.Text = temp;
            }
            
        }
        /// <summary>
        /// button Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveSetting();
        }
        /// <summary>
        /// button Cancer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancer_Click(object sender, EventArgs e)
        {
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

        /// <summary>
        /// save Setting to ini file
        /// </summary>
        private void SaveSetting()
        {
            try
            {
                //lấy link file ini
                string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
                filePath = filePath + "\\UserConfiguration.ini";

                //ghi file ini
                StreamWriter strWrite = new StreamWriter(filePath, false);
                strWrite.WriteLine(
                "[UserConfig]" + "\n" +
                "SendPath=" + lbl_SendPath.Text + "\n" +
                "ReservePath=" + lbl_ReservePath.Text + "\n" +
                "LogPath=" + lbl_LogPath.Text + "\n" +
                "CheckFolderTimer=" + lbl_CheckFolderTimer.Text + "\n" +
                "SendCompletePath=" + lbl_SendCompletePath.Text
                );
                strWrite.Flush();
                strWrite.Close();
                MessageBox.Show("Write File Success !!!");
            }
            catch
            {
                MessageBox.Show("Error Can't Write File !!!");
            }
        }

        /// <summary>
        /// Load setting from ini file
        /// </summary>
        private void LoadSetting()
        {
            try
            {
                //lấy link file ini
                string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
                filePath = filePath + "\\UserConfiguration.ini";
                //lấy dữ liệu từ ini lên
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    try
                    {
                        check(line);
                    }
                    catch (Exception)
                    {
                        continue;// sai format thì thực hiện dòng tiếp theo
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Can't Load ini File !!!");
            }
        }

        /// <summary>
        /// tách mỗi dòng ini thành 2 phần rồi kiểm tra
        /// </summary>
        /// <param name="line"></param>
        private void check(string line)
        {
            int idSplit = line.IndexOf('=');
            string beforeSplit = line.Substring(0, idSplit);
            string afterSplit = line.Substring(idSplit + 1);
            if (afterSplit == "\"\"" || afterSplit == null)//nếu gặp giá trị rỗng hoặc "" thì text là null
            {
                afterSplit = null;
            }
            switch (beforeSplit)
            {
                case "SendPath":
                    lbl_SendPath.Text = afterSplit;
                    break;
                case "ReservePath":
                    lbl_ReservePath.Text = afterSplit;
                    break;
                case "LogPath":
                    lbl_LogPath.Text = afterSplit;
                    break;
                case "CheckFolderTimer":
                    lbl_CheckFolderTimer.Text = afterSplit;
                    break;
                case "SendCompletePath":
                    lbl_SendCompletePath.Text = afterSplit;
                    break;
                default:
                    break;
            }
        }
    }
}
