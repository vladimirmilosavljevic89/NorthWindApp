using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
 public   class Region
    {
        private int regionID;
        private string regionDesription;

        public int RegionID
        {
            get
            {
                return regionID;
            }

            set
            {
                regionID = value;
            }
        }

        public string RegionDesription
        {
            get
            {
                return regionDesription;
            }

            set
            {
                regionDesription = value;
            }
        }
    }
}
