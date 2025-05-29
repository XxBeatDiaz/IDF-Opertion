using IDFOpertion.Factory;
using IDFOpertion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace IDFOpertion.Organizations
{
    public class AMAN
    {
        Random random = new Random();

        private Dictionary<Terrorist, (int, int, string, DateTime)> Terrorists = new Dictionary<Terrorist, (int reportsCount, int qualityScore, string lastKnownLocation, DateTime lastDateTime)>();

        public AMAN(List<Terrorist> terroristList)
        {
            foreach (Terrorist terrorist in terroristList)
            {
                Terrorists[terrorist] = (GetReports(), GetQualityScore(terrorist), GetLocation(), GetDateTime(new DateTime(2000, 1, 1), DateTime.Now));
            }
        }


        private int GetReports()
        {
            return random.Next(0, 20);
        }


        private int GetQualityScore(Terrorist terrorist)
        {
            Dictionary<string, int> weaponPoints = new Dictionary<string, int>
            {
                {"knife", 1 },
                {"gun", 2 },
                {"ak-47", 3 },
                {"m16", 3 }
            };

            int qualityScore = 0;

            if (terrorist.Weapon.Count > 1)
            {
                foreach (string weapon in terrorist.Weapon)
                {
                    qualityScore += weaponPoints[weapon.ToLower()];
                }
            }
            else
                qualityScore += weaponPoints[terrorist.Weapon[0].ToLower()];
            qualityScore *= terrorist.Rank;

            return qualityScore;
        }


        private string GetLocation()
        {
            List<string> Locations = new List<string> { "at home", "outside", "in the car" };
            return Locations[random.Next(0, Locations.Count)];
        }


        private DateTime GetDateTime(DateTime startDate, DateTime endDate)
        {
            DateTime dateTime = new DateTime();
            int rangeDays = (endDate - startDate).Days;
            int randomDays = random.Next(0, rangeDays);
            dateTime = startDate.AddDays(randomDays);
            return dateTime;
        }


        private void PrintWeapons(List<string> weapons)
        {
            string str = "";
            foreach (string weapon in weapons)
            {
                str += weapon + " ";
            }
            Console.WriteLine(str);
        }


        public Terrorist MostReportsTerrorist()
        {
            Terrorist terrorist = null; 
            int maxReports = 0;

            foreach (var trs in Terrorists)
            {
                if (trs.Value.Item1 > maxReports)
                {
                    maxReports = trs.Value.Item1;
                    terrorist = trs.Key;
                }
            }
            Console.WriteLine($"The terrorist: {terrorist.Name}, have {maxReports} reports.");
            return terrorist;
        }

        
        public Terrorist MostDangerousTerrorist()
        {
            Terrorist terrorist = null;
            int maxQualityScore = 0;

            foreach (var trs in Terrorists)
            {
                if (trs.Value.Item2 > maxQualityScore)
                {
                    maxQualityScore = trs.Value.Item2;
                    terrorist = trs.Key;
                }
            }

            Console.WriteLine($"The most dangerous terrorist is: \n" +
                $"Name: {terrorist.Name}. \n" +
                $"Rank {terrorist.Rank}. \n" +
                $"Quality score: {maxQualityScore}. \n" +
                $"Last location: {Terrorists[terrorist].Item3}");
            if (terrorist.Weapon.Count > 1)
            {
                Console.Write("Weapons: ");
                PrintWeapons(terrorist.Weapon);
            }
            else
            {
                Console.Write("Weapon: ");
                PrintWeapons(terrorist.Weapon);
            }

            return terrorist;
        }
       
    }
}
