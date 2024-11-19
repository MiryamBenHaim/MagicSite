using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FCategoryProductDAL : ICategoryProductDAL
    {
        MagicalDBContext _MagicalDbContext;
        public FCategoryProductDAL(MagicalDBContext magicalDbContext)
        {
            _MagicalDbContext = magicalDbContext;
        }

        public bool AddCategoryProduct(CategoryProductTbl categoryProduct)
        {
            try
            {
                _MagicalDbContext.CategoryProductTbls.Add(categoryProduct);
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public bool DeleteCategoryProduct(int categoryProductId)
        {
            CategoryProductTbl categoryProduct = GetAllCategoryProducts().FirstOrDefault(cp=>cp.CpId == categoryProductId); 
            try
            {
                _MagicalDbContext.CategoryProductTbls.Remove(categoryProduct);
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public List<CategoryProductTbl> GetAllCategoryProducts()
        {
            return _MagicalDbContext.CategoryProductTbls.ToList();
        }

        public bool UpdateCategoryProduct(CategoryProductTbl categoryProduct)
        {
            try
            {
               // _MagicalDbContext.CategoryProductTbls.FirstOrDefault(cp=>cp.CpId == categoryProduct.CpId).CpProdId = categoryProduct.CpProdId; 
                _MagicalDbContext.CategoryProductTbls.FirstOrDefault(cp=>cp.CpId== categoryProduct.CpId).CpCatId = categoryProduct.CpCatId;  
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }
    }
}
