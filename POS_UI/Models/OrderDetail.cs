using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Model;

public class OrderDetailReq
{
    public string ProductId { get; set; } = "";
    public string Name { get; set; } = "";
    public int Qty { get; set; } = 0;
    public decimal Discount { get; set; } = 10;
    public decimal Price { get; set; } = 0.0m;
    public decimal Total { get; set; } = 0.0m;
}
