using IDFOpertion.Models;
using System.Collections.Generic;

namespace IDFOpertion
{
    class Program
    {
        static void Main(string[] args)
        {
            AMAN aman = new AMAN(HelperLists.terrorists, HelperLists.places, HelperLists.dates);
            IDF idf = new IDF(2000, "Eyal Zamir", HelperLists.wapens);
            Hamas hamas = new Hamas(1900, "Muhamad", HelperLists.terrorists);


            Console.WriteLine("Welcome, sir.");
            bool exit = false;
            do
            {
                
                int choosing = ControlPanel.Menu();
                switch (choosing)
                {
                    case 1:
                        aman.Display();
                        break;
                    case 2:
                        idf.CombatToolsAvailable();
                        break;
                    case 3:
                        Terrorist mostDangerousTerrorist = aman.MostDangerousTerrorist();
                        break;
                    case 4:
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        break;
                }

            } while (!exit);
        }
    }
}