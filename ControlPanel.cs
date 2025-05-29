using IDFOpertion.Factory;
using IDFOpertion.Organizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDFOpertion.Models
{
    public static class ControlPanel
    {
        public static void Menu()
        {
            List<Terrorist> terrorists = TerroristFactory.terrorists(10);


            AMAN aman = new AMAN(terrorists);
            IDF idf = new IDF(2000, "Eyal Zamir", WeaponsIdfFactoru.FirstInit());
            Hamas hamas = new Hamas(1900, "Bin Ladden", terrorists);
            List<Terrorist> a = hamas.ListOfTerrorists;

            Console.WriteLine("Welcome, sir.");
            bool exit = false;
            do
            {
                Console.WriteLine("\n" +
                    "What action do you want to perform? \n" +
                    "1. Intelligence analysis \n" +
                    "2. Attack availability \n" +
                    "3. Prioritizing goals \n" +
                    "4. Attack \n" +
                    "5. Exit \n");
                int choosing = int.Parse(Console.ReadLine()!);

                switch (choosing)
                {
                    case 1:
                        aman.MostReportsTerrorist();
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
