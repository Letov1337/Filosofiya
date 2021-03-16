using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filosofiya
{
    static class Data
    {
        public static float Value { get; set; }
        public static int Предпочтения_значение { get; set; }
        public static int Вкладка { get; set; }
        public static int Выдача_цитат { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Предпочтения());
        }
       
    }
}
