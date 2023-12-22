using POS_UI.Model;
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
    public partial class UC_Product_Price : UserControl
    {
        public event EventHandler ProductClicked;

        private Product _product;
        public Product Product
        {
            get { return _product; }
            set
            {
                _product = value;
                InitData();
            }
        }
        public UC_Product_Price(Product product = null!)
        {
            InitializeComponent();
            Product = product;
            pictureItem.Click += pictureItem_Click!;
        }
        private void InitData()
        {
            if (Product != null)
            {
                labelNameItem.Text = Product.Name;
                labelPriceItem.Text = Product.Price.ToString();
            }
        }
        private void pictureItem_Click(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
