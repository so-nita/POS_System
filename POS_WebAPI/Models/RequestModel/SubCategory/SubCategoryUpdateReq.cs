using POS_WebAPI.Interface.IService;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.SubCategory
{
    public class SubCategoryUpdateReq : IUpdateReq
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; } = null!;
        public string? Main_Category_Id { get; set; } = null!;
        public string? Image { get; set; }
        public string? Description { get; set; }
        public Status? Status { get; set; }
    }
}