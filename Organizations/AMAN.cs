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
            return Locations[random.Next(Locations.Count)];
        }


        private DateTime GetDateTime(DateTime startDate, DateTime endDate)
        {
            DateTime dateTime = new DateTime();
            int rangeDays = (endDate - startDate).Days;
            int randomDays = random.Next(0, rangeDays);
            dateTime = startDate.AddDays(randomDays);
            return dateTime;
        }


        public Dictionary<Terrorist, (int, int, string, DateTime)> GetTerroristDict()
        {
            return Terrorists;
        }

        public void PrintTerroristsTable()
        {
            int columnWidth = 16;

            string Pad(string text) => text.PadRight(columnWidth);

            Console.WriteLine(
                Pad("Name") +
                Pad("Rank") +
                Pad("LifeStatus") +
                Pad("LastLocation") +
                Pad("Reports") +
                Pad("QualityScore") +
                Pad("LastSeen") +
                Pad("Weapons")
            );

            Console.WriteLine(new string('-', columnWidth * 8));

            foreach (var kvp in Terrorists)
            {
                var terrorist = kvp.Key;
                var data = kvp.Value;

                string weapons = string.Join(", ", terrorist.Weapon) + ".";

                Console.WriteLine(
                    Pad(terrorist.Name) +
                    Pad(terrorist.Rank.ToString()) +
                    Pad(terrorist.LifeStatus) +
                    Pad(data.Item3) +
                    Pad(data.Item1.ToString()) +
                    Pad(data.Item2.ToString()) +
                    Pad(data.Item4.ToShortDateString()) +
                    Pad(weapons)
                );
            }
        }

        public void UpsateTerrorist(int terroristId)
        {
            foreach (var trs in Terrorists)
            {
                if (trs.Key.Id == terroristId)
                {
                    Terrorist terrorist = trs.Key;
                    terrorist.LifeStatus = "dead";
                    var data = trs.Value;
                    Terrorists.Remove(trs.Key);
                    Terrorists.Add(terrorist, data);
                    break;
                }

            }
        }

        public int MostReportsTerrorist()
        {
            int terroristId = 0;
            string terroristName = null;
            int maxReports = 0;

            foreach (var terrorist in Terrorists)
            {
                if (terrorist.Value.Item1 > maxReports &&
                    terrorist.Key.IsAliive())
                {
                    maxReports = terrorist.Value.Item1;
                    terroristName = terrorist.Key.Name;
                    terroristId = terrorist.Key.Id;
                }
            }
            if (terroristId != 0)
                Console.WriteLine($"The terrorist: {terroristName}, have {maxReports} reports.");
            else
                Console.WriteLine("All terrorists are dead.");
            return terroristId;

        }


        public int MostDangerousTerrorist()
        {
            int terroristId = 0;
            Dictionary<Terrorist, (int, int, string, DateTime)> terrorist = new Dictionary<Terrorist, (int reportsCount, int qualityScore, string lastKnownLocation, DateTime lastDateTime)>();
            Terrorist terroristInfo = null;
            int maxQualityScore = 0;

            foreach (var trs in Terrorists)
            {
                if (trs.Value.Item2 > maxQualityScore &&
                    trs.Key.IsAliive())
                {
                    maxQualityScore = trs.Value.Item2;
                    terrorist[trs.Key] = trs.Value;
                    terroristInfo = trs.Key;
                    terroristId = trs.Key.Id;
                }
            }

            if (terroristId != 0)
            {
                Console.WriteLine($"The most dangerous terrorist is: \n" +
                $"Name: {terroristInfo.Name}. \n" +
                $"Rank {terroristInfo.Rank}. \n" +
                $"Quality score: {maxQualityScore}. \n" +
                $"Last location: {Terrorists[terroristInfo].Item3}");
                if (terroristInfo.Weapon.Count > 1)
                {
                    Console.WriteLine($"Weapons: {string.Join(", ", terroristInfo.Weapon)}.");
                }
                else
                    Console.WriteLine($"Weapon: {terroristInfo.Weapon[0]}");
            }
            else
                Console.WriteLine("All terrorists are dead.");

            return terroristId;
        }
    }
}
