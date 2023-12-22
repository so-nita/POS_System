using POS_UI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_UI.UserControls
{
    public partial class UC_ViewCard : UserControl
    {
        public EventHandler ProductClicked;
        public ItemMart Item;
        public UC_ViewCard(ItemMart item = null!)
        {
            InitializeComponent();
            Item = item;
            AssignValueToCard();
        }

        private void AssignValueToCard()
        {
            if (Item != null)
            {
                lableItemName.Text = Item.Name.ToString();
                labelItemPrice.Text = Item.Price.ToString() ?? "0.00";
            }
        }

        private void pictureItem_Click(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
