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
            List<Terrorist> terrorists = TerroristFactory.terrorists(4);
            int mostReportsTerroristId = 0;
            int mostDangerousTerroristId = 0;
            int deatTerroristId = 0;

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
                    "1. List of terrorists \n" +
                    "2. Most reports terrorist \n" +
                    "3. Most dangerous terrorist \n" +
                    "4. Attack availability \n" +
                    "5. Attack \n" +
                    "6. Exit \n");
                int choosing = int.Parse(Console.ReadLine()!);

                switch (choosing)
                {
                    case 1:
                        aman.PrintTerroristsTable();
                        break;
                    case 2:
                        mostReportsTerroristId = aman.MostReportsTerrorist();
                        break;
                    case 3:
                        mostDangerousTerroristId = aman.MostDangerousTerrorist();
                        break;
                    case 4:
                        idf.CombatToolsAvailable();
                        break;
                    case 5:
                        if (mostReportsTerroristId == 0 &&
                            mostDangerousTerroristId == 0)
                            Console.WriteLine("No terrorist was selected.");
                        else
                        {
                            Console.WriteLine("Which terrorists to kill? \n" +
                            "1. Most reports terrorist \n" +
                            "2. Most dangerous terrorist");
                            int terroristAttack = int.Parse(Console.ReadLine()!);
                            if (terroristAttack == 1)
                                deatTerroristId = idf.Attack(aman.GetTerroristDict() ,mostReportsTerroristId);
                                
                            else if (terroristAttack == 2)
                                deatTerroristId = idf.Attack(aman.GetTerroristDict(), mostDangerousTerroristId);
                            if (terroristAttack != 0)
                                aman.UpsateTerrorist(deatTerroristId);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Have a good day.");
                        exit = true;
                        break;
                    default:
                        break;
                }

            } while (!exit);

        }
    }
}
