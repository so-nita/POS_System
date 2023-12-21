using POS_UI.Components;
using POS_UI.Model;
using POS_UI.View.Receipt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace POS_UI.View
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            // comboBox1_SelectedIndexChanged();
        }

        private void CustomerPain_Border(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.White, ButtonBorderStyle.Inset);
        }
        private List<Item> test;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            /*var products = new List<OrderDetailReq>(){
                new Product(){ Name = "Product-001", Price=2.2M },
                new Product(){ Name = "Product-002", Price=3.1M },
                new Product(){ Name = "Product-003", Price=1.2M },
                new Product(){ Name = "Product-004", Price=5.6M },
                new Product(){ Name = "Product-004", Price=4.4M },
                new Product(){ Name = "Product-005", Price=1.2M },
                new Product(){ Name = "Product-006", Price=6.5M },
                new Product(){ Name = "Product-007", Price=6.1M },
                new Product(){ Name = "Product-007", Price=3.3M },
                new Product(){ Name = "Product-009", Price=1.1M },
                new Product(){ Name = "Product-010", Price=3.4M },
                new Product(){ Name = "Product-011", Price=5.5M },
                new Product(){ Name = "Product-012", Price=1.3M },
            };
            var receipt = new UC_ResturantReceipt(products);*/

            /*this.Controls.Add(receipt);
            bunifuFlatButton1.Visible = false;
            Printer.PrintReceipt(receipt);*/
        }
        /* private void comboBox1_SelectedIndexChanged()
{
    test = new List<Item>()
    {
        new Item() { Name = "tt", Id = "1" },
        new Item() { Name = "ttfbvdgb g g ", Id = "2" },
        new Item() { Name = "ttfbvdfbf", Id = "3" },
        new Item() { Name = "ttfbdb", Id = "4" },
    };
    foreach (var item in test)
    {
        combo.Items.Add(item.Name);
        combo.SelectedItem = item.Id;
    }
    combo.Text = "-- Select --";
}
private void Selected(object sender, EventArgs e)
{
    if (combo.SelectedItem != null)
    {
        Item selectedItem = test.FirstOrDefault(item => item.Name == combo.SelectedItem.ToString())!;

        if (selectedItem != null)
        {
            string selectedId = selectedItem.Id;

            MessageBox.Show(selectedId + "\t" + combo.Text);
        }
    }
}*/
    }
    public class Item
    {
        public string Name { get; set;}
        public string Id { get; set; }
    }
}
