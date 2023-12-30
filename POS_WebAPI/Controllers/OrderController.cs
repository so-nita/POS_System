using Microsoft.AspNetCore.Mvc;
using POS_WebAPI.Interface;
using POS_WebAPI.Models;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.RequestModel.Order;
using POS_WebAPI.Services;

namespace POS_WebAPI.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : Controller
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.ReadAll();
            if(data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderCreateReq request)
        {
            var data = _service.Create(request);
            if(data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Put([FromBody] OrderUpdateReq request)
        {
            var data = _service.Update(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] OrderDeleteReq key)
        {
            var data = _service.Delete(key);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
