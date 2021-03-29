using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using Tulpep.NotificationWindow;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading;
using System.Timers;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Net.Http;
namespace Filosofiya
{
    
    public partial class основное1 : MaterialForm
    {
        
        private PopupNotifier popup = null;
        string line; // line = mas
        string[] mas; // массив-вывод
        string цитата; // основной вывод 
        public static string автор;
        int p;
        private NotifyIcon NI = new NotifyIcon(); // уведомления 2 
        public основное1()
        {
            InitializeComponent();
            label2.Text = "";
            label2.Hide();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void Шрифт()
        {
            //label1.Font.Size = 200;
        }
        public void Рандом(string[] mas, string line)
        {
            //Data.Выдача_цитат = 1;
            // считываем Sample.txt

            if (Data.Предпочтения_значение == 1)
            {
                StreamReader sr = new StreamReader(@".\Resources\Материализм.txt");
                line = sr.ReadToEnd();
                // невьебенный рандом
                mas = line.Split('\n');
                sr.Close();
                if (Data.Выдача_цитат == 0)
                {
                    Random rand = new Random();
                    int num = rand.Next(0, mas.Length);
                    цитата = mas[num];
                    Console.WriteLine(цитата);
                    label1.Text = цитата;
                }
                if (Data.Выдача_цитат == 1)
                {
                    Random rand = new Random();
                    int num = rand.Next(0, mas.Length);
                    цитата = mas[num];
                    Console.WriteLine(цитата);
                    label1.Text = цитата;
                }
                if (Data.Выдача_цитат == 2)
                {
                    //
                    //
                    //Последовательный вывод (костыль)
                    if(p >= mas.Length)
                    {
                        return;
                    }
                    else 
                    {
                        цитата = mas[p];
                        Console.WriteLine(цитата);
                        label1.Text = цитата;
                    }
                    
                }
            }
            if (Data.Предпочтения_значение == 2)
            {
                StreamReader sr = new StreamReader(@".\Resources\Идеализм.txt");
                line = sr.ReadToEnd();
                // невьебенный рандом
                mas = line.Split('\n');
                sr.Close();
                Random rand = new Random();
                int num = rand.Next(0, mas.Length);
                цитата = mas[num];
                Console.WriteLine(цитата);
                label1.Text = цитата;
                ;
            }
            if (Data.Предпочтения_значение == 12 )
            {
                StreamReader sr = new StreamReader(@".\Resources\Идеализм.txt");
                StreamReader sr1 = new StreamReader(@".\Resources\Материализм.txt");
                line = sr.ReadToEnd() + "\n"+ sr1.ReadToEnd();
                sr1.Close();
                sr.Close();
                // невьебенный рандом
                mas = line.Split('\n');
                Random rand = new Random();
                int num = rand.Next(0, mas.Length);
                цитата = mas[num];
                Console.WriteLine(цитата);
                label1.Text = цитата;
                
            }
        }
        public void Автор()
        {
            try
            {
                string test = this.цитата;
                string te = test.Substring(test.LastIndexOf("(") + 1);
                автор = te.Substring(0, te.LastIndexOf(")"));
                linkLabel1.Text = автор;
            }
            catch
            {
                var request = (HttpWebRequest)WebRequest.Create("http://g.cn/generate_204");
                request.UserAgent = "Android";
                request.KeepAlive = false;
                request.Timeout = 1500;
                using (var response = (HttpWebResponse)request.GetResponse())
                {

                    if (response.ContentLength == 0 && response.StatusCode == HttpStatusCode.NoContent)
                    {
                        MessageBox.Show("Почему-то не удается загрузить цитаты...\n" + "Пытаюсь исправить");
                        WebClient wc = new WebClient();
                        string url = "https://raw.githubusercontent.com/Letov1337/Filosofiya/master/Resources/%D0%98%D0%B4%D0%B5%D0%B0%D0%BB%D0%B8%D0%B7%D0%BC.txt";
                        string save_path = @".\Resources\";
                        string name = "Идеализм.txt";
                        wc.DownloadFile(url, save_path + name);
                        WebClient wc2 = new WebClient();
                        url = "https://raw.githubusercontent.com/Letov1337/Filosofiya/master/Resources/%D0%9C%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D0%B8%D0%B7%D0%BC.txt";
                        string save_path2 = @".\Resources\";
                        string name2 = "Материализм.txt";
                        wc2.DownloadFile(url, save_path2 + name2);
                        MessageBox.Show("Файлы восстановлены:" + name + name2);
                    }
                }
                
            }
        }
        public void Узнать_об_авторе()
        {
            Браузер_Form3_ f3 = new Браузер_Form3_();
            f3.Show();
        }
        string Ницще = @".\Resources\ницше.jpg";
        string Декарт = @".\Resources\декарт.jpg";
        string Лейбниц = @".\Resources\лейбниц.jpg";
        string Test = @".\Resources\1.jpg";
        public void Получение_изображение_об_авторе()
        {
            
                    if (автор == "Ницше")
                    {
                        pictureBox1.Image = null;
                        pictureBox1.Image = Image.FromFile(Ницще);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    
                    }
                    if (автор == "Декарт")
                    {
                        pictureBox1.Image = null;
                        pictureBox1.Image = Image.FromFile(Декарт);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                     }
                    if (автор == "Лейбниц")
                    {
                        pictureBox1.Image = null;
                        pictureBox1.Image = Image.FromFile(Лейбниц);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                     }
                    if (автор == "тест")
                     {
                       pictureBox1.Image = null;
                       pictureBox1.Image = Image.FromFile(Test);
                       pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                      }

        }

        public void Уведомления(string цитата)
        {
            popup = new PopupNotifier();
            //popup.Image = Properties.Resources.Image1;
            popup.ImageSize = new Size(96, 96); // размер изображения
            popup.TitleText = цитата;
            popup.HeaderColor = Color.White; // цвет верхушки
            popup.BodyColor = Color.White;  // основной цвет
            popup.AnimationInterval = 20; // скорость анимации
            popup.ContentText = цитата;
            popup.ContentFont = new Font("Times New Roman", 18); // цвет заголовка
            popup.TitleFont = new Font("Times New Roman", 18); // цвет основн. текста
            popup.TitleColor = Color.Black; //цвет текста
            popup.Popup();
        }
        public void Все_в_месте()
        {
            Рандом(mas, line);
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Уведомления(цитата);
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                Notifier();
            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {

            }
            Получение_изображение_об_авторе();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Все_в_месте();
            p++;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            Автор();
        }
        

        private void основное1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Узнать_об_авторе();

        }
        public void Notifier()
        {
            Рандом(mas, line);
            NI.BalloonTipText = "Цитата:";
            NI.BalloonTipTitle = цитата;
            NI.BalloonTipIcon = ToolTipIcon.None;
            NI.Icon = new Icon(@".\Resources\povezlo.ico");
            NI.Visible = true;
            NI.ShowBalloonTip(1000);
        }
        private void NI_BallonTipClosed(Object sender, EventArgs e)
        {
            NI.Visible = false;
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var materialskin = MaterialSkinManager.Instance;
            materialskin.AddFormToManage(this);
            if (toolStripComboBox2.SelectedIndex == 0)
            {
                materialskin.Theme = MaterialSkinManager.Themes.DARK;
                this.Controls["label1"].BackColor = Color.FromName("Gray");
                this.Controls["linkLabel1"].BackColor = Color.FromName("Gray");

            }
            else if (toolStripComboBox2.SelectedIndex == 1)
            {
                
                materialskin.Theme = MaterialSkinManager.Themes.LIGHT;
                this.Controls["label1"].BackColor = Color.FromName("White");
                this.Controls["linkLabel1"].BackColor = Color.FromName("White");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripComboBox3_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox3.SelectedIndex == 0)
            {
                label2.Show();
            }
            else if (toolStripComboBox3.SelectedIndex == 1)
            {
                label2.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Рандом(mas, line);
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Уведомления(цитата);
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                Notifier();
            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {

            }
            Получение_изображение_об_авторе();
        }

        private void toolStripComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox4.SelectedIndex == 0 )
            {
                label2.Show();
                timer2.Interval = Convert.ToInt32(Data.Value);
                timer2.Start();
                button1.Hide();
            }
           else if (toolStripComboBox4.SelectedIndex == 1)
            {
                label2.Hide();
                timer2.Stop();
                button1.Show();
            }    
        }
        // открываем текущее настройки
        int a = 4;
        int b = 2;
        int c = 0;
        int d = 1;
        public void записатьЦитатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Настройки form4 = new Настройки(this.a);
            form4.ShowDialog();
        }

        private void таймерToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Настройки form4 = new Настройки(this.b);
            form4.Show();
        }

        private void ТаймерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void настройкиШрифтаЧасовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label2.Font = fontDialog1.Font;
        }

        private void настройкиШрифтаЦитатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }

        private void выводЦитатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Вкладка = 1;
            Настройки form4 = new Настройки(this.c);
            form4.Show();
           
            
        }

        private void обновлениеЦитатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Вкладка = 2;
            Настройки form4 = new Настройки(this.d);
            form4.Show();
        }
    }
}


