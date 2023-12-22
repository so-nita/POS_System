using System.Drawing.Printing;

namespace POS_UI.Components;


public static class Printer
{
    public static void PrintReceipt(UserControl userControl)
    {
        PrintDocument pd = new PrintDocument();
        pd.DefaultPageSettings.PaperSize = new PaperSize("CustomSize", userControl.Width, userControl.Height);

        pd.PrintPage += (sender, e) =>
        {
            Bitmap bitmap = new Bitmap(userControl.Width, userControl.Height);
            userControl.DrawToBitmap(bitmap, new Rectangle(0, 0, userControl.Width, userControl.Height));
            e.Graphics.DrawImage(bitmap, Point.Empty);
        };

        PrintDialog printDialog = new PrintDialog();
        printDialog.Document = pd;

        if (printDialog.ShowDialog() == DialogResult.OK)
        {
            pd.Print();
        }
    }
    /*public static void ExportToExcel()
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
        saveFileDialog.FileName = "text.xlsx";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                // Add a worksheet to the workbook
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                worksheet.Cells["A1"].Value = "Hello";

                package.Save();

                MessageBox.Show($"Data saved in Excel format at location: {filePath}");
            }
        }
    }*/
}
/*public static class Printer
{
    public static void PrintReceipt(UserControl receiptControl)
    {
        PrintDocument pd = new PrintDocument();
        pd.PrintPage += new PrintPageEventHandler((sender, e) => PrintReceiptPage(sender, e, receiptControl));

        PrintDialog printDialog = new PrintDialog();
        printDialog.Document = pd;

        if (printDialog.ShowDialog() == DialogResult.OK)
        {
            pd.Print();
        }
    }

    private static void PrintReceiptPage(object sender, PrintPageEventArgs e, UserControl receiptControl)
    {
        Graphics graphics = e.Graphics;

        Bitmap bitmap = new Bitmap(receiptControl.Width, receiptControl.Height);
        receiptControl.DrawToBitmap(bitmap, new Rectangle(0, 0, receiptControl.Width, receiptControl.Height));
        graphics.DrawImage(bitmap, 0, 0);
    }
}*/
