using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace SlitherWinforms
{
    internal static class Program
    {
        public static Size size = Screen.PrimaryScreen.Bounds.Size;
        public static meal meal;


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            
            Application.SetCompatibleTextRenderingDefault(false);
            meal = new meal();
            meal.Show();
            new Thread(() =>
            {
                while (true)
                {
                    SlitherControls.Moving();
                    Thread.Sleep(2);
                }
                //Action action = () => clearToolStripMenuItem.Enabled = false;
                //// Свойство InvokeRequired указывает, нeжно ли обращаться к контролу с помощью Invoke
                //if (InvokeRequired)
                //    Invoke(action);
                //else
                //    action();
            }).Start();
            Application.Run(new Slither());
        }
    }
}
