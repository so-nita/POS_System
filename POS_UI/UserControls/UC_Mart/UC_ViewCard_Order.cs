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
using System.Windows;
using System.Windows.Forms;

namespace POS_UI.UserControls.UC_Mart
{
    public partial class UC_ViewCard_Order : UserControl
    {
        private ItemMart _item;
        public UC_ViewCard_Order(ItemMart item = null!)
        {
            InitializeComponent();
            _item = item;
            InitData();
        }

        public ItemMart GetProduct => _item;
        private void InitData()
        {
            if (_item != null)
            {
                labelNameCardOrder.Text = _item.Name.ToString();
                labelPriceCardOrder.Text = _item.Price.ToString();
                labelNumberQty.Text = _item.Qty.ToString();
            }
        }

        private void iconButtonSumCardOrder_Click(object sender, EventArgs e)
        {
            AddQty();
        }

        private void iconButtonSubCardOrder_Click(object sender, EventArgs e)
        {
            SubQty();
        }

        private void AddQty()
        {
            _item.Qty += 1;
            UpdateQuantity();
        }

        private void SubQty()
        {
            if (_item.Qty > 0)
            {
                _item.Qty -= 1;
                UpdateQuantity();
            }
            if (_item.Qty == 0)
            {
                this.Hide();
            }
        }

        private void UpdateQuantity()
        {
            UpdateQuantityLabel();
        }

        public void UpdateQuantityLabel()
        {
            labelNumberQty.Text = _item.Qty.ToString();
        }

    }
}
