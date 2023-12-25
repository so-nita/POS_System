namespace POS_UI.View
{
    public class TotalItem
    {
        public object SubTotal { get; internal set; }
        public decimal Tax { get; internal set; }
        public decimal Total { get; internal set; }
        public int Discount { get; internal set; }
    }
}