using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1
{
    class Konekcija
    {
        SqlConnection kon;
        public Konekcija()
        {
            kon = new SqlConnection(@"Data Source=(local)\SqlExpress;Initial Catalog=NORTHWND;Integrated Security=True");
        }
        public SqlConnection NorthWindKonekcija()
        {
            return kon;
        }
        public void OpenConnection()
        {
            kon.Open();
        }
        public void CloseConnection()
        {
            kon.Close();
        }
    }
}
