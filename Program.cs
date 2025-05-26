using IDFOpertion.Models;
using System.Collections.Generic;

namespace IDFOpertion
{
    class Program
    {
        static void Main(string[] args)
        {
            AMAN a = new AMAN(TerroristList.terrorists, Places.places, Dates.dates);
            a.Display();
        }
    }
}