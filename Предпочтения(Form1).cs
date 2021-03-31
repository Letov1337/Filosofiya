﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filosofiya
{
    public partial class Предпочтения : MaterialForm
    {
        public Предпочтения()
        {
            InitializeComponent();
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false))
            {
                label1.Show();
                label1.Text = "Выберите предпочтения!";
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    Data.Предпочтения_значение = 1;
                }
                if (checkBox2.Checked == true)
                {
                    Data.Предпочтения_значение = 2;
                }
                if (checkBox1.Checked & checkBox2.Checked == true)
                {
                    Data.Предпочтения_значение = 12;
                }
                основное1 f2 = new основное1();
                this.Hide();
                f2.Show();
               
                
            }
            //все 5 / идеал матер / 3 эпохи
            if (checkBoxIdeal.Checked == true & checkBoxMater.Checked == true & checkBoxAntique.Checked == true & checkBoxMiddleAges.Checked == true & checkBoxNewTime.Checked == true | checkBoxIdeal.Checked == true & checkBoxMater.Checked == true & checkBoxAntique.Checked == false & checkBoxMiddleAges.Checked == false & checkBoxNewTime.Checked == false | checkBoxAntique.Checked == true & checkBoxMiddleAges.Checked == true & checkBoxNewTime.Checked == true & checkBoxIdeal.Checked == false & checkBoxMater.Checked == false)
            {
                Data.Предпочтения_значение = 1;
            }
            //Idealizm
            if (checkBoxIdeal.Checked == true & checkBoxMater.Checked == false & checkBoxAntique.Checked == false & checkBoxMiddleAges.Checked == false & checkBoxNewTime.Checked == false)
            {
                Data.Предпочтения_значение = 2;
            }
            //Materializm
            if (checkBoxMater.Checked == true & checkBoxIdeal.Checked == false & checkBoxAntique.Checked == false & checkBoxMiddleAges.Checked == false & checkBoxNewTime.Checked == false)
            {
                Data.Предпочтения_значение = 3;
            }
            //Antique
            if (checkBoxAntique.Checked == true & checkBoxMater.Checked == false & checkBoxIdeal.Checked == false & checkBoxMiddleAges.Checked == false & checkBoxNewTime.Checked == false)
            {
                Data.Предпочтения_значение = 4;
            }
            //Middle ages
            if (checkBoxMiddleAges.Checked == true & checkBoxMater.Checked == false & checkBoxIdeal.Checked == false & checkBoxAntique.Checked == false & checkBoxNewTime.Checked == false)
            {
                Data.Предпочтения_значение = 5;
            }
            //Новое время
            if (checkBoxNewTime.Checked & checkBoxMater.Checked == false & checkBoxIdeal.Checked == false & checkBoxAntique.Checked == false & checkBoxMiddleAges.Checked == false)
            {
                Data.Предпочтения_значение = 6;
            }
            //Ideal + antique
            if (checkBoxIdeal.Checked & checkBoxAntique.Checked)
            {
                Data.Предпочтения_значение = 7;
            }
            //Ideal + Middle Ages
            if (checkBoxIdeal.Checked & checkBoxMiddleAges.Checked)
            {
                Data.Предпочтения_значение = 8;
            }
            //Ideal + new time
            if (checkBoxIdeal.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 9;
            }
            //Mater + antique
            if (checkBoxMater.Checked & checkBoxAntique.Checked)
            {
                Data.Предпочтения_значение = 10;
            }
            //Mater + Middle Ages
            if (checkBoxMater.Checked & checkBoxMiddleAges.Checked)
            {
                Data.Предпочтения_значение = 11;
            }
            //Mater + new time
            if (checkBoxMater.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 12;
            }
            //Antique + Middle ages
            if (checkBoxAntique.Checked & checkBoxMiddleAges.Checked)
            {
                Data.Предпочтения_значение = 13;
            }
            //antique + new time
            if (checkBoxAntique.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 14;
            }
            //Middle ages + new time
            if (checkBoxMiddleAges.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 15;
            }
            //Ideal mater antique
            if (checkBoxIdeal.Checked & checkBoxMater.Checked & checkBoxAntique.Checked)
            {
                Data.Предпочтения_значение = 16;
            }
            //Ideal mater middle age
            if (checkBoxIdeal.Checked & checkBoxMater.Checked & checkBoxMiddleAges.Checked)
            {
                Data.Предпочтения_значение = 17;
            }
            //Ideal mater new time
            if (checkBoxIdeal.Checked & checkBoxMater.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 18;
            }
            //ideal antique middle age
            if (checkBoxIdeal.Checked & checkBoxAntique.Checked & checkBoxMiddleAges.Checked)
            {
                Data.Предпочтения_значение = 19;
            }
            //ideal middle age new time
            if (checkBoxIdeal.Checked & checkBoxMiddleAges.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 20;
            }
            //ideal antique new time
            if (checkBoxIdeal.Checked & checkBoxAntique.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 21;
            }
            //mater antique middle age
            if (checkBoxMater.Checked & checkBoxAntique.Checked & checkBoxMiddleAges.Checked)
            {
                Data.Предпочтения_значение = 22;
            }
            //mater middle age new time
            if (checkBoxMater.Checked & checkBoxMiddleAges.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 23;
            }
            //mater antique new time
            if (checkBoxMater.Checked & checkBoxAntique.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 24;
            }
            //ideal mater antique middle age
            if (checkBoxIdeal.Checked & checkBoxMater.Checked & checkBoxAntique.Checked & checkBoxMiddleAges.Checked)
            {
                Data.Предпочтения_значение = 25;
            }
            //ideal mater antique new time 
            if (checkBoxIdeal.Checked & checkBoxMater.Checked & checkBoxAntique.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 26;
            }
            //ideal mater middle ages new time 
            if (checkBoxIdeal.Checked & checkBoxMater.Checked & checkBoxMiddleAges.Checked & checkBoxNewTime.Checked)
            {
                Data.Предпочтения_значение = 27;
            }
            //3 эпохи + матер
            if (checkBoxAntique.Checked & checkBoxMiddleAges.Checked & checkBoxNewTime.Checked & checkBoxMater.Checked)
            {
                Data.Предпочтения_значение = 28;
            }
            //3 эпохи + Idealizm
            if (checkBoxAntique.Checked & checkBoxMiddleAges.Checked & checkBoxNewTime.Checked & checkBoxIdeal.Checked & checkBoxIdeal.Checked == false & checkBoxMater.Checked == false)
            {
                Data.Предпочтения_значение = 29;
            }
            MessageBox.Show(Data.Предпочтения_значение.ToString());
        }

        private void Предпочтения_Load(object sender, EventArgs e)
        {

        }

        private void Предпочтения_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
