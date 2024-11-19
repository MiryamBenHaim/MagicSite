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
    public class PictureBLL : IPictureBLL
    {
        IMapper _Mapper;
        IPictureDAL _IPictureDAL;
        public PictureBLL(IPictureDAL iPictureDAL)
        {
            _IPictureDAL = iPictureDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }
        public bool AddPicture(PictureDTO picture)
        {
           return _IPictureDAL.AddPicture(_Mapper.Map<PictureDTO, PictureTbl>(picture));
        }

        public bool DeletePicture(int pictureId)
        {
            return _IPictureDAL.DeletePicture(pictureId);
        }

        public List<PictureDTO> GetAllPictures()
        {
            return _Mapper.Map<List<PictureTbl>, List<PictureDTO>>(_IPictureDAL.GetAllPictures());
        }

        public bool UpdatePicture(PictureDTO picture)
        {
            return _IPictureDAL.UpdatePicture(_Mapper.Map<PictureDTO, PictureTbl>(picture));
        }
    }
}
