using POS_UI.UserControls.CardItem;
using System.Xml.Linq;

namespace POS_UI.View;

partial class View_Store
{
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
        materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
        bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
        panelCart = new FlowLayoutPanel();
        materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
        lableDiscount = new ReaLTaiizor.Controls.BigLabel();
        lableTotal = new ReaLTaiizor.Controls.BigLabel();
        lableTax = new ReaLTaiizor.Controls.BigLabel();
        lableSubTotal = new ReaLTaiizor.Controls.BigLabel();
        label14 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        panel3 = new Panel();
        button1 = new ReaLTaiizor.Controls.Button();
        label1 = new Label();
        label2 = new Label();
        panelListProduct = new FlowLayoutPanel();
        materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
        royalButton6 = new ReaLTaiizor.Controls.RoyalButton();
        royalButton5 = new ReaLTaiizor.Controls.RoyalButton();
        royalButton4 = new ReaLTaiizor.Controls.RoyalButton();
        royalButton3 = new ReaLTaiizor.Controls.RoyalButton();
        royalButton2 = new ReaLTaiizor.Controls.RoyalButton();
        royalButton1 = new ReaLTaiizor.Controls.RoyalButton();
        panel1 = new Panel();
        materialCard2.SuspendLayout();
        materialCard3.SuspendLayout();
        panel3.SuspendLayout();
        materialCard1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // materialCard2
        // 
        materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        materialCard2.BackColor = Color.FromArgb(255, 255, 255);
        materialCard2.Controls.Add(bunifuFlatButton1);
        materialCard2.Controls.Add(panelCart);
        materialCard2.Controls.Add(materialCard3);
        materialCard2.Controls.Add(panel3);
        materialCard2.Depth = 0;
        materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard2.Location = new Point(896, 9);
        materialCard2.Margin = new Padding(14);
        materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
        materialCard2.Name = "materialCard2";
        materialCard2.Padding = new Padding(14);
        materialCard2.Size = new Size(353, 688);
        materialCard2.TabIndex = 17;
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
        bunifuFlatButton1.Location = new Point(14, 627);
        bunifuFlatButton1.Margin = new Padding(4, 3, 4, 3);
        bunifuFlatButton1.Name = "bunifuFlatButton1";
        bunifuFlatButton1.Normalcolor = Color.FromArgb(77, 136, 255);
        bunifuFlatButton1.OnHovercolor = Color.FromArgb(0, 89, 179);
        bunifuFlatButton1.OnHoverTextColor = Color.White;
        bunifuFlatButton1.selected = false;
        bunifuFlatButton1.Size = new Size(325, 50);
        bunifuFlatButton1.TabIndex = 5;
        bunifuFlatButton1.Text = "  Pay Now";
        bunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft;
        bunifuFlatButton1.Textcolor = Color.White;
        bunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        // 
        // panelCart
        // 
        panelCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        panelCart.AutoScroll = true;
        panelCart.Location = new Point(0, 62);
        panelCart.Name = "panelCart";
        panelCart.Padding = new Padding(6, 0, 0, 0);
        panelCart.Size = new Size(350, 427);
        panelCart.TabIndex = 4;
        // 
        // materialCard3
        // 
        materialCard3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        materialCard3.BackColor = Color.FromArgb(255, 255, 255);
        materialCard3.Controls.Add(lableDiscount);
        materialCard3.Controls.Add(lableTotal);
        materialCard3.Controls.Add(lableTax);
        materialCard3.Controls.Add(lableSubTotal);
        materialCard3.Controls.Add(label14);
        materialCard3.Controls.Add(label5);
        materialCard3.Controls.Add(label4);
        materialCard3.Controls.Add(label3);
        materialCard3.Depth = 0;
        materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard3.Location = new Point(14, 506);
        materialCard3.Margin = new Padding(14);
        materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
        materialCard3.Name = "materialCard3";
        materialCard3.Padding = new Padding(14);
        materialCard3.Size = new Size(325, 115);
        materialCard3.TabIndex = 1;
        // 
        // lableDiscount
        // 
        lableDiscount.BackColor = Color.Transparent;
        lableDiscount.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lableDiscount.ForeColor = Color.FromArgb(0, 89, 179);
        lableDiscount.Location = new Point(230, 36);
        lableDiscount.Name = "lableDiscount";
        lableDiscount.Size = new Size(80, 20);
        lableDiscount.TabIndex = 15;
        lableDiscount.Text = "$ 0.00";
        lableDiscount.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lableTotal
        // 
        lableTotal.BackColor = Color.Transparent;
        lableTotal.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lableTotal.ForeColor = Color.Red;
        lableTotal.Location = new Point(230, 86);
        lableTotal.Name = "lableTotal";
        lableTotal.Size = new Size(80, 20);
        lableTotal.TabIndex = 14;
        lableTotal.Text = "$ 0.00";
        lableTotal.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lableTax
        // 
        lableTax.BackColor = Color.Transparent;
        lableTax.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lableTax.ForeColor = Color.FromArgb(0, 89, 179);
        lableTax.Location = new Point(230, 64);
        lableTax.Name = "lableTax";
        lableTax.Size = new Size(80, 20);
        lableTax.TabIndex = 13;
        lableTax.Text = "$ 0.00";
        lableTax.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lableSubTotal
        // 
        lableSubTotal.BackColor = Color.Transparent;
        lableSubTotal.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lableSubTotal.ForeColor = Color.FromArgb(0, 89, 179);
        lableSubTotal.Location = new Point(230, 6);
        lableSubTotal.Name = "lableSubTotal";
        lableSubTotal.Size = new Size(80, 20);
        lableSubTotal.TabIndex = 12;
        lableSubTotal.Text = "$ 0.00";
        lableSubTotal.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label14.ForeColor = Color.FromArgb(0, 89, 179);
        label14.Location = new Point(7, 86);
        label14.Name = "label14";
        label14.Size = new Size(54, 20);
        label14.TabIndex = 4;
        label14.Text = "Total  :";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(0, 89, 179);
        label5.Location = new Point(7, 64);
        label5.Name = "label5";
        label5.Size = new Size(41, 20);
        label5.TabIndex = 2;
        label5.Text = "Tax  :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.FromArgb(0, 89, 179);
        label4.Location = new Point(7, 36);
        label4.Name = "label4";
        label4.Size = new Size(74, 20);
        label4.TabIndex = 2;
        label4.Text = "Discount :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.FromArgb(0, 89, 179);
        label3.Location = new Point(7, 6);
        label3.Name = "label3";
        label3.Size = new Size(78, 20);
        label3.TabIndex = 2;
        label3.Text = "Sub Total :";
        // 
        // panel3
        // 
        panel3.Controls.Add(button1);
        panel3.Controls.Add(label1);
        panel3.Controls.Add(label2);
        panel3.Location = new Point(6, 3);
        panel3.Name = "panel3";
        panel3.Size = new Size(342, 51);
        panel3.TabIndex = 7;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(77, 136, 255);
        button1.BackgroundImage = Properties.Resources.blue;
        button1.BorderColor = Color.CornflowerBlue;
        button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
        button1.EnteredColor = Color.FromArgb(77, 136, 255);
        button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Image = Properties.Resources.icon_cart_white2;
        button1.ImageAlign = ContentAlignment.MiddleLeft;
        button1.InactiveColor = Color.CornflowerBlue;
        button1.Location = new Point(233, 8);
        button1.Margin = new Padding(10, 3, 3, 3);
        button1.Name = "button1";
        button1.PressedBorderColor = Color.White;
        button1.PressedColor = Color.FromArgb(0, 89, 179);
        button1.Size = new Size(100, 35);
        button1.TabIndex = 6;
        button1.Text = "  Hold";
        button1.TextAlignment = StringAlignment.Center;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        label1.ForeColor = Color.FromArgb(0, 89, 179);
        label1.Location = new Point(6, 12);
        label1.Name = "label1";
        label1.Size = new Size(72, 20);
        label1.TabIndex = 2;
        label1.Text = "Order ID:";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        label2.ForeColor = Color.FromArgb(0, 89, 179);
        label2.Location = new Point(74, 12);
        label2.Name = "label2";
        label2.Size = new Size(48, 20);
        label2.TabIndex = 2;
        label2.Text = "12345";
        // 
        // panelListProduct
        // 
        panelListProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelListProduct.Location = new Point(2, 69);
        panelListProduct.Name = "panelListProduct";
        panelListProduct.Padding = new Padding(5, 0, 0, 0);
        panelListProduct.Size = new Size(888, 633);
        panelListProduct.TabIndex = 18;
        // 
        // materialCard1
        // 
        materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        materialCard1.BackColor = Color.FromArgb(255, 255, 255);
        materialCard1.Controls.Add(royalButton6);
        materialCard1.Controls.Add(royalButton5);
        materialCard1.Controls.Add(royalButton4);
        materialCard1.Controls.Add(royalButton3);
        materialCard1.Controls.Add(royalButton2);
        materialCard1.Controls.Add(royalButton1);
        materialCard1.Depth = 0;
        materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard1.Location = new Point(14, 8);
        materialCard1.Margin = new Padding(14);
        materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
        materialCard1.Name = "materialCard1";
        materialCard1.Padding = new Padding(14);
        materialCard1.Size = new Size(876, 55);
        materialCard1.TabIndex = 19;
        materialCard1.Paint += materialCard1_Paint;
        // 
        // royalButton6
        // 
        royalButton6.BackColor = Color.White;
        royalButton6.BorderColor = Color.White;
        royalButton6.BorderThickness = 3;
        royalButton6.DrawBorder = false;
        royalButton6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        royalButton6.ForeColor = Color.FromArgb(0, 89, 179);
        royalButton6.HotTrackColor = Color.White;
        royalButton6.Image = null;
        royalButton6.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
        royalButton6.Location = new Point(636, 1);
        royalButton6.Name = "royalButton6";
        royalButton6.PressedColor = Color.FromArgb(77, 136, 255);
        royalButton6.PressedForeColor = Color.White;
        royalButton6.Size = new Size(121, 52);
        royalButton6.TabIndex = 12;
        royalButton6.Text = "FastFood";
        // 
        // royalButton5
        // 
        royalButton5.BackColor = Color.White;
        royalButton5.BorderColor = Color.White;
        royalButton5.BorderThickness = 3;
        royalButton5.DrawBorder = false;
        royalButton5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        royalButton5.ForeColor = Color.FromArgb(0, 89, 179);
        royalButton5.HotTrackColor = Color.White;
        royalButton5.Image = null;
        royalButton5.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
        royalButton5.Location = new Point(509, 1);
        royalButton5.Name = "royalButton5";
        royalButton5.PressedColor = Color.FromArgb(77, 136, 255);
        royalButton5.PressedForeColor = Color.White;
        royalButton5.Size = new Size(121, 52);
        royalButton5.TabIndex = 12;
        royalButton5.Text = "FastFood";
        // 
        // royalButton4
        // 
        royalButton4.BackColor = Color.White;
        royalButton4.BorderColor = Color.White;
        royalButton4.BorderThickness = 3;
        royalButton4.DrawBorder = false;
        royalButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        royalButton4.ForeColor = Color.FromArgb(0, 89, 179);
        royalButton4.HotTrackColor = Color.White;
        royalButton4.Image = null;
        royalButton4.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
        royalButton4.Location = new Point(382, 1);
        royalButton4.Name = "royalButton4";
        royalButton4.PressedColor = Color.FromArgb(77, 136, 255);
        royalButton4.PressedForeColor = Color.White;
        royalButton4.Size = new Size(121, 52);
        royalButton4.TabIndex = 12;
        royalButton4.Text = "FastFood";
        // 
        // royalButton3
        // 
        royalButton3.BackColor = Color.White;
        royalButton3.BorderColor = Color.White;
        royalButton3.BorderThickness = 3;
        royalButton3.DrawBorder = false;
        royalButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        royalButton3.ForeColor = Color.FromArgb(0, 89, 179);
        royalButton3.HotTrackColor = Color.White;
        royalButton3.Image = null;
        royalButton3.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
        royalButton3.Location = new Point(255, 1);
        royalButton3.Name = "royalButton3";
        royalButton3.PressedColor = Color.FromArgb(77, 136, 255);
        royalButton3.PressedForeColor = Color.White;
        royalButton3.Size = new Size(121, 52);
        royalButton3.TabIndex = 12;
        royalButton3.Text = "FastFood";
        // 
        // royalButton2
        // 
        royalButton2.BackColor = Color.White;
        royalButton2.BorderColor = Color.White;
        royalButton2.BorderThickness = 3;
        royalButton2.DrawBorder = false;
        royalButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        royalButton2.ForeColor = Color.FromArgb(0, 89, 179);
        royalButton2.HotTrackColor = Color.White;
        royalButton2.Image = null;
        royalButton2.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
        royalButton2.Location = new Point(128, 1);
        royalButton2.Name = "royalButton2";
        royalButton2.PressedColor = Color.FromArgb(77, 136, 255);
        royalButton2.PressedForeColor = Color.White;
        royalButton2.Size = new Size(121, 52);
        royalButton2.TabIndex = 12;
        royalButton2.Text = "FastFood";
        // 
        // royalButton1
        // 
        royalButton1.BackColor = Color.White;
        royalButton1.BorderColor = Color.White;
        royalButton1.BorderThickness = 3;
        royalButton1.DrawBorder = false;
        royalButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        royalButton1.ForeColor = Color.FromArgb(0, 89, 179);
        royalButton1.HotTrackColor = Color.White;
        royalButton1.Image = null;
        royalButton1.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
        royalButton1.Location = new Point(1, 1);
        royalButton1.Name = "royalButton1";
        royalButton1.PressedColor = Color.FromArgb(77, 136, 255);
        royalButton1.PressedForeColor = Color.White;
        royalButton1.Size = new Size(121, 52);
        royalButton1.TabIndex = 12;
        royalButton1.Text = "FastFood";
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panel1.BackColor = Color.White;
        panel1.Controls.Add(materialCard1);
        panel1.Controls.Add(panelListProduct);
        panel1.Controls.Add(materialCard2);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1249, 702);
        panel1.TabIndex = 0;
        // 
        // View_Store
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1250, 706);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "View_Store";
        Text = "FormStore";
        materialCard2.ResumeLayout(false);
        materialCard3.ResumeLayout(false);
        materialCard3.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        materialCard1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Controls.MaterialCard materialCard2;
    private FlowLayoutPanel panelCart;
    private Label label2;
    private Label label1;
    private ReaLTaiizor.Controls.MaterialCard materialCard3;
    private Label label5;
    private Label label4;
    private Label label3;
    private FlowLayoutPanel panelListProduct;
    private Panel panel1;
    private Label label14;
    private ReaLTaiizor.Controls.BigLabel lableDiscount;
    private ReaLTaiizor.Controls.BigLabel lableTotal;
    private ReaLTaiizor.Controls.BigLabel lableTax;
    private ReaLTaiizor.Controls.BigLabel lableSubTotal;
    private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    private ReaLTaiizor.Controls.Button button1;
    private Panel panel3;
    private ReaLTaiizor.Controls.MaterialCard materialCard1;
    private ReaLTaiizor.Controls.RoyalButton royalButton1;
    private ReaLTaiizor.Controls.RoyalButton royalButton6;
    private ReaLTaiizor.Controls.RoyalButton royalButton5;
    private ReaLTaiizor.Controls.RoyalButton royalButton4;
    private ReaLTaiizor.Controls.RoyalButton royalButton3;
    private ReaLTaiizor.Controls.RoyalButton royalButton2;
}