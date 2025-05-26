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
    }
}
