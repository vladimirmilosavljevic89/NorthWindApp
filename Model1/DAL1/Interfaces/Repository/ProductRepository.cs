using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DAL1.Interfaces.Repository
{
    public class ProductRepository : IProductRepository
    {
        public int AddProducts(Product product)
        {


            if (product == null) {
                throw new NullReferenceException();
            }
            int productId;

            try {

                Konekcija kon = new Konekcija();
                kon.OpenConnection();
                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon.NorthWindKonekcija();
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.CommandText = "AddProduct";
                komanda.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = product.ProductName1; ;
                komanda.Parameters.Add("@ReorderLevel", SqlDbType.SmallInt).Value=product.ReorderLevel1;
                komanda.Parameters.Add("@QuantityPerUnit",SqlDbType.NVarChar).Value= product.QuantityPerUnit1;
                komanda.Parameters.Add("@UnitsInStock", SqlDbType.SmallInt).Value = product.UnitsInStock1;              
                komanda.Parameters.Add("@UnitPrice",SqlDbType.Money).Value=product.UnitPrice1;
                komanda.Parameters.Add("@UnitsOnOrder",SqlDbType.SmallInt).Value=product.UnitsOnOrder1;
                komanda.Parameters.Add("@Discontinued", SqlDbType.Bit).Value = product.Discontinued1;
                komanda.Parameters.Add("@SupplierID",SqlDbType.Int).Value=product.SupplierID1;
                 komanda.Parameters.Add("@CategoryID",SqlDbType.Int).Value=product.CategoryID1;
          

                productId = Convert.ToInt32(komanda.ExecuteScalar());
                kon.CloseConnection();
            }




            catch (Exception ex)
            {
                throw new Exception("Error ");
            }
            return productId;
        }
    
        

        public int DeleteProducts(int productID)
        {
            Konekcija kon = new Konekcija();
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon.NorthWindKonekcija();
            komanda.CommandType = CommandType.StoredProcedure;
            komanda.CommandText = "DeleteProduct";
            komanda.Parameters.Add("@ProductID", SqlDbType.Int);
            komanda.Parameters["@ProductID"].Value = productID;
            try
            {
                kon.OpenConnection();
                komanda.ExecuteNonQuery();
                return 0;
            }
            catch
            {
                return -1;
            }
            finally
            {
                kon.CloseConnection();
            }
        }

        public List<Product> GetAllProducts()
        {


            List<Product> listaProdukata = new List<Product>();
            Konekcija kon = new Konekcija();
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon.NorthWindKonekcija();
            komanda.CommandText = "Select ProductID,ProductName  from Products";
            kon.OpenConnection();
            SqlDataReader dr = komanda.ExecuteReader();
            while (dr.Read())
            {
                Product products = new Product();
                products.ProductID1 = int.Parse(dr["ProductID"].ToString());
                products.ProductName1 = dr["ProductName"].ToString();
                /* products.UnitsOnOrder1 = Convert.ToInt16(dr["UnitsOnOrder"].ToString());
                 products.ReorderLevel1 = Convert.ToInt16(dr["ReorderLevel"].ToString());
                 products.QuantityPerUnit1 = dr["QuantityPerUnit"].ToString();
                 products.UnitsInStock1 = Convert.ToInt16(dr["UnitsInStock"].ToString());
                 products.Discontinued1 = Convert.ToBoolean(dr["Discontinued"].ToString());
                 products.CategoryID1 = Convert.ToInt32(dr["CategoryID"].ToString()); 
                 products.SupplierID1 =Convert.ToInt32(dr["SupplierID"].ToString());
                 products.UnitPrice1 = Convert.ToInt32(dr["UnitPrice"].ToString()); */
                listaProdukata.Add(products);


            }
            kon.CloseConnection();
            return listaProdukata;

        }

        public Product GetProductById(int productID)
        {
            Konekcija kon = new Konekcija();
          

            try
            {
                kon.OpenConnection();

                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon.NorthWindKonekcija();
                komanda.CommandType = CommandType.Text;
                komanda.Parameters.AddWithValue("@ProductID", productID);
                komanda.Parameters["@ProductID"].SqlDbType = SqlDbType.Int;

                komanda.CommandText =
                    @"SELECT [ProductID] ,[ProductName] ,[QuantityPerUnit],[UnitPrice], [UnitsInStock],[UnitsOnOrder],[ReorderLevel],[Discontinued],[SupplierID],[CategoryID]
                    FROM[NORTHWND].[dbo].[Products]
                    WHERE [ProductID] = @ProductID";

                SqlDataReader reader;

                Product product = new Product();
                reader = komanda.ExecuteReader();

                while (reader.Read())
                {
                    product.ProductID1 = (int)reader[0];
                    product.ProductName1 = reader[1].ToString();
                    product.QuantityPerUnit1 = reader[2].ToString();
                    product.UnitsInStock1 = (short)reader[3];
                    product.UnitsOnOrder1 = (short)reader[3];
                    product.ReorderLevel1 = (short)reader[4];
                    product.Discontinued1 = (bool)reader[5];
                    product.ReorderLevel1 = (short)reader[6];
                    product.UnitPrice1 = (int)reader[7];
                    product.CategoryID1 = (int)reader[8];
                    product.UnitPrice1 = (int)reader[9];


                }
               
                kon.CloseConnection();

                return product;
            }
            catch (Exception ex)
            {
             
                throw new Exception("Error ");
            }


        }



        public int UpdateProducts(Product product)
        {

            if (product == null)
            {
                throw new NullReferenceException();
            }
            int productId;

            try
            {

                Konekcija kon = new Konekcija();
                kon.OpenConnection();
                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon.NorthWindKonekcija();
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.CommandText = "UpdateProduct";
                komanda.Parameters.Add("@ProductID", SqlDbType.NVarChar).Value = product.ProductID1;
                komanda.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = product.ProductName1; 
                komanda.Parameters.Add("@ReorderLevel", SqlDbType.SmallInt).Value = product.ReorderLevel1;
                komanda.Parameters.Add("@QuantityPerUnit", SqlDbType.NVarChar).Value = product.QuantityPerUnit1;
                komanda.Parameters.Add("@UnitsInStock", SqlDbType.SmallInt).Value = product.UnitsInStock1;
                komanda.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = product.UnitPrice1;
                komanda.Parameters.Add("@UnitsOnOrder",  SqlDbType.SmallInt).Value = product.UnitsOnOrder1;
                komanda.Parameters.Add("@Discontinued", SqlDbType.Bit).Value = product.Discontinued1;
                komanda.Parameters.Add("@SupplierID", SqlDbType.Int).Value = product.SupplierID1;
                komanda.Parameters.Add("@CategoryID", SqlDbType.Int).Value = product.CategoryID1;
         


                productId = Convert.ToInt32(komanda.ExecuteScalar());
                kon.CloseConnection();
            }




            catch (Exception ex)
            {
                throw new Exception("Error ");
            }
            return productId;
        }
    }
    }

