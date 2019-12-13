using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;
using System.Data.SqlClient;
using System.Data;

namespace DAL1.Interfaces.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        public int AddSupplier(Supplier supplier)
        {
            if (supplier == null)
            {
                throw new NullReferenceException();
            }
            int supplierID;

            try
            {

                Konekcija kon = new Konekcija();
                kon.OpenConnection();
                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon.NorthWindKonekcija();
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.CommandText = "AddSupplier";
                komanda.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = supplier.CompanyName1; ;
                komanda.Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = supplier.ContactName1;
                komanda.Parameters.Add("@ContactTitle", SqlDbType.NVarChar).Value = supplier.ContactTitle1;
                komanda.Parameters.Add("@Address", SqlDbType.NVarChar).Value = supplier.Address1;
                komanda.Parameters.Add("@City", SqlDbType.NVarChar).Value = supplier.City1;
                komanda.Parameters.Add("@Region", SqlDbType.NVarChar).Value = supplier.Region1;
                komanda.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = supplier.PostalCode1;
                komanda.Parameters.Add("@Fax ", SqlDbType.NVarChar).Value = supplier.Fax1;
                komanda.Parameters.Add("@HomePage ", SqlDbType.NVarChar).Value = supplier.HomePage1;
                komanda.Parameters.Add("@Country", SqlDbType.NVarChar).Value = supplier.Country1;
                komanda.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = supplier.Phone1;

                supplierID = Convert.ToInt32(komanda.ExecuteScalar());
                kon.CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding supplier");
            }
            return supplierID;
        }


        public int deleteSupplier(int supplierID)
        {
            Konekcija kon = new Konekcija();
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon.NorthWindKonekcija();
            komanda.CommandType = CommandType.StoredProcedure;
            komanda.CommandText = "DeleteSuppliers";
            komanda.Parameters.Add("@SupplierID", SqlDbType.Int).Value=supplierID;
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

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> listSupplier = new List<Supplier>();
            Konekcija kon = new Konekcija();
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon.NorthWindKonekcija();
            komanda.CommandText = "Select SupplierID,CompanyName  from Suppliers";
            kon.OpenConnection();
            SqlDataReader dr = komanda.ExecuteReader();

            while (dr.Read())
            {
                Supplier supplier = new Supplier();
                supplier.SupplierID1 = int.Parse(dr["SupplierID"].ToString());
                supplier.CompanyName1 = dr["CompanyName"].ToString();
                listSupplier.Add(supplier);

            }
            kon.CloseConnection();
            return listSupplier;
        }

        public Supplier GetSupplierByID(int supplierID)
        {
            Konekcija kon = new Konekcija();
            try
            {
                kon.OpenConnection();

                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon.NorthWindKonekcija();
                komanda.CommandType = CommandType.Text;
                komanda.Parameters.AddWithValue("@SupplierID", supplierID);
                komanda.Parameters["@SupplierId"].SqlDbType = SqlDbType.Int;

                komanda.CommandText =
                    @"SELECT [SupplierID] ,[CompanyName] ,[ContactName],[ContactTitle], [Address],[City],[Region],[PostalCode],[Country],[Phone],[Fax],[HomePage]
                    FROM[NORTHWND].[dbo].[Suppliers]
                    WHERE [SupplierID] = @SupplierID";

                SqlDataReader reader;

                Supplier supplier = new Supplier();
                reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    supplier.SupplierID1 = (int)reader[0];
                    supplier.CompanyName1 = reader[1].ToString();
                    supplier.ContactName1 = reader[2].ToString();
                    supplier.ContactTitle1 = reader[3].ToString();
                    supplier.Address1 = reader[4].ToString();
                    supplier.City1 = reader[5].ToString();
                    supplier.Region1 = reader[6].ToString();
                    supplier.PostalCode1 = reader[7].ToString();
                    supplier.Country1 = reader[8].ToString();
                    supplier.Phone1 = reader[9].ToString();
                    supplier.Fax1 = reader[10].ToString();
                    supplier.HomePage1 = reader[11].ToString();


                }

                kon.CloseConnection();

                return supplier;
            }
            catch (Exception ex)
            {

                throw new Exception("Error ");
            }

        }

        public int updateSupplier(Supplier supplier)
        {
            if (supplier == null)
            {
                throw new NullReferenceException();
            }
            int supplierID;

            try
            {

                Konekcija kon = new Konekcija();
                kon.OpenConnection();
                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon.NorthWindKonekcija();
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.CommandText = "UpdateSupplier";
                komanda.Parameters.Add("@SupplierID", SqlDbType.Int).Value = supplier.SupplierID1;
                komanda.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = supplier.CompanyName1;
                komanda.Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = supplier.ContactName1;
                komanda.Parameters.Add("@ContactTitle", SqlDbType.NVarChar).Value = supplier.ContactTitle1;
                komanda.Parameters.Add("@Address", SqlDbType.NVarChar).Value = supplier.Address1;
                komanda.Parameters.Add("@City", SqlDbType.NVarChar).Value = supplier.City1;
                komanda.Parameters.Add("@Region", SqlDbType.NVarChar).Value = supplier.Region1;
                komanda.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = supplier.PostalCode1;
                komanda.Parameters.Add("@Fax ", SqlDbType.NVarChar).Value = supplier.Fax1;
                komanda.Parameters.Add("@HomePage ", SqlDbType.NVarChar).Value = supplier.HomePage1;
                komanda.Parameters.Add("@Country", SqlDbType.NVarChar).Value = supplier.Country1;
                komanda.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = supplier.Phone1;


                supplierID = Convert.ToInt32(komanda.ExecuteScalar());
                kon.CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding supplier");
            }
            return supplierID;
        }
    }
}
