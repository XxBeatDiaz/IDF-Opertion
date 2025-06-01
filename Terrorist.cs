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
        public string LifeStatus = "alive";
        public List<string> Weapon;
        public int Id;

        public Terrorist(string name, int id, int rank, List<string> weapon)
        {
            Name = name;
            Id = id;
            Rank = rank;
            Weapon = weapon;
        }

        public bool IsAliive()
        {
            if (LifeStatus == "alive")
                return true;
            else
                return false;
        }
    }
}
