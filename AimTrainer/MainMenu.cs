using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Cameron Jack

//Main menu screen

namespace AimTrainer
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Event handler for Start Game button
        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            Form1 gameWindow = new Form1(name);
            gameWindow.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
