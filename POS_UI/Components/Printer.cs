using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POS_UI.Components;

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

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
