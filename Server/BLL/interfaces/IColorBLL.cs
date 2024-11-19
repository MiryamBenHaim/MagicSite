using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IColorBLL
    {
        bool DeleteColor(int colorId);
        List<ColorDTO> GetAllColors();
    }
}
