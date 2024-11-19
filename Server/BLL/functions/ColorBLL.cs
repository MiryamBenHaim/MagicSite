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
    public class ColorBLL : IColorBLL
    {
        IMapper _Mapper;
        IColorDAL _IColorDAL;
        public ColorBLL(IColorDAL colorDAL)
        {
            _IColorDAL = colorDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }
        public bool DeleteColor(int colorId)
        {
            try
            {
                _IColorDAL.DeleteColor(colorId);
                return true;
            }
            catch { throw new Exception(); }
        }

        public List<ColorDTO> GetAllColors()
        {
            return _Mapper.Map<List<ColorTbl>, List<ColorDTO>>(_IColorDAL.GetAllColors());
        }
    }
}
