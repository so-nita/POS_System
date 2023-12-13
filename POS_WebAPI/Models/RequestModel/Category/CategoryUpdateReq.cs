using POS_WebAPI.Interface.IService;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.Category
{
    public class CategoryUpdateReq : IUpdateReq
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; } = null!;
        public string? Image { get; set; }
        public string? Description { get; set; }
        public Status? Status { get; set; }
    }
}
