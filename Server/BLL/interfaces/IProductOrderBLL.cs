using DAL.models;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IProductOrderBLL
    {
        List<ProductOrderDTO> GetAllProductOrders();
        int AddProductOrder(ProductOrderDTO productOrder);
        bool UpdateProductOrder(ProductOrderDTO productOrder);
        bool DeleteProductOrder(int productOrderId);
        List<ProductOrderDTO> GetPOByUserId(int userId);
        List<ProductOrderDTO> GetPOByOrderId(int orderId);
    }
}
