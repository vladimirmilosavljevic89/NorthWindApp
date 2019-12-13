using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model1;
using DAL1.Interfaces.Repository;

namespace UnitTestProject1
{
    [TestClass]
    public class SupplierTest
    {
        [TestMethod]
        public void AddSupplier()
        {
            Supplier supplier = new Supplier();
            supplier.CompanyName1 = "eng";
            supplier.ContactName1 = "vlada";
            supplier.ContactTitle1 = "zaposleni";
            supplier.Address1 = "beograd";
            supplier.Country1 = "srbija";
            supplier.Fax1 = "123";
            supplier.PostalCode1 = "1100";
            supplier.Phone1 = "064****";
            supplier.HomePage1 = "eng.it";
            supplier.Region1 = "cukarica";
            supplier.City1 = "Beograd";

            SupplierRepository rep = new SupplierRepository();
            int id = rep.AddSupplier(supplier);
            Assert.IsNotNull(id > 0);

        }
        [TestMethod]
        public void UpdateSupplier()
        {
            Supplier supplier = new Supplier();
            supplier.SupplierID1 = 30;
            supplier.CompanyName1 = "eng123";
            supplier.ContactName1 = "vlada";
            supplier.ContactTitle1 = "zaposleni";
            supplier.Address1 = "beograd";
            supplier.Country1 = "srbija";
            supplier.Fax1 = "123";
            supplier.PostalCode1 = "1100";
            supplier.Phone1 = "064****";
            supplier.HomePage1 = "eng.it";
            supplier.Region1 = "cukarica";
            supplier.City1 = "Beograd";

            SupplierRepository rep = new SupplierRepository();
            int id = rep.updateSupplier(supplier);
            Assert.IsNotNull(id > 0);

        }
        [TestMethod]
        public void DeleteSupplier()
        {
            SupplierRepository rep = new SupplierRepository();
            rep.deleteSupplier(30);
            Assert.IsNotNull(rep);


        }
        [TestMethod]
        public void GetAllSuppliers()
        {
            SupplierRepository rep = new SupplierRepository();
            rep.GetAllSuppliers();
            Assert.IsNotNull(rep);



        }
        [TestMethod]
        public void GetSupplierById()
        {
            SupplierRepository rep = new SupplierRepository();

           Supplier supplier= rep.GetSupplierByID(31);
            Assert.IsNotNull(supplier);

        }

    }
}
