using IDFOpertion.Abstract;
using IDFOpertion.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Factory
{
    public static class WeaponsIdfFactoru
    {
        public static List<CombatTool> FirstInit()
        {
            List<CombatTool> combatTools = new List<CombatTool>
            {
                new F16FighterJet(),
                new Artillery(),
                new Hermes460Drone()
            };
            return combatTools;
        }

        public static List<CombatTool> CombatTools(string typeOfTool, int amountOftool)
        {
            List<CombatTool> combatTools = new List<CombatTool>();
            switch (typeOfTool.ToLower())
            {
                case "f16":
                    for (int i = 1; i <= amountOftool; i++)
                    {
                        combatTools.Add(new F16FighterJet());
                    }
                    break;
                case "drone":
                    for (int i = 1; i <= amountOftool; i++)
                    {
                        combatTools.Add(new Hermes460Drone());
                    }
                    break;
                case "artillery":
                    for (int i = 1; i <= amountOftool; i++)
                    {
                        combatTools.Add(new Artillery());
                    }
                    break;
            }
            return combatTools;
        }

        public static List<Artillery> Artillerys(int numOfArtillerys)
        {
            List<Artillery> Artillerys = new List<Artillery>();
            for (int i = 1; i <= numOfArtillerys; i++)
            {
                Artillerys.Add(new Artillery());
            }
            return Artillerys;
        }

        public static List<F16FighterJet> F16FighterJets(int numOfF16FighterJets)
        {
            List<F16FighterJet> f16FighterJets = new List<F16FighterJet>();
            for (int i = 1; i <= numOfF16FighterJets; i++)
            {
                f16FighterJets.Add(new F16FighterJet());
            }
            return f16FighterJets;
        }

        public static List<Hermes460Drone> Hermes460Drones(int numberOfHermes460Drones)
        {
            List<Hermes460Drone> hermes460Drones = new List<Hermes460Drone>();
            for (int i = 1; i <= numberOfHermes460Drones; i++)
            {
                hermes460Drones.Add(new Hermes460Drone());
            }
            return hermes460Drones;
        }
    }
}
