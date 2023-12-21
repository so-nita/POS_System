using POS_UI.Components;
using POS_UI.Model;
using POS_UI.UserControls;
using POS_UI.View.Receipt;

namespace POS_UI.View.View_PosSubMenu;

public partial class View_Resturant : Form
{
    public List<Product> Products = new List<Product>();
    //public List<OrderReq> Carts = new ();
    public OrderReq Carts = new();
    public View_Resturant()
    {
        InitializeComponent();
        InitListProduct();
    }

    private void InitListProduct()
    {
        var xOffSet = 0;
        Products = new List<Product>(){
            new Product(){ Id="1",  Name = "Product-001", Price=2.2M },
            new Product(){ Id="2",  Name = "Product-002", Price=3.1M },
            new Product(){ Id="3",  Name = "Product-003", Price=1.2M },
            new Product(){ Id="4",  Name = "Product-004", Price=5.6M },
            new Product(){ Id="5",  Name = "Product-004", Price=4.4M },
            new Product(){ Id="6",  Name = "Product-005", Price=1.2M },
            new Product(){ Id="7",  Name = "Product-006", Price=6.5M },
            new Product(){ Id="8",  Name = "Product-007", Price=6.1M },
            new Product(){ Id="9",  Name = "Product-007", Price=3.3M },
            new Product(){ Id="10", Name = "Product-009", Price=1.1M },
            new Product(){ Id="11", Name = "Product-010", Price=3.4M },
            new Product(){ Id="12", Name = "Product-011", Price=5.5M },
            new Product(){ Id="13", Name = "Product-012", Price=1.3M },
        };
        var t = Products.Count();
        if (Products.Count > 0)
        {
            foreach (var item in Products)
            {
                var card = new UC_ProuductCard(item);
                card.Location = new Point(xOffSet, 0);
                card.ProductClicked += prouductCard_Clicked!;
                panelListProduct.Controls.Add(card);
                xOffSet += 200;
            }
        }
    }

    private void prouductCard_Clicked(object sender, EventArgs e)
    {
        if (sender is UC_ProuductCard productCard)
        {
            var product = productCard.Product;
            var existProduct = Carts.OrderDetails.FirstOrDefault(e => e.ProductId == product.Id);
            
            if (existProduct == null)
            {
                var productOrder = new OrderDetailReq()
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Qty = 1,
                    Discount = product.Discount,
                    Price = product.Price,
                };
                Carts.OrderDetails.Add(productOrder);

                var productForCart = new UC_ProductForCart(productOrder, this);
                panelCart.Controls.Add(productForCart);
                panelCart.Controls.SetChildIndex(productForCart, 0);
            }
            else
            {
                existProduct.Qty += 1;
                UpdateQuantityLabelInCart(existProduct.ProductId, existProduct.Qty);
            }
            CalculateTotal();
        }
    }
    private void UpdateQuantityLabelInCart(string productId, int quantity)
    {
        foreach (Control control in panelCart.Controls)
        {
            if (control is UC_ProductForCart productForCart &&
                productForCart != null &&
                productForCart.GetProduct != null &&
                productForCart.GetProduct.ProductId == productId)
            {
                productForCart.UpdateQuantityLabel();
                break;
            }
        }
    }

    public void CalculateTotal()
    {
        var test = Carts;
        if (Carts.OrderDetails.Any())
        {
            /*var subTotal = Carts.OrderDetails.Sum(e => e.Price * e.Qty);
            var tax = Carts.Tax / 100;
            var total = subTotal - (Carts.Discount/100) - tax;
            var data = new OrderReq()
            {
                Id = Guid.NewGuid().ToString(),
                SubTotal = subTotal,
                Discount = 0,
                Tax = tax,
                Total = total,
                TotalKhr = total * 4500,
            };*/
            InitProductTotal(GetOrderReq());
        }
    }

    private void InitProductTotal(OrderReq data)
    {
        lableSubTotal.Text = "$ " + data.SubTotal.ToString("N2");
        lableDiscount.Text = "$ " + data.Discount.ToString("N2");
        lableTax.Text = "$ " + data.Tax.ToString("N2");
        lableTotal.Text = "$ " + data.Total.ToString("N2");
    }
    public void RemoveProductFromCart(OrderDetailReq product)
    {
        Carts.OrderDetails.Remove(product);
        CalculateTotal();
    }

    private void btnHold_Click(object sender, EventArgs e)
    {

    }

    // Button Print receipt
    private void btnPrint_Click(object sender, EventArgs e)
    {
        if(Carts.OrderDetails.Any())
        {
            var receipt = new UC_ResturantReceipt(GetOrderReq()) ;

            this.Controls.Add(receipt);
            Printer.PrintReceipt(receipt);
        }
        else
        {
            MessageBox.Show("Select item to cart.");
        }
    }
    private OrderReq GetOrderReq()
    {
        var subTotal = Carts.OrderDetails.Sum(e => e.Price * e.Qty);
        var tax = Carts.Tax / 100;
        var total = subTotal - (Carts.Discount / 100) - tax;
        return new OrderReq()
        {
            Id = Guid.NewGuid().ToString(),
            SubTotal = subTotal,
            Discount = 0,
            Tax = tax,
            Total = total,
            TotalKhr = total * 4500,
            OrderDetails = Carts.OrderDetails,
        };
    }
}
