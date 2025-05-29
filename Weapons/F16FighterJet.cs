using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOpertion.Abstract;

namespace IDFOpertion.Weapons
{
    public class F16FighterJet : CombatTool
    {
        string PilotOperated;
        public F16FighterJet() 
        {
            ToolType = "F16 Fighter Jet";
            TypeBomb = "Fighter bomb";
            EffectiveAgainst = "Biuldings";
            PilotOperated = "Pilot operated";
            AvailableAttacks = 8;
        }
    }
}
