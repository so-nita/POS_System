using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class Category
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool Is_Deleted { get; set; }
        // 
        public ICollection<SubCategory>? SubCategories { get; set; }
    }
}
