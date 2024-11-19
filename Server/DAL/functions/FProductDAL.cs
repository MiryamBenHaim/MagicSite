using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FProductDAL : IProductDAL
    {
        MagicalDBContext _MagicalDBContex;
        public FProductDAL(MagicalDBContext magicalDBContex)
        {
            _MagicalDBContex = magicalDBContex;
        }
        public bool AddProduct(ProductTbl product)
        {
            try
            {
                _MagicalDBContex.ProductTbls.Add(product);
                _MagicalDBContex.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public bool DeleteProduct(int productId)
        {
            ProductTbl product = GetAllProducts().FirstOrDefault(j=>j.ProdId == productId);
            try
            {
                _MagicalDBContex.ProductTbls.Remove(product);    
                _MagicalDBContex.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public List<ProductTbl> GetAllProducts()
        {
            return _MagicalDBContex.ProductTbls.ToList();
        }

        public bool UpdateProduct(ProductTbl product)
        {
            try
            {
                _MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdName = product.ProdName;
                _MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdDesc = product.ProdDesc;
                _MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdPrice = product.ProdPrice;
                _MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdQty = product.ProdQty;
                _MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdInStack = product.ProdInStack;
                _MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdStatus = product.ProdStatus;
                _MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdInSale = product.ProdInSale;
                _MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdSalePrice = product.ProdSalePrice;
                //_MagicalDBContex.ProductTbls.FirstOrDefault(j => j.ProdId == product.ProdId).ProdPic = product.ProdPic;
                _MagicalDBContex.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }
    }
}
