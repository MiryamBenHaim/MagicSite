using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FOrdersDAL : IOrdersDAL
    {
        MagicalDBContext _MagicalDbContext;
        public FOrdersDAL(MagicalDBContext magicalDbContext)
        {
            _MagicalDbContext = magicalDbContext;
        }

        public int AddOrder(OrdersTbl order)
        {
            try
            {
                _MagicalDbContext.OrdersTbls.Add(order);
                _MagicalDbContext.SaveChanges();
                return order.OrdId;
            }
            catch { return -1; }
        }

        public bool DeleteOrder(int orderId)
        {
            OrdersTbl order = GetAllOrders().FirstOrDefault(j=>j.OrdId == orderId);
            try
            {
                _MagicalDbContext.OrdersTbls.Remove(order);
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { return false; }    
        }

        public List<OrdersTbl> GetAllOrders()
        {
            return _MagicalDbContext.OrdersTbls.Include(x =>x.OrdUser).ToList();
        }

        public bool UpdateOrder(OrdersTbl order)
        {
            try
            {
                _MagicalDbContext.OrdersTbls.FirstOrDefault(j=>j.OrdId == order.OrdId).OrdUserId = order.OrdUserId; 
                _MagicalDbContext.OrdersTbls.FirstOrDefault(j=> j.OrdId == order.OrdId).OrdDate = order.OrdDate;
                _MagicalDbContext.OrdersTbls.FirstOrDefault(j=> j.OrdId == order.OrdId).OrdStatus = order.OrdStatus; 
                _MagicalDbContext.OrdersTbls.FirstOrDefault(j=> j.OrdId == order.OrdId).OrdDateSend = order.OrdDateSend; 
                _MagicalDbContext.OrdersTbls.FirstOrDefault(k=>k.OrdId == order.OrdId).OrdTotalPayment = order.OrdTotalPayment;
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
