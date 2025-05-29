using IDFOpertion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IDFOpertion.Organizations
{
    public class Hamas
    {
        public int DateOfEstablishment;
        public string CurrentCensus;
        public List<Terrorist> ListOfTerrorists;

        public Hamas(int dateOfEstablishment, string currentCensus, List<Terrorist> listOfTerrorists)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCensus = currentCensus;
            ListOfTerrorists = listOfTerrorists;
        }
    }
}
