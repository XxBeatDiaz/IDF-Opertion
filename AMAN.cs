using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class AMAN
    {
        protected List<Terrorist> SpecificTerrorist;
        protected List<string> LastKnownLocation;
        protected List<double> TimeStamp;

        public AMAN(
            List<Terrorist> specificTerrorist,
            List<string> lastKnownLocation,
            List<double> timeStamp)

        {
            SpecificTerrorist = specificTerrorist;
            LastKnownLocation = lastKnownLocation;
            TimeStamp = timeStamp;
        }
    }
}
