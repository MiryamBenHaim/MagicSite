using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FCityDAL : ICityDAL
    {
        MagicalDBContext _MagicalDbContext;
        public FCityDAL(MagicalDBContext magicalDbContext)
        {
            _MagicalDbContext = magicalDbContext;
        }
        public bool AddCity(CityTbl city)
        {
            try
            {
                _MagicalDbContext.CityTbls.Add(city);
                _MagicalDbContext.SaveChanges();

                return true;
            }
            catch { throw new Exception(); }
        }

        public bool DeleteCity(int cityId)
        {
            CityTbl city = _MagicalDbContext.CityTbls.FirstOrDefault(x => x.CityId == cityId);
            try
            {
                _MagicalDbContext.CityTbls.Remove(city);
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public List<CityTbl> GetAllCities()
        {
            return _MagicalDbContext.CityTbls.ToList();
        }

        public bool UpdateCity(CityTbl city)
        {
            try
            {
                //_MagicalDbContext.CityTbl.Update(city);
                _MagicalDbContext.CityTbls.FirstOrDefault(c=>c.CityId == city.CityId).CityName = city.CityName;
                _MagicalDbContext.CityTbls.FirstOrDefault(c=>c.CityId == city.CityId).CityShippPrice = city.CityShippPrice;
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }
    }
}
