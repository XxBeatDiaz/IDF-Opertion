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
        protected List<object> SpecificTerrorist;
        protected double LastKnownLocationOfTerrorist;
        protected double IntelligenceCollectionTimestamp;

        public AMAN(List<object> specificTerrorist,
            double lastKnownLocationOfTerrorist,
            double intelligenceCollectionTimestamp)
        {
            SpecificTerrorist = specificTerrorist;
            LastKnownLocationOfTerrorist = lastKnownLocationOfTerrorist;
            IntelligenceCollectionTimestamp = intelligenceCollectionTimestamp;
        }
    }
}
