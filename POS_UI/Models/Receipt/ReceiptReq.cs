using POS_UI.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Models.Receipt;

public class ReceiptReq
{
    public string Code { get; set; } = "";
    public DateTime OrderDate { get; set; }
    public string OrderId { get; set; } = string.Empty;
    public decimal? Discount { get; set; }
    public string? DiscounType { get; set; }
    public decimal Total { get; set; }
    public string Reference { get; set; } = string.Empty;
    public DateTime TransactionDate { get; set; }
    public OrderReq Order { get; set; } = new OrderReq();
}

