using IDFOpertion.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Weapons
{
    public class Artillery : CombatTool
    {
        public bool SimultaneousAttack;

        public Artillery()
        {
            ToolType = "Artillery";
            TypeBomb = "Explosive shellsb";
            EffectiveAgainst = "Open spaces";
            AvailableAttacks = 40;
            SimultaneousAttack = true;
        }
    }
}
