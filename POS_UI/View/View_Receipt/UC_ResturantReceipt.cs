using POS_UI.Model;
using System.Runtime.InteropServices;

namespace POS_UI.View.Receipt;

public partial class UC_ResturantReceipt : UserControl
{
    private readonly ReceiptReq _receipt;
    public UC_ResturantReceipt(ReceiptReq receipt = null!)
    {
        InitializeComponent();
        _receipt = receipt;
        InitializeData();
    }

    
    private void InitializeData()
    {
        if (_receipt != null)
        {
            itemDataGridView.ColumnCount = 5;
            itemDataGridView.Columns[0].Width = 180;
            itemDataGridView.Columns[1].Width = 40;
            itemDataGridView.Columns[2].Width = 42;
            itemDataGridView.Columns[3].Width = 50;
            itemDataGridView.Columns[4].Width = 60;

            itemDataGridView.AutoSize = true;
            foreach (var product in _receipt.Order.OrderDetails)
            {
                DataGridViewRow row = new DataGridViewRow();
                //itemDataGridView.Height = itemDataGridView.Columns.Count;
                row.CreateCells(itemDataGridView);

                var itemTotal = (product.Qty * product.Price) - (product.Discount/100);
                row.Cells[0].Value = product.Name;
                row.Cells[1].Value = product.Qty;
                row.Cells[2].Value = product.Discount;
                row.Cells[3].Value = product.Price;
                row.Cells[4].Value = itemTotal;

                itemDataGridView.Rows.Add(row);
            }
            var order = _receipt.Order;
            labelOrderId.Text = _receipt.Code;
            labelCahierName.Text = "So Nita";
            labelOrderDate.Text = order.OrderDate.ToString();
            lableSubTotal.Text = order.SubTotal.ToString();
            labelPaidAmout.Text = order.Total.ToString();
            labelAmountKhr.Text = order.TotalKhr.ToString("#,##0.00");
            labelReceivedAmount.Text = _receipt.Total.ToString();
            labelReceivedAmount.Text = 0.ToString();
        }
    }

    private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
        {
            int[] numericColumns = {2, 3 ,4};
            if (numericColumns.Contains(e.ColumnIndex) && e.Value != null && e.Value != DBNull.Value)
            {
                e.CellStyle!.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }
    }
}
