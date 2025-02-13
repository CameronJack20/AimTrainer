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

namespace AimTrainer
{
    public partial class Form1 : Form
    {
        
        private Game gameManager;
        private Score scoreManager;

        //Timer classes
        private Timer timer = new Timer(); // <---- controls time for target spawns
        private Timer gameTimer = new Timer(); 
        private int gameOverTimer = 0;

        //Username
        private string playerName;
        public Form1(string playerName)
        {
            InitializeComponent();

            gameManager = new Game();
            scoreManager = new Score();
            timer.Interval = 400;
            timer.Tick += TimerEvent;
            timer.Start();
            
            gameTimer.Interval = 1000; 
            gameTimer.Tick += GameTimer;
            gameTimer.Start();

            this.playerName = playerName;
            username.Text = playerName;
        }

        //Adds a target from the class
        private void MakeTarget()
        {
            Target newTarget = new Target();
            newTarget.SetRandomLocation(this.ClientSize.Width, this.ClientSize.Height);
            newTarget.Click += NewPic_Click;
            gameManager.AddTarget(newTarget);
            this.Controls.Add(newTarget);
        }

        //Event handler for when target is touched
        private void NewPic_Click(object sender, EventArgs e)
        {
            Target tempTarget = sender as Target;
            gameManager.RemoveTarget(tempTarget);
            this.Controls.Remove(tempTarget);
            scoreManager.IncrementScore();

            //Removes target from counter
            lblTargetCtr.Text = "Targets: " + gameManager.TargetCount;
            //Adds Score
            lblScore.Text ="Score: " + scoreManager.GetScore;
        }


        private void TimerEvent(object sender, EventArgs e)
        {
            MakeTarget();
            lblTargetCtr.Text = "Targets: " + gameManager.TargetCount;
        }
       
        private void GameTimer(object sender, EventArgs e)
        {
            gameOverTimer++;

            lblTimer.Text = " " + gameOverTimer;

            if (gameOverTimer >= 30)
            {
                timer.Stop();
                gameTimer.Stop(); // Stop the game timer as well
                GameOver();
            }
        }

        
        private void GameOver()
        {
            MessageBox.Show("Game Over! You ran out of time!");
            MessageBox.Show("You had " + gameManager.TargetCount + " targets left");
            MessageBox.Show("You had a score of " + scoreManager.GetScore);
            Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}