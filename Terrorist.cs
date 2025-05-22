using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class Terrorist
    {
        public string Name;
        public int Rank;
        public string LifeStatus;
        public string[] Weapon;

        public Terrorist(string name, int rank, string lifeStatus, string[] weapon)
        {
            Name = name;
            Rank = rank;
            LifeStatus = lifeStatus;
            Weapon = weapon;
        }
    }
}
