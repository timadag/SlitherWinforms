using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlitherWinforms
{
    public partial class Slither : Form
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
       
        public Slither()
        {
            InitializeComponent();
            Size = new Size(SlitherControls.WidthSlither, SlitherControls.HeightSlither);
            
            StartPosition = FormStartPosition.Manual;
            Location = new Point(SlitherControls.StartPositionX, SlitherControls.StartPositionY);
            SpeedSlither.Interval = SlitherControls.speed;
           
        }
        private void SpeedSlither_Tick(object sender, EventArgs e)
        {
            Slither slither = new Slither();
            slither.SpeedSlither.Enabled = false;
            int PositionX = SlitherControls.moveX;
            int PositionY = SlitherControls.moveY;
            Location = new Point(PositionX, PositionY);
           
               
            if((Location.X >= mealControls.XPosition-SlitherControls.countMove && Location.X <= mealControls.XPosition + SlitherControls.countMove)
                && (Location.Y >= mealControls.YPosition - SlitherControls.countMove && Location.Y <= mealControls.YPosition + SlitherControls.countMove))
            {
                mealControls.Position();


                slither.SpeedSlither.Enabled = true;
                slither.StartPosition = FormStartPosition.Manual;
                slither.Show();
                slither.Location = new Point(PositionX-80,PositionY);


            }
        }


        private void Slither_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if(SlitherControls.Move != "Left")
                        SlitherControls.Move = "Right";
                  
                    break;
                case Keys.Left:
                    if (SlitherControls.Move != "Right")
                        SlitherControls.Move = "Left";
                   
                    break;
                case Keys.Up:
                    if (SlitherControls.Move != "Down")
                        SlitherControls.Move = "Up";
                   
                    break;
                case Keys.Down:
                    if (SlitherControls.Move != "Up")
                        SlitherControls.Move = "Down";
                    break;
            }
            
        }
    }
}
