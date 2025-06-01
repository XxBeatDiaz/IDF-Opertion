using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Abstract
{
    public abstract class CombatTool
    {
        public string ToolType;
        public string TypeBomb;
        public string EffectiveAgainst;
        public int AvailableAttacks;

        public bool IsEmptyAmmu()
        {
            return AvailableAttacks == 0;
        }
        public void Attack(string nameTerrorist)
        {
            AvailableAttacks--;
            Console.WriteLine($"success! \n" +
                              $"{ToolType} attack whith {TypeBomb} the terrorist {nameTerrorist}! \n" +
                              $"Cappasity ammu: {CappasityAmmu()}\n");
        }
        public int CappasityAmmu()
        {
            return AvailableAttacks;
        }
    }
}
