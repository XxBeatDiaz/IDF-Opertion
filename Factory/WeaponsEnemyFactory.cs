using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Factory
{
    public static class WeaponsEnemyFactory
    {

        private static Random Random = new Random();

        private static List<string> weaponsEnemy = new List<string>
        {
            "M16",
            "Gun",
            "AK-47",
            "Knife"
        };

        public static List<string> WeaponsEnemy(int numOfWeapons)
        {
            List<string> weapons = new List<string>();
            for (int i = 1; i <= numOfWeapons; i++)
            {
                weapons.Add(weaponsEnemy[Random.Next(0, weaponsEnemy.Count)]);
            }
            return weapons;
        }




    }
}
