using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class AMAN
    {
        private List<Terrorist> Terrorists;
        private List<string> LastKnownLocation;
        private List<double> TimeStamp;
        private Dictionary<Terrorist, int> TerroristReport = new Dictionary<Terrorist, int>();

        public AMAN(
            List<Terrorist> terroristList,
            List<string> lastKnownLocation,
            List<double> timeStamp)
        {
            Terrorists = terroristList;
            LastKnownLocation = lastKnownLocation;
            TimeStamp = timeStamp;

            foreach (Terrorist terrorist in Terrorists)
            {
                int reports =  GetRandomNum(1, 20);
                TerroristReport[terrorist] = reports;
            }
        }




        //Help function
        private int GetRandomNum(int from, int to)
        {
            Random r = new Random();          
            return r.Next(from, to);
        }



        //temporery display זמני בלבד!!!!
        public void Display()
        {
            var maxPair = TerroristReport.Aggregate((x, y) => x.Value > y.Value ? x : y);
            Terrorist terrorist = maxPair.Key;
            int terroristReport = maxPair.Value;
            Console.WriteLine($"The terrorist: {terrorist.Name}, have:{terroristReport} reports"); 
        }




        public Terrorist MostReports()
        {
            var maxPair = TerroristReport.Aggregate((x, y) => x.Value > y.Value ? x : y);
            Console.WriteLine($"The terrorist: {maxPair.Key.Name}, have:{maxPair.Value} reports");
            return maxPair.Key;
        }



        public Terrorist MostDangerousTerrorist()
        {
            Dictionary<string, int> mostDangerousTerrorist = new Dictionary<string, int> { };

            Dictionary<string, int> weaponPoints = new Dictionary<string, int>
            {
                {"knife", 1 },
                {"gun", 2 },
                {"AK47", 3 },
                {"M16", 3 }
            };

            foreach (Terrorist terorist in Terrorists)
            {
                int sumPoints = 0;

                if (terorist.Weapon.Length > 1)
                {
                    foreach(string weapon in terorist.Weapon)
                    {
                        if (weaponPoints.Keys.Contains(weapon))
                        {
                            sumPoints += weaponPoints[weapon];
                        }
                    }
                }
                else
                    sumPoints += weaponPoints[terorist.Weapon[0]];
                sumPoints *= terorist.Rank;
                mostDangerousTerrorist[terorist.Name] = sumPoints;
            }
            
            var maxPair = mostDangerousTerrorist.Aggregate((x, y) => x.Value > y.Value ? x : y);
            int idx = 0;
            foreach(Terrorist terorist in Terrorists)
            {
                if (terorist.Name == maxPair.Key)
                    break;
                idx++;
            }
            Console.WriteLine($"The most dangerous terrorist is: {Terrorists[idx].Name}");

            return Terrorists[idx];
        }

    }
}
