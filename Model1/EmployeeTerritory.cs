using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
 public   class EmployeeTerritory
    {
        private int employeeID;
        private string territoryID;

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
    }
}
