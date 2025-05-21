using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion
{
    public abstract class AttackTools
    {
        string TypeBomb;
        string EffectiveAgainst;
        int AvailableAttacks;

        public AttackTools(string typeBomb, string effectiveAgainst, int availableAttacks)
        {
            TypeBomb = typeBomb;
            EffectiveAgainst = effectiveAgainst;
            AvailableAttacks = availableAttacks;
        }
    }
}
