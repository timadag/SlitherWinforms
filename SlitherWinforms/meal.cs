using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlitherWinforms
{
    public partial class meal : Form
    {
        public meal()
        {
            InitializeComponent();
            Size = new Size(mealControls.Widthmeal,mealControls.Heightmeal);
            mealControls.Position();
            Location = new Point(mealControls.XPosition,mealControls.YPosition);
            TopMost = true;
            BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Location = new Point(mealControls.XPosition, mealControls.YPosition);
        }

        private void meal_Load(object sender, EventArgs e)
        {
          
        }
    }
}
