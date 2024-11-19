using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IColorDAL
    {
        int AddColor(ColorTbl color);
        bool DeleteColor(int colorId);
        List<ColorTbl> GetAllColors();
        bool UpdateColor(ColorTbl color);
    }
}
