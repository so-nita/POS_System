using Microsoft.AspNetCore.Mvc;
using POS_WebAPI.Interface.ICategory;
using POS_WebAPI.Models;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.RequestModel.Category;

namespace POS_WebAPI.Controllers;

[ApiController] [Route("category")]
public class CategoryController : Controller
{
    private readonly ICategoryService _service;

    public CategoryController(ICategoryService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var data = _service.ReadAll();
        if(data!.Status!=(int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPost("getById")]
    public IActionResult GetById([FromBody] Key key)
    {
        var data = _service.Read(key);
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CategoryCreateReq req)
    {
        var data = _service.Create(req);
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPut]
    public IActionResult Update([FromBody] CategoryUpdateReq req)
    {
        var data = _service.Update(req);
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpDelete]
    public IActionResult Delete([FromBody] Key key)
    {
        var data = _service.Delete(key);
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }
}
