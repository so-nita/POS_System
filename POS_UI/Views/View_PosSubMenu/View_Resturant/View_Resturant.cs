using POS_UI.Components;
using POS_UI.Components.CustomeStyle;
using POS_UI.Constant;
using POS_UI.Models.Order;
using POS_UI.Models.Product;
using POS_UI.Models.Receipt;
using POS_UI.Models.SubCategory;
using POS_UI.Service;
using POS_UI.Test;
using POS_UI.UserControls;
using ReaLTaiizor.Controls;
using System.Management;

namespace POS_UI.View.View_PosSubMenu;

public partial class View_Resturant : Form
{
    private CustomTouchScroll productTouchScroll;
    private CustomTouchScroll cartTouchScroll;
    public OrderReq Carts = new();
    private List<OrderReq> HeldOrders = new List<OrderReq>();

    public View_Resturant()
    {
        InitializeComponent();
        InitializeData();
        this.Resize += View_Resturant_Resize!;
    }
    private void View_Resturant_Resize(object sender, EventArgs e)
    {
        AdjustPadding(this.Width);
    }

    public void AdjustPadding(int parentFormWidth)
    {
        if (parentFormWidth >= 1300)
        {
            panelListProduct.Padding = new Padding(15, 0, 0, 0);

        }
        else { panelListProduct.Padding = new Padding(0); }
        panelCategory.Padding = new Padding(0, 0, 30, 0);
    }
    private async void InitializeData()
    {
        productTouchScroll = new CustomTouchScroll(panelCategory, ScrollDirection.Horizontal);
        cartTouchScroll = new CustomTouchScroll(panelCart, ScrollDirection.Vertical);

        await LoadDataFromApiAsync();
    }

    private async Task LoadDataFromApiAsync()
    {
        var productService = new ProductService();
        var productData = await productService.GetAllAsync();
        var products = productData.Result!;

        var data = new SubCategoryService();
        var subCategories = await data.GetAllAsync();

        var selectedSubCategories = subCategories.Where(subCategory => products
                                    .Any(product => product.CategoryId == subCategory.Id && product.Qty > 0))
                                    .ToList();

        InitButtonCategory(selectedSubCategories);

        InitListProductAsync(products);
    }
    // List Button Sub Category 
    private void InitButtonCategory(List<SubCategoryResponse> subCategories)
    {
        if (subCategories.Any())
        {
            foreach (var item in subCategories)
            {
                CreateButtonCategory(item);
            }
        }
    }
    // List All Product Card  
    private void InitListProductAsync(List<ProductResponse> products)
    {
        var xOffSet = 0;
        if (products.Count > 0)
        {
            foreach (var item in products)
            {
                var card = new UC_ProuductCard(item);
                card.Location = new Point(xOffSet, 0);
                card.ProductClicked += prouductCard_Clicked!;
                panelListProduct.Controls.Add(card);
                xOffSet += 200;
            }
        }
    }
    // Product Card click then add Product to cart
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
    // Update text of Product's Qty on Cart
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
    //  Create Button Category
    private void CreateButtonCategory(SubCategoryResponse subCategory)
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
        btnCategory.Text = subCategory.Name;

        panelCategory.Controls.Add(btnCategory);
        productTouchScroll.AssignScrollEvent(btnCategory);
    }
    // Method for sum 
    public void CalculateTotal()
    {
        if (Carts.OrderDetails.Any())
        {
            UpdateLableTotalOrder(GetOrder);
        }
    }

    private void UpdateLableTotalOrder(OrderReq data)
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
            var receipt = new UC_Receipt(GetReceipt);

            this.Controls.Add(receipt);
            Printer.PrintReceipt(receipt);
        }
        else
        {
            MessageBox.Show("Please Select item to cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    // Return Data of Order 
    private OrderReq GetOrder
    {
        get
        {
            decimal subTotal = Carts.OrderDetails.Sum(e => e.Price * e.Qty);
            decimal tax = (subTotal != 0) ? Carts.Tax * subTotal / 100 : 0.00m;
            decimal total = (subTotal != 0) ? subTotal + tax : 0.00m;
            return new OrderReq()
            {
                SubTotal = subTotal,
                Discount = 0,
                Tax = tax,
                Total = total,
                TotalKhr = total * 4000,
                OrderDate = DateTime.Now,
                Received = total,
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
    // Generate Code for Receipt
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
            MessageBox.Show("Select items to cart before holding the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    // Reset All product Ordered
    private void ClearCurrentOrder()
    {
        Carts = new OrderReq();
        panelCart.Controls.Clear();
        UpdateLableTotalOrder(GetOrder);
    }

    private void BtnPay_Click(object sender, EventArgs e)
    {

    }
}
