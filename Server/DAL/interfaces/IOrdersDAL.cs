using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IOrdersDAL
    {
        List<OrdersTbl> GetAllOrders();
        int AddOrder(OrdersTbl order);
        bool UpdateOrder(OrdersTbl order);
        bool DeleteOrder(int orderId);
    }
}
