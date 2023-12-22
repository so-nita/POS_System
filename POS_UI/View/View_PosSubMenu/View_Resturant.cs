using POS_UI.Components;
using POS_UI.Components.CustomeStyle;
using POS_UI.Model;
using POS_UI.Model.Constant;
using POS_UI.UserControls;
using POS_UI.View.Receipt;
using ReaLTaiizor.Controls;

namespace POS_UI.View.View_PosSubMenu;

public partial class View_Resturant : Form
{
    public List<Product> Products = new List<Product>();
    public OrderReq Carts = new();
    private List<OrderReq> HeldOrders = new List<OrderReq>();
    private CustomTouchScroll productTouchScroll;
    private CustomTouchScroll cartTouchScroll;

    public View_Resturant()
    {
        InitializeComponent();
        InitializeData();
    }

    private void InitializeData()
    {
        InitListProduct();
        productTouchScroll = new CustomTouchScroll(panelCategory, ScrollDirection.Horizontal);
        cartTouchScroll = new CustomTouchScroll(panelCart, ScrollDirection.Vertical);

        InitButtonCategory();
    }
    private void InitButtonCategory()
    {
        panelCategory.Controls.Clear();
        var products = new List<Item>(){
            new Item(){ Name = "Category#01" },
            new Item(){ Name = "Category#02" },
            new Item(){ Name = "Category#03" },
            new Item(){ Name = "Category#04" },
            new Item(){ Name = "Category#04" },
            new Item(){ Name = "Category#05" },
            new Item(){ Name = "Category#06" },
            new Item(){ Name = "Category#07" },
            new Item(){ Name = "Category#07" },
            new Item(){ Name = "Category#09" },
            new Item(){ Name = "Category#10" },
            new Item(){ Name = "Category#11" },
            new Item(){ Name = "Category#12" },
        };
        foreach (var item in products)
        {
            CreateButtonCategory(item);
        }
    }
    private void CreateButtonCategory(Item item)
    {
        var btnCategory = new RoyalButton();
        btnCategory.BackColor = Color.White;
        btnCategory.BorderColor = Color.White;
        btnCategory.BorderThickness = 3;
        btnCategory.DrawBorder = false;
        btnCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        btnCategory.ForeColor = Color.FromArgb(0, 89, 179);
        btnCategory.Size = new Size(120, 50);
        btnCategory.TabIndex = 12;
        btnCategory.Text = item.Name;

        panelCategory.Controls.Add(btnCategory);
        productTouchScroll.AssignScrollEvent(btnCategory);
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
            InitProductTotal(GetOrder);
        }
    }

    private void InitProductTotal(OrderReq data)
    {
        lableSubTotal.Text = "$ " + data.SubTotal.ToString("N2");
        lableDiscount.Text = "$ " + data.Discount?.ToString("N2");
        lableTax.Text = "$ " + data.Tax.ToString("N2");
        lableTotal.Text = "$ " + data.Total.ToString("N2");
    }
    public void RemoveProductFromCart(OrderDetailReq product)
    {
        Carts.OrderDetails.Remove(product);
        CalculateTotal();
    }

    // Button Print receipt
    private void btnPrint_Click(object sender, EventArgs e)
    {
        if (Carts.OrderDetails.Any())
        {
            var receipt = new UC_ResturantReceipt(GetReceipt);

            this.Controls.Add(receipt);
            Printer.PrintReceipt(receipt);
        }
        else
        {
            MessageBox.Show("Select item to cart.");
        }
    }
    // Return Data of Order 
    private OrderReq GetOrder
    {
        get
        {
            var subTotal = Carts.OrderDetails.Sum(e => e.Price * e.Qty);
            var tax = (subTotal != 0) ? Carts.Tax * subTotal / 100 : 0.00m;
            var total = (subTotal != 0) ? subTotal - (Carts.Discount / 100) + tax : 0.00m;
            return new OrderReq()
            {
                SubTotal = subTotal,
                Discount = 0,
                Tax = tax,
                Total = (decimal)total!,
                TotalKhr = (decimal)(total * 4000),
                OrderDate = DateTime.Now,
                OrderDetails = Carts.OrderDetails,
            };
        }
    }
    // Return Data of Receipt
    private ReceiptReq GetReceipt
    {
        get
        {
            return new ReceiptReq()
            {
                Code = GenerateReceiptCode(),
                Discount = GetOrder.Discount,
                DiscounType = GetOrder.DiscountType,
                OrderDate = GetOrder.OrderDate,
                //OrderId = GetOrder.Id,
                Total = GetOrder.Total,
                Reference = "So Nita",
                TransactionDate = GetOrder.OrderDate,
                Order = GetOrder
            };
        }
    }
    public string GenerateReceiptCode()
    {
        string prefix = "REC";
        string uniqueId = Guid.NewGuid().ToString("N");
        string receiptCode = $"{prefix}-{uniqueId}";

        return receiptCode;
    }

    // Button hold order
    private void btnHold_Click(object sender, EventArgs e)
    {
        if (Carts.OrderDetails.Any())
        {
            var heldOrder = new OrderReq
            {
                //Id = Guid.NewGuid().ToString(),
                OrderDetails = Carts.OrderDetails.ToList(),
            };

            HeldOrders.Add(heldOrder);
            ClearCurrentOrder();
        }
        else
        {
            MessageBox.Show("Select items to cart before holding the order.");
        }
    }
    private void ClearCurrentOrder()
    {
        Carts = new OrderReq();
        InitProductTotal(GetOrder);
        panelCart.Controls.Clear();
    }
 
}
