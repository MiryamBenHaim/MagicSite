using DAL.models;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface ICityBLL
    {
        List<CityDTO> GetAllCities();
        bool AddCity(CityDTO city);
        bool UpdateCity(CityDTO city);
        bool DeleteCity(int cityId);
    }
}
