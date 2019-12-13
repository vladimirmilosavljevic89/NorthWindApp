using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL1.Interfaces
{
    interface IOrderRepository
    {
        List<Order> GetAllEmployees();
        Order getEmployeeByID(int orderID);
        int AddOrder(Order order);
        int UpdateOrder(Order orderID);
        int deleteOrder(int orderID);
    }
}
