using DAL.models;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface ICategoryProductBLL
    {
        List<CategoryProductDTO> GetAllCategoryProducts();
        bool AddCategoryProduct(CategoryProductDTO categoryProduct);
        bool UpdateCategoryProduct(CategoryProductDTO categoryProduct);
        bool DeleteCategoryProduct(int categoryProductId);
    }
}
