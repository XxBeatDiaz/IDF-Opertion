using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class CombatToolsList
    {
        public List<object> wapens = new List<object>
        {
            new F16FighterJet(),
            new Hermes460Drone(),
            new Artillery()
        };
    }
}
