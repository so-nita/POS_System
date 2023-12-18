using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class Section
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Desctiption { get; set; } = "";
        public Status Status { get; set; }
        public DateTime Create_At { get; set; }
        public bool Is_Deleted { get; set;}
        //
        public ICollection<Order>? Orders { get; set;}
    }
}
