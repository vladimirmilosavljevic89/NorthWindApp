using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
public    class Demographics
    {
        private string demographicID;
        private string description;

        public string DemographicID
        {
            get
            {
                return demographicID;
            }

            set
            {
                demographicID = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}
