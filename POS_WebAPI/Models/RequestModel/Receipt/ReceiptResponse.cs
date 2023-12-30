using POS_WebAPI.Interface;

namespace POS_WebAPI.Models.RequestModel.Receipt
{
    public class ReceiptResponse : IResponse
    {
        public string Id { get; set; } = "";
        public string Reference_Id { get; set; } = "";
        public string Reference_Name { get; set; } = "";
        public string Order_Id { get; set; } = "";
        public decimal? Discount { get; set; }
        public decimal Sub_Total { get; set; }
        public decimal Total_Discount { get; set; }
        public decimal Grand_Total { get; set; }
        public string Company_Id { get; set; } = null!;
        public decimal? Tax { get; set; } = 0;
        public DateTime Order_Date { get; set; }
        public DateTime Transaction_Date { get; set; }
    }
}
