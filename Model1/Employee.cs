using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
 public   class Employee
    {

        private int employeeID;
        private string lastName;
        private string firstName;
        private string title;
        private string titleOfCourtesy;
        private DateTime? hireDate;
        private DateTime? birthDate;
        private string address;
        private string city;
        private string region;
        private string postalCode;
        private string country;
        private string homePhone;
        private string extension;
        private string notes;
        private int? reportsTo;
        private string photoPath;

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                employeeID = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string TitleOfCourtesy
        {
            get
            {
                return titleOfCourtesy;
            }

            set
            {
                titleOfCourtesy = value;
            }
        }

        public DateTime? HireDate
        {
            get
            {
                return hireDate;
            }

            set
            {
                hireDate = value;
            }
        }

        public DateTime? BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
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

        public string PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string HomePhone
        {
            get
            {
                return homePhone;
            }

            set
            {
                homePhone = value;
            }
        }

        public string Extension
        {
            get
            {
                return extension;
            }

            set
            {
                extension = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }

        public int? ReportsTo
        {
            get
            {
                return reportsTo;
            }

            set
            {
                reportsTo = value;
            }
        }

        public string PhotoPath
        {
            get
            {
                return photoPath;
            }

            set
            {
                photoPath = value;
            }
        }
    }
}
