using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOpertion.Abstract;

namespace IDFOpertion.Weapons
{
    public class Hermes460Drone : CombatTool
    {

        public Hermes460Drone()
        {
            ToolType = "Hermes 460 drone";
            TypeBomb = "drone bomb";
            EffectiveAgainst = "people, armored vehicles";
            AvailableAttacks = 3;
        }
    }
}
