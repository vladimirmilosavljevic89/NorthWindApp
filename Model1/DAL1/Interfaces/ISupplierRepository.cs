using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;

namespace DAL1.Interfaces
{
    interface ISupplierRepository
    {
        List<Supplier> GetAllSuppliers();
        Supplier GetSupplierByID(int supplierID);
        int AddSupplier(Supplier suppplier);
        int updateSupplier(Supplier supplier);
        int deleteSupplier(int supplierID);
    }
}
