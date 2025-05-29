using IDFOpertion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Factory
{
    public static class TerroristFactory
    {

        static Random Random = new Random();

        private static List<string> arabicNames = new List<string>
        {
            "Ahmad",
            "Mohammed",
            "Ali",
            "Omar",
            "Hassan",
            "Hussein",
            "Ibrahim",
            "Khalid",
            "Youssef",
            "Mustafa",
            "Samir",
            "Nasser",
            "Tariq",
            "Salim",
            "Zaid",
            "Bilal",
            "Karim",
            "Anas",
            "Faisal",
            "Imad"
        };

        public static List<Terrorist> terrorists(int numOfEnemies)
        {

            List<Terrorist> enemies = new List<Terrorist>();
            for (int i = 1; i <= numOfEnemies; i++)
            {
                enemies.Add(new Terrorist(arabicNames[Random.Next(0, arabicNames.Count)], Random.Next(1, 6), WeaponsEnemyFactory.WeaponsEnemy(Random.Next(1,3))));
            }
            return enemies;

        }


    }
}
