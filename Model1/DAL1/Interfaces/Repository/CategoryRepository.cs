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
    public class CategoryRepository : ICategoryRepository
    {
        public int AddCategory(Categories categories)
        {
            Konekcija kon = new Konekcija();
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon.NorthWindKonekcija();
            komanda.CommandType = CommandType.StoredProcedure;
            komanda.CommandText = "AddCategory1";
            komanda.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = categories.CategoryName;
            komanda.Parameters.Add("@Description", SqlDbType.NText).Value = categories.Description;
            komanda.Parameters.Add("@Picture", SqlDbType.Image).Value = categories.Picture;
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

        public int DeleteCategory(int categoryID)
        {
            Konekcija kon = new Konekcija();
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon.NorthWindKonekcija();
            komanda.CommandType = CommandType.StoredProcedure;
            komanda.CommandText = "DeleteCategory";
            komanda.Parameters.Add("@CategoryID", SqlDbType.Int);
            komanda.Parameters["@CategoryID"].Value = categoryID;
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

        public List<Categories> GetAllCategories()
        {
            List<Categories> listaKategorija = new List<Categories>();
            Konekcija kon = new Konekcija();
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon.NorthWindKonekcija();
            komanda.CommandText = "Select CategoryID,CategoryName  from Categories";
            kon.OpenConnection();
            SqlDataReader dr = komanda.ExecuteReader();
            while (dr.Read())
            {
                Categories category = new Categories();
                category.CategoryID = int.Parse(dr["CategoryID"].ToString());
                category.CategoryName = dr["CategoryName"].ToString();
                listaKategorija.Add(category);
            }
            kon.CloseConnection();
            return listaKategorija;
        }



        public Categories GetCategoryById(int categoryid)
        {
            Konekcija kon = new Konekcija();


            try
            {
                kon.OpenConnection();

                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon.NorthWindKonekcija();
                komanda.CommandType = CommandType.Text;
                komanda.Parameters.AddWithValue("@categoryId", categoryid);
                komanda.Parameters["@categoryId"].SqlDbType = SqlDbType.Int;

                komanda.CommandText =
                    @"SELECT [CategoryID] ,[CategoryName] ,[Description],[Picture] 
                    FROM[NORTHWND].[dbo].[Categories]
                    WHERE [CategoryID] = @categoryId";

                SqlDataReader reader;

                Categories category = new Categories();
                reader = komanda.ExecuteReader();

                while (reader.Read())
                {
                    category.CategoryID = (int)reader[0];
                    category.CategoryName = reader[1].ToString();
                    category.Description = reader[2].ToString();
                    category.Picture = (byte[])reader[3];

                }

                kon.CloseConnection();

                return category;
            }
            catch (Exception ex)
            {

                throw new Exception("Error");
            }


        }

        public int UpdateCategory(Categories categories)
        {
            if (categories == null)
            {
                throw new NullReferenceException();
            }
            int categoryID;

            try
            {

                Konekcija kon = new Konekcija();
                kon.OpenConnection();
                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon.NorthWindKonekcija();
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.CommandText = "UpdateCategory";
                komanda.Parameters.Add("@CategoryID", SqlDbType.NVarChar).Value = categories.CategoryID;
                komanda.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = categories.CategoryName;
                komanda.Parameters.Add("@Description", SqlDbType.NText).Value = categories.Description;
                komanda.Parameters.Add("@Picture", SqlDbType.Image).Value = categories.Picture;
                categoryID = Convert.ToInt32(komanda.ExecuteScalar());
                kon.CloseConnection();

            }
            catch (Exception ex)
            {
                throw new Exception("Error while updating category to db");
            }
            return categoryID;
        }
    }
}


