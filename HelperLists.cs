using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public static class TerroristList
    {
        public static List<Terrorist> terrorists = new List<Terrorist>()
        {
            new Terrorist("muhamad", 1, "alive", ["gun"]),
            new Terrorist("ali", 2, "alive", ["gun", "knife"]),
            new Terrorist("yusuf", 3, "alive", ["gun", "shotgun"])
        };
    }


    public static class CombatToolsList
    {
        public static List<object> wapens = new List<object>
        {
            new F16FighterJet(),
            new Hermes460Drone(),
            new Artillery()
        };
    }

    public static class Places
    {
        public static List<string> places = new List<string>
        {
            "han yunes",
            "gazza",
            "yosh",
            "levanon"
        };
    }



    public static class Dates
    {
        public static List<double> dates = new List<double>
        {
            2024,
            2023,
            2002,
            2001,
            2009,
            2008,
            2007,
            2006
        };
    }


    public static class IntelligenceMessages
    {
        public static List<string> intelligenceMessages = new List<string>
        {
            "A lone terrorist was spotted placing an IED near Route 443.",

            "One armed militant attempted to breach the southern checkpoint on foot.",

            "A single hostile opened fire on an IDF jeep near Sector B.",

            "One suspect carrying explosives was neutralized outside the base perimeter.",

            "A terrorist disguised as a farmer was caught surveying troop movements.",

            "A lone shooter targeted the watchtower at 0400 hours before fleeing.",

            "A single militant was observed marking IDF vehicle positions with laser guidance.",

            "A terrorist attempted to smuggle a handgun through civilian access route 7.",

            "One individual was detected cutting through the border fence with bolt cutters.",

            "A single operative launched a short-range rocket from an improvised platform.",

            "A hostile on a motorbike threw an incendiary device at a patrol unit.",

            "A lone infiltrator was seen planting surveillance equipment near the outpost.",

            "One terrorist attempted to enter the base posing as humanitarian aid.",

            "A single sniper fired at the forward observation post before escaping into the hills.",

            "A militant was caught trying to ignite a fuel tank inside a logistics vehicle.",

            "A lone attacker approached the gate with a concealed explosive vest.",

            "One hostile individual attempted to disable communications wiring near HQ.",

            "A terrorist armed with a knife breached the outer wall but was subdued.",

            "A militant dropped propaganda leaflets inside the buffer zone before fleeing.",

            "A suspect was observed photographing sensitive infrastructure using a high-zoom lens."
        };
    }

}
