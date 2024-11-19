using BLL.interfaces;
using DTO.repository;
using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DTO;

namespace BLL.functions
{
    public class CategoryBLL : ICategoryBLL
    {
        static IMapper _Mapper;
        ICategoryDAL _ICategoryDAL;

        public CategoryBLL(ICategoryDAL  i)
        {
            _ICategoryDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }

        ////////////////////////////
        public bool AddCategory(CategoryDTO category)
        {
            return _ICategoryDAL.AddCategory
                (_Mapper.Map<CategoryDTO, CategoryTbl>(category));
        }

        public bool DeleteCategory(int categoryId)
        {
            return _ICategoryDAL.DeleteCategory(categoryId);
        }

        public List<CategoryDTO> GetAllCategories()
        {
            return _Mapper.Map<List<CategoryTbl>, List<CategoryDTO>>
                (_ICategoryDAL.GetAllCategories());
        }

        public bool UpdateCategory(CategoryDTO category)
        {
            return _ICategoryDAL.UpdateCategory
                (_Mapper.Map<CategoryDTO, CategoryTbl>(category));
        }

    }
}
