using POS_UI.Model;
using POS_UI.UserControls;
using POS_UI.UserControls.CardItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_UI.View;

public partial class View_Store : Form
{
    public List<Product> Products = new List<Product>();
    public List<Product> Carts = new List<Product>();
    public View_Store()
    {
        InitializeComponent();
        InitListProduct();
    }
    private void InitListProduct()
    {
        var xOffSet = 0;
        Products = new List<Product>(){
        new Product(){Id="1", Name = "Product-001", Price=2.2M },
        new Product(){Id="2", Name = "Product-002", Price=3.1M },
        new Product(){Id="3", Name = "Product-003", Price=1.2M },
        new Product(){Id="4", Name = "Product-004", Price=5.6M },
        new Product(){Id="5", Name = "Product-004", Price=4.4M },
        new Product(){Id="6", Name = "Product-005", Price=1.2M },
        new Product(){Id="7", Name = "Product-006", Price=6.5M },
        new Product(){Id="8", Name = "Product-007", Price=6.1M },
        new Product(){Id="9", Name = "Product-007", Price=3.3M },
        new Product(){Id="10", Name = "Product-009", Price=1.1M },
        new Product(){Id="11", Name = "Product-010", Price=3.4M },
        new Product(){Id="12", Name = "Product-011", Price=5.5M },
        new Product(){Id="13", Name = "Product-012", Price=1.3M },
    };
        var t = Products.Count();
        if (Products.Count > 0)
        {
            foreach (var item in Products)
            {
                var card = new UC_Product_Price(item);
                card.Location = new Point(xOffSet, 0);
                card.ProductClicked += UC_Prouduct_Price_ProductClicked!;
                panelListProduct.Controls.Add(card);
                xOffSet += 200;
            }
        }
    }
    private void UC_Prouduct_Price_ProductClicked(object sender, EventArgs e)
    {
        if (sender is UC_Product_Price productprice)
        {
            var product = productprice.Product;
            var existProduct = Carts.FirstOrDefault(e => e.Id == product.Id);

            if (existProduct == null)
            {
                product.Qty = 1;
                Carts.Add(product);

                var productForPrice = new UC_ProductSell(productprice.Product, this);
                panelCart.Controls.Add(productForPrice);
                panelCart.Controls.SetChildIndex(productForPrice, 0);
            }
            else
            {
                existProduct.Qty += 1;
                UpdateQuantityLabelInCart(existProduct.Id, (int)existProduct.Qty);
            }
            CalculateTotal();
        }
    }
    private void UpdateQuantityLabelInCart(string productId, int quantity)
    {
        foreach (Control control in panelCart.Controls)
        {
            if (control is UC_ProductSell productForCart &&
                productForCart != null &&
                productForCart.GetProduct != null &&
                productForCart.GetProduct.Id == productId)
            {
                productForCart.UpdateQuantityLabel();
                break;
            }
        }
    }

    public void CalculateTotal()
    {
        var test = Carts;
        if (Carts.Any())
        {
            var subTotal = Carts.Sum(e => e.Price * e.Qty);
            var data = new SubTotalItem()
            {
                SubTotal = (decimal)subTotal!,
                Tax = 0.00m,
                Discount = 0,
                Total = (decimal)subTotal!
            };
            InitProductTotal(data);
        }
    }
    private void InitProductTotal(SubTotalItem data)
    {
        lableSubTotal.Text = "$ " + data.SubTotal.ToString("N2");
        lableDiscount.Text = "$ " + data.Discount.ToString("N2");
        lableTax.Text = "$ " + data.Tax.ToString("N2");
        lableTotal.Text = "$ " + data.Total.ToString("N2");
    }
    public void RemoveProductFromPrice(Product product)
    {
        Carts.Remove(product);
        CalculateTotal();
    }

    private void hopeButton4_Click(object sender, EventArgs e)
    {

    }

    private void materialCard1_Paint(object sender, PaintEventArgs e)
    {

    }
}
public class SubTotalItem
{
    public decimal SubTotal { get; internal set; }
    public decimal Tax { get; internal set; }
    public int Discount { get; internal set; }
    public decimal Total { get; internal set; }
}