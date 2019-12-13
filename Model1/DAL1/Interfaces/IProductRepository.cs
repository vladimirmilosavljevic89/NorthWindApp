using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL1.Interfaces
{
public     interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productID);
        int AddProducts(Product product);
        int UpdateProducts(Product product);
        int DeleteProducts(int productID);
    }
}
