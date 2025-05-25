using IDFOpertion.Models;
using System.Collections.Generic;

namespace IDFOpertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Terrorist> terroristList = new TerroristList().terrorists;
            Console.WriteLine(terroristList[2].Name); 
            List<string> places = new Places().places;
            Console.WriteLine(places[3]);
            List<double> dates = new Dates().dates;
            Console.WriteLine(dates[1]);
            AMAN aman = new AMAN(terroristList, places, dates);
        }
    }
}