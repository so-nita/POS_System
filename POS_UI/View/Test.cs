using POS_UI.Components;
using POS_UI.Components.CustomeStyle;
using POS_UI.Model;
using POS_UI.Model.Constant;
using POS_UI.View.Receipt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace POS_UI.View
{
    public partial class Test : Form
    {
        private CustomTouchScroll touchScroll ;

        public Test()
        {
            InitializeComponent();
            // comboBox1_SelectedIndexChanged();
            touchScroll = new CustomTouchScroll(panelCategory, ScrollDirection.Horizontal);
            Init();
        }
        private void CustomerPain_Border(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.White, ButtonBorderStyle.Inset);
        }

        public int YOffSet = 0;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Printer.ExportToExcel();

            /*var products = new List<OrderDetailReq>(){
                new Product(){ Name = "Product-001", Price=2.2M },
                new Product(){ Name = "Product-002", Price=3.1M },
                new Product(){ Name = "Product-003", Price=1.2M },
                new Product(){ Name = "Product-004", Price=5.6M },
                new Product(){ Name = "Product-004", Price=4.4M },
                new Product(){ Name = "Product-005", Price=1.2M },
                new Product(){ Name = "Product-006", Price=6.5M },
                new Product(){ Name = "Product-007", Price=6.1M },
                new Product(){ Name = "Product-007", Price=3.3M },
                new Product(){ Name = "Product-009", Price=1.1M },
                new Product(){ Name = "Product-010", Price=3.4M },
                new Product(){ Name = "Product-011", Price=5.5M },
                new Product(){ Name = "Product-012", Price=1.3M },
            };
            var receipt = new UC_ResturantReceipt(products);*/

            /*this.Controls.Add(receipt);
            bunifuFlatButton1.Visible = false;
            Printer.PrintReceipt(receipt);*/
        }

        private void Init()
        {
            panelCategory.Controls.Clear(); 
            var products = new List<Item>(){
                new Item(){ Name = "Product-001" },
                new Item(){ Name = "Product-002" },
                new Item(){ Name = "Product-003" },
                new Item(){ Name = "Product-004" },
                new Item(){ Name = "Product-004" },
                new Item(){ Name = "Product-005" },
                new Item(){ Name = "Product-006" },
                new Item(){ Name = "Product-007" },
                new Item(){ Name = "Product-007" },
                new Item(){ Name = "Product-009" },
                new Item(){ Name = "Product-010" },
                new Item(){ Name = "Product-011" },
                new Item(){ Name = "Product-012" },
            };
            foreach (var item in products)
            {
                btnCategory(item);
            }
        }
        private void btnCategory(Item item)
        {
            var btnCategory = new Button();
            btnCategory.ForeColor = Color.DarkGray;
            btnCategory.Text = item.Name;
            btnCategory.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.FlatAppearance.BorderSize = 0;

            btnCategory.Cursor = Cursors.Hand;
            btnCategory.Location = new Point(YOffSet, 7);
            btnCategory.Size = new Size(120, 40);
            btnCategory.BackColor = Color.White;
             
            panelCategory.Controls.Add(btnCategory);
            YOffSet += 120;
            touchScroll.AssignScrollEvent(btnCategory);
        }

        private void panelCategory_Paint(object sender, PaintEventArgs e)
        {

        }
        /* private void comboBox1_SelectedIndexChanged()
{
test = new List<Item>()
{
new Item() { Name = "tt", Id = "1" },
new Item() { Name = "ttfbvdgb g g ", Id = "2" },
new Item() { Name = "ttfbvdfbf", Id = "3" },
new Item() { Name = "ttfbdb", Id = "4" },
};
foreach (var item in test)
{
combo.Items.Add(item.Name);
combo.SelectedItem = item.Id;
}
combo.Text = "-- Select --";
}
private void Selected(object sender, EventArgs e)
{
if (combo.SelectedItem != null)
{
Item selectedItem = test.FirstOrDefault(item => item.Name == combo.SelectedItem.ToString())!;

if (selectedItem != null)
{
string selectedId = selectedItem.Id;

MessageBox.Show(selectedId + "\t" + combo.Text);
}
}
}*/
    }
    public class Item
    {
        public string Name { get; set;}
        public string Id { get; set; }
    }
}
