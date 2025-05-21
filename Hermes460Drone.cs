using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOpertion.Models;

namespace IDFOpertion.Models
{
    public class Hermes460Drone : CombatTool
    {

        public Hermes460Drone()
        {
            TypeBomb = "drone bomb";
            EffectiveAgainst = "people, armored vehicles";
            AvailableAttacks = 3;
        }
    }
}
