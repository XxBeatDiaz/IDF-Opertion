using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class TerroristList
    {
        public List<Terrorist> terrorists = new List<Terrorist>() 
        {
            new Terrorist("muhamad", 1, "alive", ["gun"]),
            new Terrorist("ali", 2, "alive", ["gun", "knife"]),
            new Terrorist("yusuf", 3, "alive", ["gun", "shotgun"])
        };
    }


    public class CombatToolsList
    {
        public List<object> wapens = new List<object>
        {
            new F16FighterJet(),
            new Hermes460Drone(),
            new Artillery()
        };
    }

    public class Places
    {
        public List<string> places = new List<string>
        {
            "han yunes",
            "gazza",
            "yosh",
            "levanon"
        };
    }


    public class Dates
    {
        public List<double> dates = new List<double>
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

}
