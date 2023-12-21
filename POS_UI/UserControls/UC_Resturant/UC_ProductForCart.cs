using POS_UI.Model;
using POS_UI.View.View_PosSubMenu;

namespace POS_UI.UserControls
{
    public partial class UC_ProductForCart : UserControl
    {
        private readonly OrderDetailReq _product;
        private readonly View_Resturant _rest;

        public UC_ProductForCart(OrderDetailReq product = null!, View_Resturant rest = null!)
        {
            InitializeComponent();
            _product = product;
            _rest = rest;
            InitData();
        }

        public OrderDetailReq GetProduct => _product;

        private void InitData()
        {
            if (_product != null)
            {
                lablePrice.Text = _product.Price.ToString();
                lableName.Text = _product.Name.ToString();
                lableQty.Text = _product.Qty.ToString() ?? "1";
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            SubstractQuantity();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddQuantity();
        }

        private void AddQuantity()
        {
            _product.Qty += 1;
            UpdateQuantity();
        }

        private void SubstractQuantity()
        {
            if (_product.Qty > 0)
            {
                _product.Qty -= 1;
                UpdateQuantity();
            }

            if (_product.Qty == 0)
            {
                this.Hide();
                _rest.RemoveProductFromCart(_product);
            }
        }

        private void UpdateQuantity()
        {
            UpdateQuantityLabel();
            _rest.CalculateTotal();
        }

        public void UpdateQuantityLabel()
        {
            lableQty.Text = _product.Qty.ToString();
        }
    }
}
