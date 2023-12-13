using POS_WebAPI.Interface.IService;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.Models.RequestModel.Company;

public class CompanyUpdateReq : IUpdateReq
{
    public string Id { get; set; } = null!;
    public string? Name { get; set; } = null!;
    public string? Email { get; set; } = null!;
    public string? Contact { get; set; } = null!;
    public string? System_Id { get; set; } = null!;
    public string? Image { get; set; } = null!;
    public string? Website { get; set; }
    public string? Address { get; set; } = null!;
    public Status? Status { get; set; }
}
