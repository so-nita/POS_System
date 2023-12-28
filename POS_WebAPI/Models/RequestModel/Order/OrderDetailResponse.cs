namespace POS_WebAPI.Models.RequestModel.Order
{
    public class OrderDetailResponse
    {
        public string Id { get; set; } = null!;
        public string Product_Id { get; set; } = "";
        //public string Order_Id { get; set; } = string.Empty;
        public string Product_Name { get; set; } = string.Empty;
        public string? Size { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal? Discount_Percent { get; set; }
        public decimal? Discount_Amount { get; set; }
        public decimal Sub_Amount { get; set; }
        public decimal Grand_Amount { get; set; }
        public DateTime Create_At { get; set; }
    }
}
