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
    public partial class Браузер_Form3_ : Form
    {
       
        public Браузер_Form3_()
        {
            InitializeComponent();
            Uri url = new Uri("https://yandex.ru/images/search?text=" + основное1.автор);
            webControl1.Source = url;
        }


        private void Awesomium_Windows_Forms_WebControl_ShowCreatedWebView_1(object sender, Awesomium.Core.ShowCreatedWebViewEventArgs e)
        {
            
        }
    }
}
