using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.Category
{
    public class CategoryCreateReq : ICreateReq
    {
        public string Name { get; set; } = null!;
        public string? Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public Status Status { get; set; }
    }
}
