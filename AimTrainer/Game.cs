using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cameron Jack


namespace AimTrainer
{
    internal class Game
    {
        //Using a list to collect all of the target objects
        private List<Target> targets = new List<Target>();

        //Counter
        public int TargetCount => targets.Count;

        public void AddTarget(Target target)
        {
            targets.Add(target);
        }

        public void RemoveTarget(Target target)
        {
            targets.Remove(target);
        }
    }
}
