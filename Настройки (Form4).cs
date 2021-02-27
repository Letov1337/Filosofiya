using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
namespace Filosofiya
{
    public partial class Настройки : MaterialForm
    {
      
        public void Считываем()
        {
            using (StreamReader myReader = new StreamReader(@".\Resources\цитаты.txt" , Encoding.UTF8))
            {
                richTextBox1.Text = myReader.ReadToEnd() /*+ "\r\n"*/;
            }
        }
        public void Запись()
        {
            using (StreamWriter myWriter = new StreamWriter(@".\Resources\цитаты.txt"))
            {
                string line = richTextBox1.Text;
                myWriter.Write(line);
            }
        }
        public Настройки()
        {
            InitializeComponent();
            Считываем();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            основное1 main = this.Owner as основное1;
            if(main.a == 0)
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Запись();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Считываем();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
