using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL1.Interfaces
{
    interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerID);
        int AddCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        int deleteCustomer(int customerID);
    }
}
