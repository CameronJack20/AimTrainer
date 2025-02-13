using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cameron Jack

namespace AimTrainer
{
    internal class Score
    {
        private int score;

        public int GetScore
        {
            get { return score; }
        }

        public Score()
        {
            score = 0;
        }

        public void IncrementScore()
        {
            score++;
        }
    }
}
