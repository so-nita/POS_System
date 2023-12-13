using POS_WebAPI.Interface.IService;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.Product;

public class ProductUpdateReq : IUpdateReq
{
    public string Id { get; set; } = null!;
    public string? Code { get; set; } = null!;
    public string? Name { get; set; } = null!;
    public string? NameKh { get; set; } = null!;
    public string? Company { get; set; } = null!;
    public string? SubCategory { get; set; } = null!;
    public string? Image { get; set; } = null!;
    public decimal? Cost { get; set; }
    public decimal? Price { get; set; }
    public string? Description { get; set; }
    public Status? Status { get; set; }
}
