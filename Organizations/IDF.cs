using IDFOpertion.Abstract;
using IDFOpertion.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Organizations
{
    public class IDF
    {
        protected int DateOfEstablishment;
        protected string CurrentCensus;
        public List<CombatTool> CombatTools;

        public IDF(int dateOfEstablishment, string currentCensus, List<CombatTool> collectionOfAttackOptions)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCensus = currentCensus;
            CombatTools = collectionOfAttackOptions;
        }


        public void CombatToolsAvailable()
        {
            foreach (CombatTool tool in CombatTools)
            {
                Console.WriteLine($"{tool.ToolType}: {tool.CappasityAmmu()} {tool.TypeBomb}");
            }
        }

        private CombatTool GetTool(string location)
        {
            CombatTool combatTool = null;
            string typeTool = "";

            if (location.Contains("car"))
                typeTool = "Hermes 460 drone";

            else if (location.Contains("outside"))
                typeTool = "Artillery";

            else if (location.Contains("home"))
                typeTool = "F16 Fighter Jet";

            foreach (var tool in CombatTools)
                {
                    if (tool.ToolType == typeTool)
                    {
                        if (tool.IsEmptyAmmu())
                            continue;
                        else
                        {
                            combatTool = tool;
                            break;
                        }
                    }
                }

            if (combatTool is null)
                Console.WriteLine($"Empty ammu");

            return combatTool;
        }


        public int Attack(Dictionary<Terrorist, (int, int, string, DateTime)> terroristDict, int terroristId)
        {
            CombatTool combatTool;
            if (terroristId == 0)
                Console.WriteLine("The terrorist was not selected.");
            else
            {
                foreach (var terrorist in terroristDict)
                {
                    if (terrorist.Key.Id == terroristId)
                    {
                        if (terrorist.Key.IsAliive())
                        {
                        string location = terrorist.Value.Item3;
                        combatTool = GetTool(location);
                            if (combatTool is not null)
                            {
                                combatTool.Attack(terrorist.Key.Name);
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"The terrorist {terrorist.Key.Name} is already dead.");
                            terroristId = 0;
                            break;
                        }
                    }
                }
            }
            return terroristId;
        }
    }
}
