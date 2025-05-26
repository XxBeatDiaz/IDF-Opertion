using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public abstract class CombatTool
    {
        public string TypeBomb;
        public string EffectiveAgainst;
        public int AvailableAttacks;

        public bool IsEmptyAmmu()
        {
            return AvailableAttacks > 0;
        }
        public bool Attack()
        {
            if (IsEmptyAmmu())
            {
                Console.WriteLine($"Ammu cappssity is empty");
                return false;
            }
            else
            {
                AvailableAttacks--;
                Console.WriteLine($"success! \n" +
                                  $"Cappasity ammu: {CappasityAmmu()}");
                return true;
            }
        }
        public int CappasityAmmu()
        {
            return AvailableAttacks;
        }
    }
}
