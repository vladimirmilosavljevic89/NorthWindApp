using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
 public  class CustomerDemographics
    {
        private string customerID;
        private string demographicID;

        public string CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

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
    }
}
