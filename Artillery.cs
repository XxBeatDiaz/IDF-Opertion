using IDFOpertion.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class Artillery : CombatTool
    {
        private bool SimultaneousAttack;

        public Artillery()
        {
            TypeBomb = "Explosive shellsb";
            EffectiveAgainst = "Open spaces";
            AvailableAttacks = 40;
            SimultaneousAttack = true;
        }
    }
}
