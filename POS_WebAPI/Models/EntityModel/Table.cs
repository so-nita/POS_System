using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class Table  
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string? Description { get; set; }  
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool? Is_Deleted { get; set; }
        //
        public ICollection<Order>? Orders { get; set; }
    }
}