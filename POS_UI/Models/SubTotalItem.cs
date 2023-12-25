namespace POS_UI.Model;

public class SubTotalItem()
{
    public decimal SubTotal { get; set; } = 0.00m;
    public decimal Discount { get; set; } = 0.00m;
    public decimal Tax { get; set; } = 0.00m;
    public decimal Total { get; set; } = 0.00m;
}