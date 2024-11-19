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
    public class ProductBLL : IProductBLL
    {
        static IMapper _Mapper;
        IProductDAL _IProductDAL;
        ICategoryProductDAL _ICategoryProductDAL;

        public ProductBLL(IProductDAL iProductDAL, ICategoryProductDAL iCategoryProductDAL)
        {
            _IProductDAL = iProductDAL;
            _ICategoryProductDAL = iCategoryProductDAL;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }

        ////////////////////////
        public bool AddProduct(ProductDTO product)
        {
            return _IProductDAL.AddProduct
                (_Mapper.Map<ProductDTO, ProductTbl>(product));
        }

        public bool DeleteProduct(int productId)
        {
            return _IProductDAL.DeleteProduct(productId);
        }

        public List<ProductDTO> GetAllProducts()
        {
            return _Mapper.Map< List<ProductTbl>, List<ProductDTO>>
                (_IProductDAL.GetAllProducts());
        }

        public List<CategoryProductDTO> GetProductsByCategoryId(int categoryId)
        {
            return _Mapper.Map<List<CategoryProductTbl>, List<CategoryProductDTO>>
                (_ICategoryProductDAL.GetAllCategoryProducts().Where(x => x.CpCatId == categoryId).ToList());
        }

        public bool UpdateProduct(ProductDTO product)
        {
            return _IProductDAL.UpdateProduct
                ( _Mapper.Map<ProductDTO, ProductTbl>(product));
        }
    }
}
