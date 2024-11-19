using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FPictureDAL: IPictureDAL
    {
        MagicalDBContext _MagicalDBContext;
        public FPictureDAL(MagicalDBContext magicalDBContext)
        {
            _MagicalDBContext = magicalDBContext;
        }

        public bool AddPicture(PictureTbl picture)
        {
            try
            {
                _MagicalDBContext.PictureTbls.Add(picture);
                _MagicalDBContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public bool DeletePicture(int pictureId)
        {
            PictureTbl picture = GetAllPictures().FirstOrDefault(p => p.PicId == pictureId);
            try
            {
                _MagicalDBContext.PictureTbls.Remove(picture);
                _MagicalDBContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public List<PictureTbl> GetAllPictures()
        {
            return _MagicalDBContext.PictureTbls.Include(h => h.PicProd).ToList(); //Include(c => c.PicColor)
        }

        public bool UpdatePicture(PictureTbl picture)
        {
            try
            {
                _MagicalDBContext.PictureTbls.FirstOrDefault(p => p.PicId == picture.PicId).PicProdId = picture.PicProdId;
               // _MagicalDBContext.PictureTbls.FirstOrDefault(p => p.PicId == picture.PicId).PicColorId = picture.PicColorId;
                _MagicalDBContext.SaveChanges();
                return true;
            }
            catch { throw new Exception();}
        }
    }
}
