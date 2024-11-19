using AutoMapper;
using BLL.interfaces;
using DAL.interfaces;
using DAL.models;
using DTO;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.functions
{
    public class ProductOrderBLL: IProductOrderBLL
    {
        static IMapper _Mapper;
        IProductOrderDAL _IProductOrderDAL;
        IColorDAL _IColorDAL;

        public ProductOrderBLL(IProductOrderDAL iProductOrderDAL, IColorDAL iColorDAL)
        {
            _IProductOrderDAL = iProductOrderDAL;
            _IColorDAL = iColorDAL;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }

        ////////////////////////

        public int AddProductOrder(ProductOrderDTO productOrder)
        {
            //to check what will be here!
            if(productOrder.PoCityId == 0)
                return -1;
            if(productOrder.ProdColorId == 0)
            {
               
              //  ColorTbl newColor = new ColorTbl() { ColorName = productOrder.ColorName };
             //   productOrder.ProdColorId = _IColorDAL.AddColor(newColor);
            }
            return _IProductOrderDAL.AddProductOrder
                (_Mapper.Map<ProductOrderDTO, ProductOrderTbl>(productOrder));
        }

        public bool DeleteProductOrder(int productOrderId)
        {
            return _IProductOrderDAL.DeleteProductOrder(productOrderId);
        }

        public bool UpdateProductOrder(ProductOrderDTO productOrder)
        {
            return _IProductOrderDAL.UpdateProductOrder
                (_Mapper.Map<ProductOrderDTO, ProductOrderTbl>(productOrder));
        }

        public List<ProductOrderDTO> GetAllProductOrders()
        {
            return _Mapper.Map<List<ProductOrderTbl>, List<ProductOrderDTO>>
                (_IProductOrderDAL.GetAllProductOrders());
        }

        public List<ProductOrderDTO> GetPOByUserId(int userId)
        {
            return _Mapper.Map<List<ProductOrderTbl>, List<ProductOrderDTO>>
                (_IProductOrderDAL.GetAllProductOrders().Where(x=>x.PoUserId==userId).ToList()); 
        }

        public List<ProductOrderDTO> GetPOByOrderId(int orderId)
        {
            return _Mapper.Map<List<ProductOrderTbl>, List<ProductOrderDTO>>
                (_IProductOrderDAL.GetAllProductOrders().Where(x => x.PoOrdId == orderId).ToList());
        }

    }
}
