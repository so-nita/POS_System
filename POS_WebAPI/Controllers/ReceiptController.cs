using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Services;

namespace POS_WebAPI.Controllers
{
    [ApiController]
    [Route("api/receipt")]
    public class ReceiptController : Controller
    {
        private readonly IReceitpService _service;

        public ReceiptController(IReceitpService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll ()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }
    }
}
