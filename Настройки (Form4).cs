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
        int data;
        public Настройки(int data)
        {
            InitializeComponent();
            Считываем();
            this.data = data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(data == 4)
            {
                tabControl1.SelectedIndex = 0;
            }
            if (data == 2)
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
        private void button3_Click(object sender, EventArgs e)
        {
            float time_set = Convert.ToInt32(textBox1.Text);
            // проверка на ошибки
            if (comboBox1.SelectedIndex == -1)
            {
                label1.Text = "Что-то пошло не так";
            }
            //в часах
            if (comboBox1.SelectedIndex == 0)
            {
                Data.Value = time_set * 3600000;
            }
            //в минутах
            if (comboBox1.SelectedIndex == 1)
            {
                Data.Value = time_set * 60000;
            }
            //секунды
            if (comboBox1.SelectedIndex == 2)
            {
                Data.Value = time_set * 1000;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
