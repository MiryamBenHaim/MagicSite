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
    public class CityBLL : ICityBLL
    {
        static IMapper _Mapper;
        ICityDAL _ICityDAL;

        public CityBLL(ICityDAL i)
        {
            _ICityDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }

        public bool AddCity(CityDTO city)
        {
            return _ICityDAL.AddCity
                (_Mapper.Map< CityDTO, CityTbl>(city));
        }

        public bool DeleteCity(int cityId)
        {
            return _ICityDAL.DeleteCity(cityId);
        }

        public List<CityDTO> GetAllCities()
        {
            return _Mapper.Map< List<CityTbl>, List<CityDTO>>
                (_ICityDAL.GetAllCities());
        }

        public bool UpdateCity(CityDTO city)
        {
            ////////
            return _ICityDAL.UpdateCity
                (_Mapper.Map< CityDTO, CityTbl>(city));
        }
    }
}
