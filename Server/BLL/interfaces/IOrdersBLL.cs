using DAL.models;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IOrdersBLL
    {
        List<OrdersDTO> GetAllOrders();
        int AddOrder(OrdersDTO order);
        bool UpdateOrder(OrdersDTO order);
        bool DeleteOrder(int orderId);
    }
}
