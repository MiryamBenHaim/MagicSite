using DAL.models;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IUserBLL
    {
        List<UserDTO> GetAllUsers();
        UserDTO GetAllUserByEmailPass(string email, string pass);
        bool AddUser(UserDTO user); 
        bool UpdateUser(UserDTO user);  
        bool DeleteUser(int userId);
    }
}
