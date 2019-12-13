using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;


namespace DAL1.Interfaces
{
   public interface ICategoryRepository
    {
        List<Categories> GetAllCategories();
        Categories GetCategoryById(int categoryid);
        int AddCategory(Categories categories);
        int UpdateCategory(Categories categories);
        int DeleteCategory(int categoryID);
    }
}
