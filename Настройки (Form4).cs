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
            if (comboBox2.SelectedIndex == -1)
            {
                label2.Text = "Воспользуйтесь выпадающим списком! (combobox)";
            }
            if (comboBox2.SelectedIndex == 0) //Материализм
            {
                label2.Hide();
                using (StreamReader myReader = new StreamReader(@".\Resources\Материализм.txt", Encoding.UTF8))
                {
                    richTextBox1.Text = myReader.ReadToEnd() /*+ "\r\n"*/;
                }
            }
            if (comboBox2.SelectedIndex == 1) //Идеализм
            {
                label2.Hide();
                using (StreamReader myReader = new StreamReader(@".\Resources\Идеализм.txt", Encoding.UTF8))
                {
                    richTextBox1.Text = myReader.ReadToEnd() /*+ "\r\n"*/;
                }
            }
            
        }
        public void Запись()
        {
            if (comboBox2.SelectedIndex == 0)
            {
                using (StreamWriter myWriter = new StreamWriter(@".\Resources\Материализм.txt"))
                {
                    string line = richTextBox1.Text;
                    myWriter.Write(line);
                    label2.Text = "Записал!";
                }
            }
            if (comboBox2.SelectedIndex == 1)
            {
                using (StreamWriter myWriter = new StreamWriter(@".\Resources\Идеализм.txt"))
                {
                    string line = richTextBox1.Text;
                    myWriter.Write(line);
                    label2.Text = "Записал!";
                }
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
                label1.Text = "Настройки применены";
            }
            //в минутах
            if (comboBox1.SelectedIndex == 1)
            {
                Data.Value = time_set * 60000;
                label1.Text = "Настройки применены";
            }
            //секунды
            if (comboBox1.SelectedIndex == 2)
            {
                Data.Value = time_set * 1000;
                label1.Text = "Настройки применены";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Считываем();
        }
    }
}
