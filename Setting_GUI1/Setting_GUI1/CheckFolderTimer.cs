using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setting_GUI1
{
    public partial class CheckFolderTimer : Form
    {
        public Setting_GUI1.Form1.SendMessage send;
        public CheckFolderTimer()
        {
            InitializeComponent();
        }

        public CheckFolderTimer(Setting_GUI1.Form1.SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.send(this.txb_CheckFolderTimer.Text);
            this.Close();
        }

        private void CheckFolderTimer_Load(object sender, EventArgs e)
        {

        }

      
    }
}
