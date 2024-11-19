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
    public class CategoryProductBLL: ICategoryProductBLL
    {
        static IMapper _Mapper;
        ICategoryProductDAL _ICategoryProductDAL;

        public CategoryProductBLL(ICategoryProductDAL i)
        {
            _ICategoryProductDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }


        ////////////////////////////

        public bool AddCategoryProduct(CategoryProductDTO categoryProduct)
        {
            return _ICategoryProductDAL.AddCategoryProduct
                (_Mapper.Map<CategoryProductDTO, CategoryProductTbl>(categoryProduct));
        }

        public bool DeleteCategoryProduct(int categoryProductId)
        {
            return _ICategoryProductDAL.DeleteCategoryProduct(categoryProductId);
        }

        public List<CategoryProductDTO> GetAllCategoryProducts()
        {
            return _Mapper.Map<List<CategoryProductTbl>, List<CategoryProductDTO>>
                (_ICategoryProductDAL.GetAllCategoryProducts());
        }

        public bool UpdateCategoryProduct(CategoryProductDTO categoryProduct)
        {
            return _ICategoryProductDAL.UpdateCategoryProduct
                (_Mapper.Map< CategoryProductDTO, CategoryProductTbl>(categoryProduct));
        }
    }
}
