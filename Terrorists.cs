using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion
{
    public class Terrorists
    {
        string Name;
        int Rank;
        string LifeStatus;
        string Weapon;

        public Terrorists(string name, int rank, string lifeStatus, string weapon)
        {
            Name = name;
            Rank = rank;
            LifeStatus = lifeStatus;
            Weapon = weapon;
        }
    }
}
