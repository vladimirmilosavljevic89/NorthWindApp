using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL1.Interfaces
{
    interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee getEmployeeByID(int employeeID);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int deleteEmployee(int employeeID);
    }
}
