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
           
            
            

        }
    }
}
