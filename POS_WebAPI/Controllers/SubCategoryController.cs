using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using POS_WebAPI.Interface.ISubCategory;
using POS_WebAPI.Models;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.SubCategory;

namespace POS_WebAPI.Controllers
{
    [ApiController] [Route("subcategory")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _service;

        public SubCategoryController(ISubCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ReadAll()
        {
            var data = _service.ReadAll();
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost("getById")]
        public IActionResult Read([FromBody] Key key)
        {
            var data = _service.Read(key);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SubCategoryCreateReq req)
        {
            var data = _service.Create(req);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SubCategoryUpdateReq req)
        {
            var data = _service.Update(req);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpDelete]
        public IActionResult Delete(Key key)
        {
            var data = _service.Delete(key);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
