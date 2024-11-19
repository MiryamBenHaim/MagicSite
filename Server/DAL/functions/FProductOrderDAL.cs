using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FProductOrderDAL : IProductOrderDAL
    {
        MagicalDBContext _MagicalDbContext;
        public FProductOrderDAL(MagicalDBContext magicalDbContext)
        {
            _MagicalDbContext = magicalDbContext;   
        }
        public int AddProductOrder(ProductOrderTbl productOrder)
        {
            try
            {
                _MagicalDbContext.ProductOrderTbls.Add(productOrder);   
                _MagicalDbContext.SaveChanges();
                return productOrder.PoId;
            }
            catch { return -1; }
        }

        public bool DeleteProductOrder(int productOrderId)
        {
            ProductOrderTbl productOrder = GetAllProductOrders().FirstOrDefault(j => j.PoId == productOrderId);
            try
            {
                _MagicalDbContext.ProductOrderTbls.Remove(productOrder);
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<ProductOrderTbl> GetAllProductOrders()
        {
            return _MagicalDbContext.ProductOrderTbls.Include(x => x.PoOrd).Include(x => x.PoProd).Include(x => x.PoCity).ToList();//.Include(x => x.PoColor).ToList();
        }

        public bool UpdateProductOrder(ProductOrderTbl productOrder)
        {
            try
            {
                _MagicalDbContext.ProductOrderTbls.FirstOrDefault(j => j.PoId == productOrder.PoId).PoCityId = productOrder.PoCityId;
                _MagicalDbContext.ProductOrderTbls.FirstOrDefault(j => j.PoId == productOrder.PoId).PoAddress = productOrder.PoAddress;
                _MagicalDbContext.ProductOrderTbls.FirstOrDefault(j => j.PoId == productOrder.PoId).PoOrdId = productOrder.PoOrdId;
                _MagicalDbContext.ProductOrderTbls.FirstOrDefault(j => j.PoId == productOrder.PoId).PoProdId = productOrder.PoProdId;
                _MagicalDbContext.ProductOrderTbls.FirstOrDefault(j => j.PoId == productOrder.PoId).PoNote = productOrder.PoNote;
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
