using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

//Cameron Jack

namespace AimTrainer
{
    internal class Target : PictureBox
    {
        private static Random rand = new Random();

        public Target()
        {
            InitializePictureBox();
        }

        //Width and color for the target
        private void InitializePictureBox()
        {
            this.Width = 50;
            this.Height = 50;
            this.BackColor = Color.Green;

        
        }

        //Finds random location within the clients form applications width and height
        public void SetRandomLocation(int formWidth, int formHeight)
        {
            int x = rand.Next(10, formWidth - this.Width);
            int y = rand.Next(10, formHeight - this.Height);
            this.Location = new Point(x, y);
        }
    }
}