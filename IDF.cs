using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOpertion.Models
{
    public class IDF
    {
        protected int DateOfEstablishment;
        protected string CurrentCensus;
        List<object> CollectionOfAttackOptions;

        public IDF(int dateOfEstablishment, string currentCensus, List<object> collectionOfAttackOptions)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCensus = currentCensus;
            CollectionOfAttackOptions = collectionOfAttackOptions;
        }

    }
}
