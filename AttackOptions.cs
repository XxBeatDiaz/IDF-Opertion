using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.models
{
    public class AttackOptions
    {
        protected object ToolName;
        protected int AmmunitionCapacity;
        protected int FuelSupply;
        protected int EffectiveForTarget;

        public AttackOptions(object toolName,
            int ammunitionCapacity,
            int fuelSupply,
            int effectiveForTarget)
        {
            ToolName = toolName;
            AmmunitionCapacity = ammunitionCapacity;
            FuelSupply = fuelSupply;
            EffectiveForTarget = effectiveForTarget;
        }
    }
}
