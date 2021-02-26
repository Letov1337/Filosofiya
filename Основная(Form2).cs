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
        string цитата;


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
        public void Уведомления(string цитата)
        {
            popup = new PopupNotifier();
            popup.Image = Properties.Resources.Image1;
            popup.ImageSize = new Size(96, 96);
            popup.TitleText = "test";
            popup.ContentText = цитата;
            popup.Popup();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Рандом(ref mas,line);
            Уведомления(цитата);
        }

       
    }
}
