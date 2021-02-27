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

namespace Filosofiya
{
    
    public partial class основное1 : MaterialForm
    {
        private PopupNotifier popup = null;
        string line; // line = mas
        string[] mas; // массив-вывод
        string цитата; // основной вывод 
        public static string автор;
        private NotifyIcon NI = new NotifyIcon(); // уведомления 2 

        public основное1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void Рандом(ref string[] mas, string line)
        {
            // считываем Sample.txt
            StreamReader sr = new StreamReader(@".\Resources\цитаты.txt");
            line = sr.ReadToEnd();
            // невьебенный рандом
            mas = line.Split('\n');
            Random rand = new Random();
            int num = rand.Next(0, mas.Length);
            цитата = mas[num];
            Console.WriteLine(цитата);
            label1.Text = цитата;
            
        }
        public void Автор()
        {
            // ебанный костыль 
            string test = this.цитата;
            string te = test.Substring(test.LastIndexOf("(") + 1);
            автор = te.Substring(0, te.LastIndexOf(")"));
            linkLabel1.Text = автор;
        }
        public void Узнать_об_авторе()
        {
            Браузер_Form3_ f3 = new Браузер_Form3_();
            f3.Show();
        }
        public void Получение_изображение_об_авторе()
        {
            string Ницще = @".\Resources\ницше.jpg";
            string Декарт = @".\Resources\декарт.jpg";
            string Лейбниц = @".\Resources\лейбниц.jpg";

                    if (автор == "Ницше")
                    {
                        pictureBox1.Image = null;
                        pictureBox1.Image = Image.FromFile(Ницще);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    
                    }
                    else if (автор == "Декарт")
                    {
                        pictureBox1.Image = null;
                        pictureBox1.Image = Image.FromFile(Декарт);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                     }
                    else if (автор == "Лейбниц")
                    {
                        pictureBox1.Image = null;
                        pictureBox1.Image = Image.FromFile(Лейбниц);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                     }

        }
        public void Уведомления(string цитата)
        {
            popup = new PopupNotifier();
            popup.Image = Properties.Resources.Image1;
            popup.ImageSize = new Size(96, 96); // размер изображения
            popup.TitleText = "test";
            popup.HeaderColor = Color.Blue; // цвет верхушки
            popup.BodyColor = Color.Blue;  // основной цвет
            popup.AnimationInterval = 20; // скорость анимации
            popup.ContentText = цитата;
            popup.ContentFont = new Font("Times New Roman", 18); // цвет заголовка
            popup.TitleFont = new Font("Times New Roman", 18); // цвет основн. текста
            popup.Popup();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Рандом(ref mas,line);
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
            Рандом(ref mas, line);
            NI.BalloonTipText = "Ницше нассал в ботинок";
            NI.BalloonTipTitle = цитата;
            NI.BalloonTipIcon = ToolTipIcon.None;
            NI.Icon = new Icon("povezlo.ico");
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
    }
}


