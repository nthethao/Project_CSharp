using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public delegate void SendMessage (String value);
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2(SetValue);
        }
        private void SetValue(String value)
        {
            this.textBox1.Text = value;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Thread ThreadForm2 = new Thread(thread1);

            ThreadForm2.Start();
            
        }

        private void thread1() {
            Form2 f2 = new Form2();
            // Ta truyền hàm SetValue qua form 2, và form 2 khi nhấn nút button bên đó sẽ gọi lại phương thức SetValue bên này
            f2.ShowDialog();
        }
    }
}
