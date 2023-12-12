using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.Company;

public class CompanyResponse : IResponse
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Email { get; set; } = null!;
    public string Contact { get; set; } = null!;
    public string System_Id { get; set; } = null!;
    public string? System_Name { get; set; } = null!;
    public string? Image { get; set; } = null!;
    public string? Website { get; set; }
    public string Address { get; set; } = null!;
    public DateTime Create_At { get; set; }
    public string Status { get; set; } = null!;
    public bool? Is_Deleted { get; set; }
}