using BLL.interfaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicalSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrdersBLL _IOrdersBLL;

        public OrderController(IOrdersBLL i)
        {
            _IOrdersBLL = i;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<OrdersDTO>> aa()
        {
            return Ok(_IOrdersBLL.GetAllOrders());
        }

        [HttpPut("AddOrder")]
        public ActionResult<int> bb(OrdersDTO order)
        {
            return _IOrdersBLL.AddOrder(order);
        }

        [HttpPost("UpdateOrder")]
        public ActionResult<bool> cc(OrdersDTO order)
        {
            return _IOrdersBLL.UpdateOrder(order);
        }

        [HttpDelete("DeleteOrder/{orderId}")]
        public ActionResult<bool> dd(int orderId)
        {
            return _IOrdersBLL.DeleteOrder(orderId);
        }
    }
}
