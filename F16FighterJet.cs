using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOpertion.Models;

namespace IDFOpertion.Models
{
    public class F16FighterJet : CombatTool
    {
        string PilotOperated;
        public F16FighterJet() 
        {
            TypeBomb = "Fighter bomb";
            EffectiveAgainst = "Biuldings";
            PilotOperated = "Pilot operated";
            AvailableAttacks = 8;
        }
    }
}
