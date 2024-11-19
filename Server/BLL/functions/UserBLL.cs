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
    public class UserBLL: IUserBLL
    {
        static IMapper _Mapper;
        IUserDAL _IUserDAL;

        public UserBLL(IUserDAL i)
        {
            _IUserDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }

        ////////////////////

        public bool AddUser(UserDTO user)
        {
            return _IUserDAL.AddUser
                (_Mapper.Map<UserDTO, UserTbl>(user));
        }

        public bool DeleteUser(int userId)
        {
            return _IUserDAL.DeleteUser(userId);
        }

        public UserDTO GetAllUserByEmailPass(string email, string pass)
        {
            return _Mapper.Map<UserTbl, UserDTO>(_IUserDAL.GetAllUsers()
                .FirstOrDefault(x => x.UserEmail == email && x.UserPass == pass));
        }

        public List<UserDTO> GetAllUsers()
        {
            return _Mapper.Map < List<UserTbl>, List<UserDTO>>
                (_IUserDAL.GetAllUsers());
        }

        public bool UpdateUser(UserDTO user)
        {
            return _IUserDAL.UpdateUser
                (_Mapper.Map<UserDTO, UserTbl>(user));
        }
    }
}
