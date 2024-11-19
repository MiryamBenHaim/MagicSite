using BLL.interfaces;
using DAL.models;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicalSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBLL _userBll;
        public UserController(IUserBLL userBll)
        {
            _userBll = userBll;
        }

        [HttpGet("Get")]
        public ActionResult<List<UserDTO>> GetUsers() 
        { 
            return Ok(_userBll.GetAllUsers());  
        }
        [HttpGet("Get/{email}/{pass}")]
        public ActionResult<List<UserDTO>> GetUsersBy(string email, string pass)
        {
            return Ok(_userBll.GetAllUserByEmailPass(email, pass));
        }
        [HttpDelete("User/Delete/{id}")]
        public ActionResult<bool> DeleteUsersBy(int id)
        {
            return Ok(_userBll.DeleteUser(id));
        }

        [HttpPost("Add")]
        public ActionResult<bool> AddUser(UserDTO user)
        {
            return Ok(_userBll.AddUser(user));
        }
        [HttpPut("Update")]
        public ActionResult<bool> GetUsersBy(UserDTO user)
        {
            return Ok(_userBll.UpdateUser(user));
        }
    }
}
