using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model1;
using DAL1.Interfaces.Repository;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class ProductTest
    {
       
        public void AddProduct()
        {
            Product products = new Product();
            products.ProductName1 = "poz";
            products.QuantityPerUnit1 = "4444";
            products.ReorderLevel1 = 4;
            products.UnitsOnOrder1 = 4;
            products.UnitsInStock1 = 1;
            products.Discontinued1 = false;
            products.SupplierID1 = 3;
            products.UnitPrice1 = 1111;
            products.CategoryID1 = 2;


            ProductRepository rep = new ProductRepository();
            int id = rep.AddProducts(products);
            Assert.IsNotNull(id > 0);
        }
        [TestMethod]
        public void UpdateProduct()
        {

            Product products = new Product();
            products.ProductID1 = 101;
            products.ProductName1 = "poz";
            products.QuantityPerUnit1 = "4444";
            products.ReorderLevel1 = 4;
            products.UnitsOnOrder1 = 4;
            products.UnitsInStock1 = 1;
            products.Discontinued1 = false;
            products.SupplierID1 = 3;
            products.UnitPrice1 = 1111;
            products.CategoryID1 = 2;


            ProductRepository rep = new ProductRepository();
            int id = rep.UpdateProducts(products);
            Assert.IsNotNull(id > 0);
        }

        [TestMethod]
        public void GetAllProducts()
        {
            ProductRepository rep = new ProductRepository();
            rep.GetAllProducts();
            Assert.IsNotNull(rep);



        }
        [TestMethod]
        public void DeleteProduct()
        {
            Product product = new Product();
            
            ProductRepository rep = new ProductRepository();
             rep.DeleteProducts(product);
            Assert.IsNotNull(product.ProductID1);
}
        [TestMethod]
        public void GetProductByIdTest()
        {
            ProductRepository rep = new ProductRepository();
            Product product = rep.GetProductById(100);

            Assert.IsNotNull(product);
        }
    }
}