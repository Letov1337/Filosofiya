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
using System.Diagnostics;
using Tulpep.NotificationWindow;
namespace Filosofiya
{
    
    public partial class основное1 : Form
    {
        private PopupNotifier popup = null;
        string line; // line = mas
        string[] mas; // массив-вывод
        string цитата; // основной вывод 
        public static string автор;
        

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
            StreamReader sr = new StreamReader(@"..\..\Sample.txt");
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
            //Uri url = new Uri("https://yandex.ru/images/search?text=" + автор_link);
            //webControl1.Source = url;
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
            Уведомления(цитата);
            
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
    }
}
