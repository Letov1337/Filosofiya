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
            textBox2.Hide();
            button7.Hide();
            if (data == 4)
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
        string url;
        string url2;
        public void proverka_url (string url2)
        {
            try
            {
                if (!string.IsNullOrEmpty(url2))
                {
                    UriBuilder uriBuilder = new UriBuilder(url2);
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uriBuilder.Uri);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Данный url не подходит");
                    }
                    if (response.StatusCode == HttpStatusCode.OK)
                    { 
                        MessageBox.Show("Успешно!");
                    }
                    else //There are a lot of other status codes you could check for...
                    {
                        MessageBox.Show(string.Format("Данный url не подходит.",
                                                   response.StatusCode.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Broken- Other error: {0}", ex.Message));
            }
        }
        public void ping()
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Воспользуйтесь списком");
            }
            else
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

                                if (listBox1.SelectedIndex == 0)
                                {
                                    if (button_1 == 0)
                                    {
                                        url = "https://raw.githubusercontent.com/Letov1337/Filosofiya/master/Resources/%D0%9C%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D0%B8%D0%B7%D0%BC.txt";
                                    }
                                    else if (button_1 == 1)
                                    {
                                        url = url2;
                                        button_1 = button_1 - 1;
                                    }
                                    string save_path = @".\Resources\";
                                    string name = "Материализм.txt";
                                    wc.DownloadFile(url, save_path + name);
                                    progressBar1.Value = 20;
                                    label4.Text = "Успешно обновлено";
                                    MessageBox.Show("Успешно обновлено:" + name);
                                }
                                if (listBox1.SelectedIndex == 1)
                                {
                                    if (button_1 == 0)
                                    {
                                        url = "https://raw.githubusercontent.com/Letov1337/Filosofiya/master/Resources/%D0%98%D0%B4%D0%B5%D0%B0%D0%BB%D0%B8%D0%B7%D0%BC.txt";
                                    }
                                    else if (button_1 == 1)
                                    {
                                        url = url2;
                                        button_1 = button_1 - 1;
                                    }
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
        private void button5_Click(object sender, EventArgs e)
        {
            ping();
        }
        int button_1 = 0; // Если у нас сработала кнопка
        
        
        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберете из списка!");
            }
            else
            {
                url2 = textBox2.Text;
                proverka_url(url2);
                button_1 = 1;
            }
        }
        int button_2 = 0;// Если у нас сработала кнопка
        private void button6_Click(object sender, EventArgs e)
        {
            
            if (button_2 == 0)
            {
                button_2 = button_2 + 1;
                textBox2.Show();
                button7.Show();
            }
            else
            {
                button_2 = button_2 - 1;
                textBox2.Hide();
                button7.Hide();
            }
        }
    }
}
