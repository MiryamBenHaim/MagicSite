using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class FUserDAL : IUserDAL
    {
        MagicalDBContext _MagicalDbContext;
        public FUserDAL(MagicalDBContext magicalDbContext)
        {
            _MagicalDbContext = magicalDbContext;
        }
        public bool AddUser(UserTbl user)
        {
            try 
            {
                _MagicalDbContext.UserTbls.Add(user);
                _MagicalDbContext.SaveChanges();
                return true;
  //----------SqlException: Cannot insert explicit value for identity column in table 'UserTbl'
 //    when IDENTITY_INSERT is set to OFF
            } 
            catch { throw new Exception(); }
        }

        public bool DeleteUser(int userId)
        {
            UserTbl user = GetAllUsers().FirstOrDefault(x => x.UserId == userId);
            try
            {
                _MagicalDbContext.UserTbls.Remove(user);
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }

        public List<UserTbl> GetAllUsers()
        {
            return _MagicalDbContext.UserTbls.ToList();
        }

        public bool UpdateUser(UserTbl user)
        {
            try
            {
                _MagicalDbContext.UserTbls.FirstOrDefault(x => x.UserId == user.UserId).UserName = user.UserName;
                _MagicalDbContext.UserTbls.FirstOrDefault(x => x.UserId == user.UserId).UserAddress = user.UserAddress;
                _MagicalDbContext.UserTbls.FirstOrDefault(x => x.UserId == user.UserId).UserPass = user.UserPass;
                _MagicalDbContext.UserTbls.FirstOrDefault(x => x.UserId == user.UserId).UserPhone = user.UserPhone;
                _MagicalDbContext.SaveChanges();
                return true;
            }
            catch { throw new Exception(); }
        }
    }
}
