using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.SubCategory
{
    public class SubCategoryCreateReq : ICreateReq
    {
        public string Name { get; set; } = null!;
        public string? Image { get; set; }
        public string Main_Category_Id { get; set; } = null!;
        public string? Description { get; set; }
        public Status Status { get; set; }
    }
}