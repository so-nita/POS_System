namespace POS_UI.View.View_PosSubMenu
{
    partial class View_Resturant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMainView = new Panel();
            materialCardCategory = new ReaLTaiizor.Controls.MaterialCard();
            panelCategory = new FlowLayoutPanel();
            panelListProduct = new FlowLayoutPanel();
            panelOrderCart = new ReaLTaiizor.Controls.MaterialCard();
            bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            lableDiscount = new ReaLTaiizor.Controls.BigLabel();
            lableTotal = new ReaLTaiizor.Controls.BigLabel();
            lableTax = new ReaLTaiizor.Controls.BigLabel();
            lableSubTotal = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            panelCart = new FlowLayoutPanel();
            panel1 = new Panel();
            btnHold = new Bunifu.Framework.UI.BunifuFlatButton();
            btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panelMainView.SuspendLayout();
            materialCardCategory.SuspendLayout();
            panelOrderCart.SuspendLayout();
            materialCard1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainView
            // 
            panelMainView.BackColor = Color.White;
            panelMainView.Controls.Add(materialCardCategory);
            panelMainView.Controls.Add(panelListProduct);
            panelMainView.Controls.Add(panelOrderCart);
            panelMainView.Dock = DockStyle.Fill;
            panelMainView.Location = new Point(0, 0);
            panelMainView.Name = "panelMainView";
            panelMainView.Size = new Size(1220, 650);
            panelMainView.TabIndex = 0;
            // 
            // materialCardCategory
            // 
            materialCardCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCardCategory.AutoScroll = true;
            materialCardCategory.BackColor = Color.FromArgb(255, 255, 255);
            materialCardCategory.Controls.Add(panelCategory);
            materialCardCategory.Depth = 0;
            materialCardCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardCategory.Location = new Point(12, 6);
            materialCardCategory.Margin = new Padding(14);
            materialCardCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCardCategory.Name = "materialCardCategory";
            materialCardCategory.Padding = new Padding(14);
            materialCardCategory.Size = new Size(835, 58);
            materialCardCategory.TabIndex = 1;
            // 
            // panelCategory
            // 
            panelCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCategory.BackColor = Color.White;
            panelCategory.Location = new Point(2, 1);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(828, 55);
            panelCategory.TabIndex = 0;
            panelCategory.WrapContents = false;
            panelCategory.AutoScroll = false;
            panelCategory.VerticalScroll.Maximum = 0;
            panelCategory.HorizontalScroll.Maximum = 0;
            panelCategory.AutoScroll = true;
            // 
            // panelListProduct
            // 
            panelListProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelListProduct.Location = new Point(2, 72);
            panelListProduct.Name = "panelListProduct";
            panelListProduct.Padding = new Padding(1, 0, 0, 0);
            panelListProduct.Size = new Size(855, 575);
            panelListProduct.TabIndex = 0;
            // 
            // panelOrderCart
            // 
            panelOrderCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelOrderCart.BackColor = Color.FromArgb(255, 255, 255);
            panelOrderCart.Controls.Add(bunifuFlatButton1);
            panelOrderCart.Controls.Add(materialCard1);
            panelOrderCart.Controls.Add(panelCart);
            panelOrderCart.Controls.Add(panel1);
            panelOrderCart.Depth = 0;
            panelOrderCart.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelOrderCart.Location = new Point(860, 5);
            panelOrderCart.Margin = new Padding(14);
            panelOrderCart.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelOrderCart.Name = "panelOrderCart";
            panelOrderCart.Padding = new Padding(14);
            panelOrderCart.Size = new Size(354, 635);
            panelOrderCart.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            bunifuFlatButton1.Active = false;
            bunifuFlatButton1.Activecolor = Color.FromArgb(0, 89, 179);
            bunifuFlatButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bunifuFlatButton1.BackColor = Color.FromArgb(77, 136, 255);
            bunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton1.BorderRadius = 7;
            bunifuFlatButton1.ButtonText = "  Pay Now";
            bunifuFlatButton1.DisabledColor = Color.Gray;
            bunifuFlatButton1.Iconcolor = Color.Transparent;
            bunifuFlatButton1.Iconimage = Properties.Resources.icon_pay;
            bunifuFlatButton1.Iconimage_right = null;
            bunifuFlatButton1.Iconimage_right_Selected = null;
            bunifuFlatButton1.Iconimage_Selected = null;
            bunifuFlatButton1.IconMarginLeft = 100;
            bunifuFlatButton1.IconMarginRight = 0;
            bunifuFlatButton1.IconRightVisible = true;
            bunifuFlatButton1.IconRightZoom = 0D;
            bunifuFlatButton1.IconVisible = true;
            bunifuFlatButton1.IconZoom = 55D;
            bunifuFlatButton1.IsTab = false;
            bunifuFlatButton1.Location = new Point(9, 581);
            bunifuFlatButton1.Margin = new Padding(4, 3, 4, 3);
            bunifuFlatButton1.Name = "bunifuFlatButton1";
            bunifuFlatButton1.Normalcolor = Color.FromArgb(77, 136, 255);
            bunifuFlatButton1.OnHovercolor = Color.FromArgb(0, 89, 179);
            bunifuFlatButton1.OnHoverTextColor = Color.White;
            bunifuFlatButton1.selected = false;
            bunifuFlatButton1.Size = new Size(334, 50);
            bunifuFlatButton1.TabIndex = 3;
            bunifuFlatButton1.Text = "  Pay Now";
            bunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton1.Textcolor = Color.White;
            bunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lableDiscount);
            materialCard1.Controls.Add(lableTotal);
            materialCard1.Controls.Add(lableTax);
            materialCard1.Controls.Add(lableSubTotal);
            materialCard1.Controls.Add(bigLabel4);
            materialCard1.Controls.Add(bigLabel6);
            materialCard1.Controls.Add(bigLabel5);
            materialCard1.Controls.Add(bigLabel3);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(9, 465);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(335, 110);
            materialCard1.TabIndex = 2;
            // 
            // lableDiscount
            // 
            lableDiscount.BackColor = Color.Transparent;
            lableDiscount.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableDiscount.ForeColor = Color.FromArgb(0, 89, 179);
            lableDiscount.Location = new Point(247, 25);
            lableDiscount.Name = "lableDiscount";
            lableDiscount.Size = new Size(80, 20);
            lableDiscount.TabIndex = 11;
            lableDiscount.Text = "$ 0.00";
            lableDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lableTotal
            // 
            lableTotal.BackColor = Color.Transparent;
            lableTotal.Font = new Font("Segoe UI Variable Display Semib", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableTotal.ForeColor = Color.Red;
            lableTotal.Location = new Point(251, 76);
            lableTotal.Name = "lableTotal";
            lableTotal.Size = new Size(80, 20);
            lableTotal.TabIndex = 10;
            lableTotal.Text = "$ 0.00";
            lableTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lableTax
            // 
            lableTax.BackColor = Color.Transparent;
            lableTax.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableTax.ForeColor = Color.FromArgb(0, 89, 179);
            lableTax.Location = new Point(247, 48);
            lableTax.Name = "lableTax";
            lableTax.Size = new Size(80, 20);
            lableTax.TabIndex = 9;
            lableTax.Text = "$ 0.00";
            lableTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lableSubTotal
            // 
            lableSubTotal.BackColor = Color.Transparent;
            lableSubTotal.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableSubTotal.ForeColor = Color.FromArgb(0, 89, 179);
            lableSubTotal.Location = new Point(247, 4);
            lableSubTotal.Name = "lableSubTotal";
            lableSubTotal.Size = new Size(80, 20);
            lableSubTotal.TabIndex = 7;
            lableSubTotal.Text = "$ 0.00";
            lableSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel4.ForeColor = Color.FromArgb(0, 89, 179);
            bigLabel4.Location = new Point(8, 48);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(78, 20);
            bigLabel4.TabIndex = 6;
            bigLabel4.Text = "Tax (10%) : ";
            // 
            // bigLabel6
            // 
            bigLabel6.AutoSize = true;
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel6.ForeColor = Color.FromArgb(0, 89, 179);
            bigLabel6.Location = new Point(8, 25);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(78, 20);
            bigLabel6.TabIndex = 5;
            bigLabel6.Text = "Discount : ";
            // 
            // bigLabel5
            // 
            bigLabel5.AutoSize = true;
            bigLabel5.BackColor = Color.Transparent;
            bigLabel5.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel5.ForeColor = Color.FromArgb(0, 89, 179);
            bigLabel5.Location = new Point(8, 76);
            bigLabel5.Name = "bigLabel5";
            bigLabel5.Size = new Size(57, 21);
            bigLabel5.TabIndex = 4;
            bigLabel5.Text = "Total : ";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.FromArgb(0, 89, 179);
            bigLabel3.Location = new Point(8, 4);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(80, 20);
            bigLabel3.TabIndex = 2;
            bigLabel3.Text = "Sub Total : ";
            // 
            // panelCart
            // 
            panelCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelCart.AutoScroll = true;
            panelCart.Location = new Point(0, 46);
            panelCart.Name = "panelCart";
            panelCart.Padding = new Padding(6, 0, 0, 0);
            panelCart.Size = new Size(354, 416);
            panelCart.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHold);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(bigLabel2);
            panel1.Controls.Add(bigLabel1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 43);
            panel1.TabIndex = 0;
            // 
            // btnHold
            // 
            btnHold.Active = false;
            btnHold.Activecolor = Color.FromArgb(0, 89, 179);
            btnHold.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHold.BackColor = Color.FromArgb(77, 136, 255);
            btnHold.BackgroundImageLayout = ImageLayout.Stretch;
            btnHold.BorderRadius = 7;
            btnHold.ButtonText = " Hold ";
            btnHold.DisabledColor = Color.Gray;
            btnHold.Iconcolor = Color.Transparent;
            btnHold.Iconimage = Properties.Resources.icon_cart_white;
            btnHold.Iconimage_right = null;
            btnHold.Iconimage_right_Selected = null;
            btnHold.Iconimage_Selected = null;
            btnHold.IconMarginLeft = 10;
            btnHold.IconMarginRight = 0;
            btnHold.IconRightVisible = true;
            btnHold.IconRightZoom = 0D;
            btnHold.IconVisible = true;
            btnHold.IconZoom = 40D;
            btnHold.IsTab = false;
            btnHold.Location = new Point(252, 4);
            btnHold.Margin = new Padding(4, 3, 4, 3);
            btnHold.Name = "btnHold";
            btnHold.Normalcolor = Color.FromArgb(77, 136, 255);
            btnHold.OnHovercolor = Color.FromArgb(0, 89, 179);
            btnHold.OnHoverTextColor = Color.White;
            btnHold.selected = false;
            btnHold.Size = new Size(92, 35);
            btnHold.TabIndex = 5;
            btnHold.Text = " Hold ";
            btnHold.TextAlign = ContentAlignment.MiddleLeft;
            btnHold.Textcolor = Color.White;
            btnHold.TextFont = new Font("Segoe UI Semibold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHold.Click += btnHold_Click;
            // 
            // btnPrint
            // 
            btnPrint.Active = false;
            btnPrint.Activecolor = Color.FromArgb(0, 89, 179);
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(77, 136, 255);
            btnPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrint.BorderRadius = 7;
            btnPrint.ButtonText = "";
            btnPrint.DisabledColor = Color.Gray;
            btnPrint.Iconcolor = Color.Transparent;
            btnPrint.Iconimage = Properties.Resources.icon_printer;
            btnPrint.Iconimage_right = null;
            btnPrint.Iconimage_right_Selected = null;
            btnPrint.Iconimage_Selected = null;
            btnPrint.IconMarginLeft = 10;
            btnPrint.IconMarginRight = 0;
            btnPrint.IconRightVisible = true;
            btnPrint.IconRightZoom = 0D;
            btnPrint.IconVisible = true;
            btnPrint.IconZoom = 30D;
            btnPrint.IsTab = false;
            btnPrint.Location = new Point(204, 4);
            btnPrint.Margin = new Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Normalcolor = Color.FromArgb(77, 136, 255);
            btnPrint.OnHovercolor = Color.FromArgb(0, 89, 179);
            btnPrint.OnHoverTextColor = Color.White;
            btnPrint.selected = false;
            btnPrint.Size = new Size(40, 35);
            btnPrint.TabIndex = 4;
            btnPrint.TextAlign = ContentAlignment.MiddleLeft;
            btnPrint.Textcolor = Color.White;
            btnPrint.TextFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Click += btnPrint_Click;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.FromArgb(0, 89, 179);
            bigLabel2.Location = new Point(84, 10);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(55, 21);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "#3352";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(0, 89, 179);
            bigLabel1.Location = new Point(3, 9);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(85, 21);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Order ID : ";
            // 
            // View_Resturant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 650);
            Controls.Add(panelMainView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_Resturant";
            Text = "View_Resturant";
            panelMainView.ResumeLayout(false);
            materialCardCategory.ResumeLayout(false);
            panelOrderCart.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainView;
        private ReaLTaiizor.Controls.MaterialCard panelOrderCart;
        private Panel panel1;
        /*-- private Panel panelCart;*/
        private FlowLayoutPanel panelCart;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private FlowLayoutPanel panelCategory;
        private FlowLayoutPanel panelListProduct;
        private ReaLTaiizor.Controls.MaterialCard materialCardCategory;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.BigLabel lableTotal;
        private ReaLTaiizor.Controls.BigLabel lableTax;
       // private ReaLTaiizor.Controls.BigLabel lableDiscount;
        private ReaLTaiizor.Controls.BigLabel lableSubTotal;
        private ReaLTaiizor.Controls.BigLabel lableDiscount;
        //private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnHold;
    }
}