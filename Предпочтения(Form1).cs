using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filosofiya
{
    public partial class Предпочтения : MaterialForm
    {
        public Предпочтения()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Data.Предпочтения_значение = 1;
            }
            if (checkBox2.Checked == true)
            {
                Data.Предпочтения_значение = 2;
            }
            if (checkBox1.Checked & checkBox2.Checked == true)
            {
                Data.Предпочтения_значение = 12;
            }
            основное1 f2 = new основное1();
            this.Hide();
            f2.Show();
        }

        private void Предпочтения_Load(object sender, EventArgs e)
        {

        }
    }
}
