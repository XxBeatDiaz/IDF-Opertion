using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class IDF
    {
        protected int DateOfEstablishment;
        protected string CurrentCensus;
        public List<CombatTool> CollectionOfAttackOptions;

        public IDF(int dateOfEstablishment, string currentCensus, List<CombatTool> collectionOfAttackOptions)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCensus = currentCensus;
            CollectionOfAttackOptions = collectionOfAttackOptions;
        }


        public void CombatToolsAvailable()
        {
            foreach (CombatTool tool in CollectionOfAttackOptions)
            {
                Console.WriteLine($"{tool.ToolType}: {tool.CappasityAmmu()} {tool.TypeBomb}");
            }


        }

    }
}
