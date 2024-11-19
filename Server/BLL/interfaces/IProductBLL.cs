using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IProductBLL
    {
        List<ProductDTO> GetAllProducts();
        List<CategoryProductDTO> GetProductsByCategoryId(int categoryId);
        bool AddProduct(ProductDTO product);
        bool UpdateProduct(ProductDTO product);
        bool DeleteProduct(int productId);
        //bool ProductInStack(int productId, int colerId); 
    }
}
