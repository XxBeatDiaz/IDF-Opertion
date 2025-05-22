using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IDFOpertion.Models
{
    public class Hamas
    {
        int DateOfEstablishment;
        string CurrentCensus;
        List<Terrorist> ListOfTerrorists;

        public Hamas(int dateOfEstablishment, string currentCensus, List<Terrorist> listOfTerrorists)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCensus = currentCensus;
            ListOfTerrorists = listOfTerrorists;
        }
    }
}
