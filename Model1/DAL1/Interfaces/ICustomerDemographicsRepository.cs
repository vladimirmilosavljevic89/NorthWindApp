using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL1.Interfaces
{
    interface ICustomerDemographicsRepository
    {
        List<CustomerDemographics> GetAll();
        CustomerDemographics GetCustomerDemographicById(int customerDemographicId);
        int AddCustomerDemographic(CustomerDemographics customerDemographic);
        int UpdateCustomerDemographic(CustomerDemographics customerDemographic);
        int DeleteCustomerDemographic(int customerDemographicId);
    }
}
