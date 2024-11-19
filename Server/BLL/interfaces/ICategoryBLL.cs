using DAL.models;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface ICategoryBLL
    {
        List<CategoryDTO> GetAllCategories();
        bool AddCategory(CategoryDTO category);
        bool UpdateCategory(CategoryDTO category);
        bool DeleteCategory(int categoryId);
    }
}
