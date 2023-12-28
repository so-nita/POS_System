using POS_UI.Models.Product;
using POS_UI.View;
using POS_UI.View.View_PosSubMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_UI.UserControls.CardItem
{
    public partial class UC_ProductSell : UserControl
    {
        private readonly ProductResponse _product;
        private readonly View_Store _rest;

        public UC_ProductSell(ProductResponse product = null!, View_Store rest = null!)
        {
            InitializeComponent();
            _product = product;
            _rest = rest;
            InitData();
        }
        public ProductResponse GetProduct => _product;

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
        // btn for add qty
        private void AddQuantity()
        {
            _product.Qty += 1;
            UpdateQuantity();
        }
        // btn for Substract qty
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
                _rest.RemoveProductFromPrice(_product);
            }
        }
        //  add or substra for qty
        private void UpdateQuantity()
        {
            UpdateQuantityLabel();
            _rest.CalculateTotal();
        }

        public void UpdateQuantityLabel()
        {
            lableQty.Text = _product.Qty.ToString();
        }

        private void lableName_Click(object sender, EventArgs e)
        {

        }
        private void lableQty_Click(object sender, EventArgs e)
        {

        }

        private void lablePrice_Click(object sender, EventArgs e)
        {

        }
    }
}
