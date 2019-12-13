using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public class Customer
    {
        private string customerID;
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string address;
        private string city;
        private string region;
        private string phone;
        private string fax;
        private string PostalCode;

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

        public string ContactName
        {
            get
            {
                return contactName;
            }

            set
            {
                contactName = value;
            }
        }

        public string ContactTitle
        {
            get
            {
                return contactTitle;
            }

            set
            {
                contactTitle = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
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

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public string PostalCode1
        {
            get
            {
                return PostalCode;
            }

            set
            {
                PostalCode = value;
            }
        }
    }
}
