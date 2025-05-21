using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class Terrorist
    {
        string Name;
        int Rank;
        string LifeStatus;
        string[] Weapon;

        public Terrorist(string name, int rank, string lifeStatus, string[] weapon)
        {
            Name = name;
            Rank = rank;
            LifeStatus = lifeStatus;
            Weapon = weapon;
        }
    }
}
