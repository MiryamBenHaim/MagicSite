using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IProductDAL
    {
        List<ProductTbl> GetAllProducts();
        bool AddProduct(ProductTbl product);
        bool UpdateProduct(ProductTbl product); 
        bool DeleteProduct(int productId);
    }
}
