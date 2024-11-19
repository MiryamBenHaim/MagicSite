using BLL.interfaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicalSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        ICityBLL _cityBll;
    public CityController(ICityBLL i) { 
        _cityBll = i;
        }
        [HttpGet("Get")]    
        public ActionResult<List<CityDTO>> GetCity()
        {
            return Ok(_cityBll.GetAllCities()); 
        }
        [HttpPost("Add")]
        public ActionResult<bool> AddCity(CityDTO city)
        {
            return Ok(_cityBll.AddCity(city));
        }
        [HttpPut("Update")]
        public ActionResult<bool> UpdateCity(CityDTO city)
        {
            return Ok(_cityBll.UpdateCity(city));
        }
        [HttpDelete("Delete/{idC}")]
        public ActionResult<bool> DeleteCity(int idC)
        {
            return Ok(_cityBll.DeleteCity(idC));
        }
    }
}
