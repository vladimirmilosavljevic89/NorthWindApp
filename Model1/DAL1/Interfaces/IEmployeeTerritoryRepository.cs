using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL1.Interfaces
{
    public interface IEmployeeTerritoryRepository
    {
        List<EmployeeTerritory> GetAllEmployees();
         EmployeeTerritory getEmployeeTerritoryByID(int employeeTeritorryID);
        int AddEmployeeTerritory(EmployeeTerritory employee);
        int UpdateEmployeeTerritory(EmployeeTerritory employee);
        int deleteEmployeeTerritory(int employeeID);
    }
}
