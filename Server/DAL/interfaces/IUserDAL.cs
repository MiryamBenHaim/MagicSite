using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IUserDAL
    {
        List<UserTbl> GetAllUsers();
        bool AddUser(UserTbl user); 
        bool UpdateUser(UserTbl user);  
        bool DeleteUser(int userId);
    }
}
