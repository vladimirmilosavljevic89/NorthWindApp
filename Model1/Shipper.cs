using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
   public class Shipper
    {
        private int shipperID;
        private string companyName;
        private string phone;

        public int ShipperID
        {
            get
            {
                return shipperID;
            }

            set
            {
                shipperID = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
    }
}
