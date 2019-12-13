using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
  public  class Territory
    {
        private string territoryID;
        private string territoryDescription;
        private int regionID;

        public string TerritoryID
        {
            get
            {
                return territoryID;
            }

            set
            {
                territoryID = value;
            }
        }

        public string TerritoryDescription
        {
            get
            {
                return territoryDescription;
            }

            set
            {
                territoryDescription = value;
            }
        }

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
    }
}
