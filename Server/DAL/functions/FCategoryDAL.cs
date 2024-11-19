using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FCategoryDAL : ICategoryDAL
    {
        MagicalDBContext _MagicalDbContext;
        public FCategoryDAL(MagicalDBContext magicalDbContext)
        {
            _MagicalDbContext = magicalDbContext;
        }
        public bool AddCategory(CategoryTbl category)
        {
            try
            {
                _MagicalDbContext.CategoryTbls.Add(category);
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteCategory(int categoryId)
        {
            CategoryTbl category = GetAllCategories().FirstOrDefault(c=>c.CatId == categoryId);
            try
            {
                _MagicalDbContext.CategoryTbls.Remove(category);
                _MagicalDbContext.SaveChanges();    
                return true;
            }
            catch { return false; }
        }

        public List<CategoryTbl> GetAllCategories()
        {
            return _MagicalDbContext.CategoryTbls.ToList();
        }

        public bool UpdateCategory(CategoryTbl category)
        {
            try
            {
                _MagicalDbContext.CategoryTbls.FirstOrDefault(c => c.CatId == category.CatId).CatName = category.CatName;
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch {
                return false; }
        }
    }
}
