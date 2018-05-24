using System;
using System.Windows.Forms;

namespace Setting_GUI1
{
    public partial class CheckFolderTimer : Form
    {
        //public Setting_GUI1.Form1.SendMessage send;

        private CheckFolderTimer()
        {
            InitializeComponent();
        }

        //public CheckFolderTimer(Setting_GUI1.Form1.SendMessage sender)
        //{
        //    InitializeComponent();
        //    this.send = sender;
        //}

        public static string GetTimer(string timmer)
        {
            CheckFolderTimer checkFolderTimer = new CheckFolderTimer();
            checkFolderTimer.txb_CheckFolderTimer.Text = timmer;
            checkFolderTimer.ShowDialog();
            return checkFolderTimer.txb_CheckFolderTimer.Text;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //this.send(txb_CheckFolderTimer.Text);
            this.Close();
        }

        private void CheckFolderTimer_Load(object sender, EventArgs e)
        {

        }

      
    }
}
