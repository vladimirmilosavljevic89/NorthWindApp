using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL1.Interfaces
{
    interface IOrderDetailRepository
    {
        List<OrderDetails> GetAllOrderDetails();
        OrderDetails getEmployeeByID(int employeeID);
        int AddOrderDetails(OrderDetails orderDetails);
        int updateOrderDetails(OrderDetails orderDetails);
        int deleteDetails(int orderDetailsID);
    }
}
