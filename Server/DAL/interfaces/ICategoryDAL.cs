using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface ICategoryDAL
    {
        List<CategoryTbl> GetAllCategories();
        bool AddCategory(CategoryTbl category);
        bool UpdateCategory( CategoryTbl category);
        bool DeleteCategory(int categoryId);
    }
}
