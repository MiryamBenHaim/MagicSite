using BLL.interfaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicalSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductBLL _productBll;
        public ProductController(IProductBLL productBll)
        {
            _productBll = productBll;
        }
        [HttpGet("Get")]
        public ActionResult<List<ProductDTO>> GetProdect() 
        {
            return Ok(_productBll.GetAllProducts());    
        }
        [HttpGet("Get/{idCat}")]
        public ActionResult<List<ProductDTO>> GetProdectByCat(int idCat)
        {
            return Ok(_productBll.GetProductsByCategoryId(idCat));
        }
        [HttpDelete("Delete/{id}")]
        public ActionResult<bool> DeleteProdect(int id)
        {
            return Ok(_productBll.DeleteProduct(id));
        }
        [HttpPost("Add")]
        public ActionResult<bool> AddProdect(ProductDTO p)
        {
            return Ok(_productBll.AddProduct(p));
        }
        [HttpPut("Update")]
        public ActionResult<bool> UpdateProdect(ProductDTO p)
        {
            return Ok(_productBll.UpdateProduct(p));
        }
    }
}
