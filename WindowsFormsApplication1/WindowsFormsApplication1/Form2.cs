using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public SendMessage send;
     

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(this.send), new object[] { (this.textBox1.Text) });
                return;
            }

        }
        public Form2(SendMessage sender) {
            this.send = sender;
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
