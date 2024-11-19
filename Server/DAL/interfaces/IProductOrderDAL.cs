using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IProductOrderDAL
    {
        List<ProductOrderTbl> GetAllProductOrders();
        int AddProductOrder(ProductOrderTbl productOrder);
        bool UpdateProductOrder(ProductOrderTbl productOrder);
        bool DeleteProductOrder(int productOrderId);
    }
}
