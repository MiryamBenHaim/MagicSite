using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FColorDAL : IColorDAL
    {
        MagicalDBContext _MagicalDbContext;
        public FColorDAL( MagicalDBContext magicalDbContext)
        {
            _MagicalDbContext = magicalDbContext;
        }
        public int AddColor(ColorTbl color)
        {
            try
            {
               _MagicalDbContext.Add(color);
                _MagicalDbContext.SaveChanges();
                return 0;//צריך להחזיר את קוד הצבע
            }
            catch { throw new Exception(); }
        }

        public bool DeleteColor(int colorId)
        {
            ColorTbl color = GetAllColors().FirstOrDefault(c=>c.ColorId == colorId);
            try
            {
                _MagicalDbContext.Remove(color);
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public List<ColorTbl> GetAllColors()
        {
            return _MagicalDbContext.ColorTbls.ToList();
        }

        public bool UpdateColor(ColorTbl color)
        {
            try
            {
                _MagicalDbContext.ColorTbls.FirstOrDefault(c => c.ColorId == color.ColorId).ColorName = color.ColorName;
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }
    }
}
