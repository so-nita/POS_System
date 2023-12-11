using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class SystemType  
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool? Is_Deleted { get; set; }
        //
        public ICollection<Company>? Companies { get; set; }
    }
}
