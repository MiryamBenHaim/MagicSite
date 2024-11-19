using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IPictureBLL
    {
        bool AddPicture(PictureDTO picture);
        bool DeletePicture(int pictureId);
        List<PictureDTO> GetAllPictures();
        bool UpdatePicture(PictureDTO picture);
    }
}
