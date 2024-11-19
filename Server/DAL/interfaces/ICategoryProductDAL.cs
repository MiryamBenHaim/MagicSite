using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface ICategoryProductDAL
    {
        bool AddCategoryProduct(CategoryProductTbl categoryProduct);
        bool DeleteCategoryProduct(int categoryProductId);
        List<CategoryProductTbl> GetAllCategoryProducts();
        bool UpdateCategoryProduct(CategoryProductTbl categoryProduct);
    }
}
