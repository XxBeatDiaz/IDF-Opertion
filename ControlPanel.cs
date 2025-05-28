using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDFOpertion.Models
{
    public static class ControlPanel
    {
        public static int Menu()
        {
            Console.WriteLine("\n" +
                "What action do you want to perform? \n" +
                "1. Intelligence analysis \n" +
                "2. Attack availability \n" +
                "3. Prioritizing goals \n" +
                "4. Attack \n" +
                "5. Exit \n");
            int choosing = int.Parse(Console.ReadLine()!);
            return choosing;

        }
    }
}
