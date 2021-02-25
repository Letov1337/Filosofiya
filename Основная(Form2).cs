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

namespace Filosofiya
{
    
    public partial class основное1 : Form
    {
        string line;
        string[] mas;
       
        public основное1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void Рандом(string[] mas, string line)
        {
            // считываем Sample.txt
            StreamReader sr = new StreamReader(@"..\..\Sample.txt");
            line = sr.ReadToEnd();
            // невьебенный рандом
            mas = line.Split('\n');
            Random rand = new Random();
            int num = rand.Next(0, mas.Length);
            string цитата = mas[num];
            Console.WriteLine(цитата);
            label1.Text = цитата;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Рандом(mas, line);
            //StreamReader sr = new StreamReader(@"..\..\Sample.txt");
            //line = sr.ReadLine();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string url = "https://baneks.site/%D0%B2%D0%B5%D0%BB%D0%B8%D0%BA%D0%B8%D0%B9-%D1%84%D0%B8%D0%BB%D0%BE%D1%81%D0%BE%D1%84-%D1%84%D1%80%D0%B8%D0%B4%D1%80%D0%B8%D1%85-%D0%BD%D0%B8%D1%86%D1%88%D0%B5-%D0%B1%D1%8B%D0%BB-%D0%B4%D0%BE%D0%B1%D1%80%D1%8B%D0%B9-%D0%B8-%D0%B2%D0%B5%D1%81%D0%B5%D0%BB%D1%8B%D0%B9/?p=2";
            Process.Start(url);
        }
    }
}
