using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface ICityDAL
    {
        List<CityTbl> GetAllCities();
        bool AddCity(CityTbl city);
        bool UpdateCity(CityTbl city);
        bool DeleteCity(int cityId);
    }
}
