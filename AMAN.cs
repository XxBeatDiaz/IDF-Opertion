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
        protected List<string> LastKnownLocationOfTerrorist;
        protected List<double> IntelligenceCollectionTimestamp;

        public AMAN(List<Terrorist> specificTerrorist,
            List<string> lastKnownLocationOfTerrorist,
            List<double> intelligenceCollectionTimestamp)
        {
            SpecificTerrorist = specificTerrorist;
            LastKnownLocationOfTerrorist = lastKnownLocationOfTerrorist;
            IntelligenceCollectionTimestamp = intelligenceCollectionTimestamp;
        }
    }
}
