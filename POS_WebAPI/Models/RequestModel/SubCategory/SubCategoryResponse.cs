using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.Models.RequestModel.SubCategory
{
    public class SubCategoryResponse : IResponse
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Main_Category_Id { get; set; } = null!;
        public string Main_Category_Name { get; set; } = null!; 
        public string? Image { get; set; }
        public string? Description { get; set; }
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool Is_Deleted { get; set; }
    }
}