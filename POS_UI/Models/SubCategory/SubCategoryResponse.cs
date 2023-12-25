using POS_UI.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Models.SubCategory
{
    public class SubCategoryResponse
    {
        public string Id { get; set; } = "";  
        public string Name { get; set; } = "";
        public string? Image { get; set; }
        public int Qty { get; set; }    
        public string Main_Category_Id { get; set; } = "";
        public DateTime Create_At { get; set; }
        public string? Description { get; set; }
        public List<ProductResponse> Products { get; set; } = new();
    }
}
