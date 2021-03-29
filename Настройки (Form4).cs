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
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Threading;
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
            if (Data.Вкладка == 1)
            {
                tabControl1.SelectedIndex = 2;
            }
            if (Data.Вкладка == 2)
            {
                tabControl1.SelectedIndex = 3;
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
            if (comboBox1.SelectedIndex == 3)
            {
                Data.Value = time_set;
                label1.Text = "Настройки применены";
            }
        }
        public void ping ()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://g.cn/generate_204");
            request.UserAgent = "Android";
            request.KeepAlive = false;
            request.Timeout = 1500;
            
            try
            {
                label4.Text = "Проверяем доступ к  интернету...";
                Thread.Sleep(1500);
                progressBar1.Value = 3;
                using (var response = (HttpWebResponse)request.GetResponse())
                   {
                    if (response.ContentLength == 0 && response.StatusCode == HttpStatusCode.NoContent)
                    {
                        
                        progressBar1.Value = 10;
                        int a = 15;
                        if (progressBar1.Value < a)
                        {
                        label4.Text = "Происходит обновление цитаты..";
                        Thread.Sleep(1500);
                        WebClient wc = new WebClient();
                        if(listBox1.SelectedIndex == 0)
                         {
                                string url = "https://raw.githubusercontent.com/Letov1337/Filosofiya/master/Resources/%D0%9C%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D0%B8%D0%B7%D0%BC.txt";
                                string save_path = @".\Resources\";
                                string name = "Материализм.txt";
                                wc.DownloadFile(url, save_path + name);
                                progressBar1.Value = 20;
                                label4.Text = "Успешно обновлено";
                                MessageBox.Show("Успешно обновлено:" + name);
                            }
                        if(listBox1.SelectedIndex == 1)
                         {
                                string url = "https://raw.githubusercontent.com/Letov1337/Filosofiya/master/Resources/%D0%98%D0%B4%D0%B5%D0%B0%D0%BB%D0%B8%D0%B7%D0%BC.txt";
                                string save_path = @".\Resources\";
                                string name = "Идеализм.txt";
                                wc.DownloadFile(url, save_path + name);
                                progressBar1.Value = 20;
                                label4.Text = "Успешно обновлено";
                                MessageBox.Show("Успешно обновлено:" + name);
                            }
                       
                        }
                     }
                    else
                    {
                        MessageBox.Show("not ok");
                        progressBar1.Value = 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show("not ok");
                progressBar1.Value = 0;
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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                Data.Выдача_цитат = 1; // Случайно
            }
            if (comboBox3.SelectedIndex == 1)
            {
                Data.Выдача_цитат = 2; // Рандомно
            }
        }
        int p; // счетчек для прогресс бара
        private void button5_Click(object sender, EventArgs e)
        {

            p++;
            ping();
        }
    }
}
