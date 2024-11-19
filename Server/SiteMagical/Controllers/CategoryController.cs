using BLL.interfaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicalSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        
        ICategoryBLL _ICategoryBLL;
        public CategoryController(ICategoryBLL i)
        {
            _ICategoryBLL = i; 
        }
        [HttpPut("AddCategory")]
        public bool AddCategory(CategoryDTO category)
        {
            return _ICategoryBLL.AddCategory(category);
        }
        [HttpPost("Update")]
        public bool UpdateCategory(CategoryDTO category) 
        {
            return _ICategoryBLL.UpdateCategory(category); 

        }
        [HttpDelete("Delete")]
        public bool DeleteCategory(int id)
        {
            return _ICategoryBLL.DeleteCategory(id);


        }
        [HttpGet("getAll")]
        public List<CategoryDTO> GetCategory()
        {
            return _ICategoryBLL.GetAllCategories();
        }
    }
}
