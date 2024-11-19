using BLL.interfaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicalSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOrderController : ControllerBase
    {
        IProductOrderBLL _IProductOrderBLL;

        public ProductOrderController(IProductOrderBLL i)
        {
            _IProductOrderBLL = i;
        }

        [HttpGet("GetAll")]
        public List<ProductOrderDTO> aa()
        {
            return _IProductOrderBLL.GetAllProductOrders();
        }

        [HttpGet("GetPOByUserId/{userId}")]
        public ActionResult<List<ProductOrderDTO>> bb(int userId)
        {
            return _IProductOrderBLL.GetPOByUserId(userId);
        }

        [HttpGet("GetPOByOrderId/{orderId}")]
        public ActionResult<List<ProductOrderDTO>> cc(int orderId)
        {
            return _IProductOrderBLL.GetPOByOrderId(orderId);
        }

        [HttpPut("AddProductOrder")]
        public ActionResult<int> dd(ProductOrderDTO productOrder)
        {
            return _IProductOrderBLL.AddProductOrder(productOrder);
        }

        [HttpPost("UpdateProductOrder")]
        public ActionResult<bool> ee(ProductOrderDTO productOrder)
        {
            return _IProductOrderBLL.UpdateProductOrder(productOrder);
        }

        [HttpDelete("DeleteProductOrder/{productOrderId}")]
        public ActionResult<bool> ff(int productOrderId)
        {
            return _IProductOrderBLL.DeleteProductOrder(productOrderId);
        }

    }
}
