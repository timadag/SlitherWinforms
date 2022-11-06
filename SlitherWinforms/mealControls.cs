using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlitherWinforms
{
    public class mealControls
    {
        public static int Widthmeal = 30;
        public static int Heightmeal= 30;
        public static Random random = new Random();
        public static int XPosition;
        public static int YPosition;
        public static void Position()
        {
            XPosition = random.Next(0,Program.size.Width-Widthmeal);
            YPosition = random.Next(0,Program.size.Height-Heightmeal);
        }
  
    }
}
