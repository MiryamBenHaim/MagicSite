using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IPictureDAL
    {
        bool AddPicture(PictureTbl picture);
        bool DeletePicture(int pictureId);
        List<PictureTbl> GetAllPictures();
        bool UpdatePicture(PictureTbl picture);
    }
}
