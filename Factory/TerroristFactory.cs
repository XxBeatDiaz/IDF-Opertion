using IDFOpertion.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDFOpertion.Factory
{
    public static class TerroristFactory
    {
        static Random Random = new Random();

        private static List<string> arabicNames = new List<string>
        {
            "Ahmad", "Mohammed", "Ali", "Omar", "Hassan", "Hussein",
            "Ibrahim", "Khalid", "Youssef", "Mustafa", "Samir", "Nasser",
            "Tariq", "Salim", "Zaid", "Bilal", "Karim", "Anas", "Faisal", "Imad"
        };

        private static List<string> availableNames = new List<string>(arabicNames);


        private static string GetName()
        {
            if (availableNames.Count == 0)
            {
                availableNames = new List<string>(arabicNames);
            }

            int index = Random.Next(availableNames.Count);
            string name = availableNames[index];
            availableNames.RemoveAt(index); 
            return name;
        }


        private static List<int> availableId = new List<int>();

        private static int GetId()
        {
            int id = Random.Next(10000000,99999999);
            while (true)
            {
                if (!availableId.Contains(id))
                    break;
            }

            return id;
        }

        public static List<Terrorist> terrorists(int numOfEnemies)
        {
            List<Terrorist> enemies = new List<Terrorist>();
            for (int i = 0; i < numOfEnemies; i++)
            {
                enemies.Add(new Terrorist(GetName(), GetId(), Random.Next(1, 6), WeaponsEnemyFactory.WeaponsEnemy(Random.Next(1, 4))));
            }
            return enemies;
        }
    }
}
