using POS_UI.Models.Receipt;

namespace POS_UI.Test;

public partial class UC_Receipt : UserControl
{
    private readonly ReceiptReq _receipt;
    public UC_Receipt(ReceiptReq receipt = null!)
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
            itemDataGridView.Columns[0].Width = 190;
            itemDataGridView.Columns[1].Width = 28;
            itemDataGridView.Columns[2].Width = 35;
            itemDataGridView.Columns[3].Width = 64;
            itemDataGridView.Columns[4].Width = 58;

            itemDataGridView.AutoSize = true;
            foreach (var product in _receipt.Order.OrderDetails)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(itemDataGridView);

                var itemTotal = (product.Qty * product.Price) - (product.Discount / 100);
                row.Cells[0].Value = product.Name;
                row.Cells[1].Value = product.Qty;
                row.Cells[2].Value = product.Price;
                row.Cells[3].Value = product.Discount;
                row.Cells[4].Value = itemTotal;

                itemDataGridView.Rows.Add(row);
            }
            var order = _receipt.Order;
            labelOrderId.Text = _receipt.Code;
            labelCahierName.Text = "So Nita";
            labelOrderDate.Text = order.OrderDate.ToString();
            lableSubTotal.Text = "$ " + order.SubTotal.ToString();
            labelPaidAmout.Text = "$ " + order.Total.ToString();
            labelAmountKhr.Text =  order.TotalKhr.ToString("#,##0.00");
            labelReceivedAmount.Text = "$ " + order.Total.ToString();
            labelRemainAmount.Text = order.Remain.ToString();
        }
    }

    private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
        {
            int[] numericColumns = {2, 3, 4 };
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

    private void labelCompanyName_Click(object sender, EventArgs e)
    {

    }
}
