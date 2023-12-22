using POS_UI.Model;
using POS_UI.UserControls;
using POS_UI.UserControls.UC_Mart;
using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bunifu.UI.WinForms.Helpers.Transitions.Transition;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace POS_UI.View
{
    public partial class View_Mart : Form
    {
        public static List<Item> ShoppingCart { get; set; }
        public Order Order { get; set; } = new Order();

        public View_Mart()
        {
            InitializeComponent();
            InitData();
            InitProductTotal();
            ShowFooterData();
        }

        int y = 0;
        int x = 10;
        private void ProuctCard_Click(object sender, EventArgs e)
        {
            if (sender is UC_ViewCard control)
            {
                var data = control.Item;
                var existProduct = Order.Items.FirstOrDefault(e => e.Id == data.Id);
                data.Qty = 1;

                if (existProduct == null)
                {
                    var productCart = new UC_ViewCard_Order(control.Item);
                    productCart.Location = new Point(x, y);
                    panelCart.Controls.Add(productCart);
                    y += 62;
                    Order.Items.Add(data);
                }
                else
                {
                    existProduct.Qty += 1;
                    var productCart = new UC_ViewCard_Order(existProduct);
                }

                Calculate();
                ShowFooterData();
            }
        }

        //----- Set value to item -----
        private void InitData()
        {
            var xOffSet = 0;
            var ShoppingCart = new List<ItemMart>()
            {
                //----- All Card -----
                new ItemMart() { Id = "1", Name = "OREO", Price = 1.00M },
                new ItemMart() { Id = "2", Name = "OREO", Price = 2.00M },
                new ItemMart() { Id = "3", Name = "OREO", Price = 3.00M },
                new ItemMart() { Id = "4", Name = "OREO", Price = 4.00M },
                new ItemMart() { Id = "5", Name = "OREO", Price = 5.00M },
                new ItemMart() { Id = "6", Name = "OREO", Price = 6.00M },
                new ItemMart() { Id = "7", Name = "OREO", Price = 7.00M },
                new ItemMart() { Id = "8", Name = "OREO", Price = 8.00M },
                new ItemMart() { Id = "9", Name = "OREO", Price = 9.00M },
                new ItemMart() { Id = "10", Name = "OREO", Price = 10.00M },
                new ItemMart() { Id = "11", Name = "OREO", Price = 11.00M },
                new ItemMart() { Id = "12", Name = "OREO", Price = 12.00M },
                new ItemMart() { Id = "13", Name = "OREO", Price = 13.00M },
                new ItemMart() { Id = "14", Name = "OREO", Price = 14.00M },
                new ItemMart() { Id = "15", Name = "OREO", Price = 15.00M },
            };

            //----- Add All card into List card -----
            foreach (var item in ShoppingCart)
            {
                var panel = new UC_ViewCard(item);
                panel.Location = new Point(xOffSet, 0);
                panel.ProductClicked += ProuctCard_Click;
                panelMainItem.Controls.Add(panel);
                xOffSet += 200;
            }
        }

        public void Calculate()
        {
            if (Order.Items.Any())
            {
                GetOrder();
                InitProductTotal();
            }
        }

        private void InitProductTotal()
        {
            var TotalCart = GetOrder;
        }

        private Order GetOrder()
        {
            var total = Order.Items.Sum(e => e.Qty * e.Price);
            return new Order()
            {
                Discount = 0.00m,
                SubTotal = total,
                Tax = 0.00m,
                Total = total,
                Items = Order.Items
            };
        }

        private void ShowFooterData()
        {
            var orderItem = GetOrder();

            labelSubTotal.Text = "$ " + orderItem.SubTotal.ToString("N2");
            labelDiscount.Text = "$ " + orderItem.Discount.ToString("N2");
            labelTax.Text = "$ " + orderItem.Tax.ToString("N2");
            labelTotal.Text = "$ " + orderItem.Total.ToString("N2");
        }

        public void RemoveCartOrder(ItemMart item)
        {
            Order.Items.Remove(item);
            Calculate();
        }
    }
    //------ declare variable of item ------

    public class ItemMart
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public decimal Qty { get; set; }
        public string? Image { get; set; }
    }

    public class Order
    {
        public decimal SubTotal { get; set; } = 0.00m;
        public decimal Discount { get; set; } = 0.00m;
        public decimal Tax { get; set; } = 0.00m;
        public decimal Total { get; set; } = 0.00m;
        public List<ItemMart> Items { get; set; } = new List<ItemMart>();
    }
}
