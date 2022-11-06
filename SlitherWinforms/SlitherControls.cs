using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlitherWinforms
{
    public static class SlitherControls
    {
        public static int WidthSlither = 30;
        public static int HeightSlither = 30;
        public static int StartPositionX = 0;
        public static int StartPositionY = 0;
        
        public static int speed = 1;

        public static string Move = "Right"; 
        public static int countMove = 8;
        public static int stopMove = 0;
        public static int moveX = 0;
        public static int moveY = 0;
        public static void Moving()
        {
            switch (Move)
            {
                case "Right":
                    moveX = moveX < Program.size.Width ? moveX + countMove : 0;
                    break;
                case "Left":
                    moveX = moveX < Program.size.Width && moveX > 0 ? moveX - countMove : Program.size.Width - WidthSlither;
                    break;
                case "Up":
                    moveY = moveY < Program.size.Height && moveY > 0 ? moveY - countMove : Program.size.Height - HeightSlither;
                    break;
                case "Down":
                    moveY = moveY < Program.size.Height ? moveY + countMove : 0;
                    break;
            }    
        }
       
    }
}
