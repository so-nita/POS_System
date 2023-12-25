using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Model;

public class Product
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Image { get; set; } = "";
    public int Qty { get; set; } 
    public decimal Price { get; set; }
    public decimal Discount { get; set; } = 10;
    public decimal Amount { get; set; } = 0.0m;
}
