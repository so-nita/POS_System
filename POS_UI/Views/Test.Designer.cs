
namespace POS_UI.View
{
    partial class Test
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            panelParent = new ReaLTaiizor.Controls.MaterialCard();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelCart = new ReaLTaiizor.Controls.MaterialCard();
            panel1 = new Panel();
            panelCategory = new FlowLayoutPanel();
            bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelParent.SuspendLayout();
            panelCart.SuspendLayout();
            SuspendLayout();
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 20;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 5;
            bunifuElipse2.TargetControl = this;
            // 
            // bunifuFlatButton1
            // 
            bunifuFlatButton1.Active = false;
            bunifuFlatButton1.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton1.BorderRadius = 0;
            bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            bunifuFlatButton1.DisabledColor = Color.Gray;
            bunifuFlatButton1.Iconcolor = Color.Transparent;
            bunifuFlatButton1.Iconimage = (Image)resources.GetObject("bunifuFlatButton1.Iconimage");
            bunifuFlatButton1.Iconimage_right = null;
            bunifuFlatButton1.Iconimage_right_Selected = null;
            bunifuFlatButton1.Iconimage_Selected = null;
            bunifuFlatButton1.IconMarginLeft = 0;
            bunifuFlatButton1.IconMarginRight = 0;
            bunifuFlatButton1.IconRightVisible = true;
            bunifuFlatButton1.IconRightZoom = 0D;
            bunifuFlatButton1.IconVisible = true;
            bunifuFlatButton1.IconZoom = 90D;
            bunifuFlatButton1.IsTab = false;
            bunifuFlatButton1.Location = new Point(12, 6);
            bunifuFlatButton1.Margin = new Padding(4, 3, 4, 3);
            bunifuFlatButton1.Name = "bunifuFlatButton1";
            bunifuFlatButton1.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton1.OnHoverTextColor = Color.White;
            bunifuFlatButton1.selected = false;
            bunifuFlatButton1.Size = new Size(166, 48);
            bunifuFlatButton1.TabIndex = 0;
            bunifuFlatButton1.Text = "bunifuFlatButton1";
            bunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton1.Textcolor = Color.White;
            bunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bunifuFlatButton1.Click += bunifuFlatButton1_Click;
            // 
            // panelParent
            // 
            panelParent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelParent.AutoScroll = true;
            panelParent.BackColor = Color.FromArgb(255, 255, 255);
            panelParent.Controls.Add(flowLayoutPanel1);
            panelParent.Depth = 0;
            panelParent.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelParent.Location = new Point(23, 149);
            panelParent.Margin = new Padding(14);
            panelParent.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelParent.Name = "panelParent";
            panelParent.Padding = new Padding(14);
            panelParent.Size = new Size(821, 79);
            panelParent.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 128, 128);
            flowLayoutPanel1.Location = new Point(14, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(895, 60);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panelCart
            // 
            panelCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelCart.BackColor = Color.FromArgb(255, 255, 255);
            panelCart.Controls.Add(panel1);
            panelCart.Controls.Add(panelCategory);
            panelCart.Depth = 0;
            panelCart.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelCart.Location = new Point(23, 262);
            panelCart.Margin = new Padding(14);
            panelCart.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelCart.Name = "panelCart";
            panelCart.Padding = new Padding(0, 0, 0, 20);
            panelCart.Size = new Size(514, 87);
            panelCart.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Location = new Point(7, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 20);
            panel1.TabIndex = 9;
            // 
            // panelCategory
            // 
            panelCategory.AutoScroll = true;
            panelCategory.BackColor = Color.Yellow;
            panelCategory.Location = new Point(7, 4);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(803, 60);
            panelCategory.TabIndex = 9;
            panelCategory.WrapContents = false;
            // 
            // bunifuFlatButton4
            // 
            bunifuFlatButton4.Active = false;
            bunifuFlatButton4.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton4.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton4.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton4.BorderRadius = 0;
            bunifuFlatButton4.ButtonText = "bunifuFlatButton4";
            bunifuFlatButton4.DisabledColor = Color.Gray;
            bunifuFlatButton4.Iconcolor = Color.Transparent;
            bunifuFlatButton4.Iconimage = (Image)resources.GetObject("bunifuFlatButton4.Iconimage");
            bunifuFlatButton4.Iconimage_right = null;
            bunifuFlatButton4.Iconimage_right_Selected = null;
            bunifuFlatButton4.Iconimage_Selected = null;
            bunifuFlatButton4.IconMarginLeft = 0;
            bunifuFlatButton4.IconMarginRight = 0;
            bunifuFlatButton4.IconRightVisible = true;
            bunifuFlatButton4.IconRightZoom = 0D;
            bunifuFlatButton4.IconVisible = true;
            bunifuFlatButton4.IconZoom = 90D;
            bunifuFlatButton4.IsTab = false;
            bunifuFlatButton4.Location = new Point(498, 7);
            bunifuFlatButton4.Margin = new Padding(4, 3, 4, 3);
            bunifuFlatButton4.Name = "bunifuFlatButton4";
            bunifuFlatButton4.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton4.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton4.OnHoverTextColor = Color.White;
            bunifuFlatButton4.selected = false;
            bunifuFlatButton4.Size = new Size(166, 48);
            bunifuFlatButton4.TabIndex = 4;
            bunifuFlatButton4.Text = "bunifuFlatButton4";
            bunifuFlatButton4.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton4.Textcolor = Color.White;
            bunifuFlatButton4.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // bunifuFlatButton3
            // 
            bunifuFlatButton3.Active = false;
            bunifuFlatButton3.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton3.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton3.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton3.BorderRadius = 0;
            bunifuFlatButton3.ButtonText = "bunifuFlatButton3";
            bunifuFlatButton3.DisabledColor = Color.Gray;
            bunifuFlatButton3.Iconcolor = Color.Transparent;
            bunifuFlatButton3.Iconimage = (Image)resources.GetObject("bunifuFlatButton3.Iconimage");
            bunifuFlatButton3.Iconimage_right = null;
            bunifuFlatButton3.Iconimage_right_Selected = null;
            bunifuFlatButton3.Iconimage_Selected = null;
            bunifuFlatButton3.IconMarginLeft = 0;
            bunifuFlatButton3.IconMarginRight = 0;
            bunifuFlatButton3.IconRightVisible = true;
            bunifuFlatButton3.IconRightZoom = 0D;
            bunifuFlatButton3.IconVisible = true;
            bunifuFlatButton3.IconZoom = 90D;
            bunifuFlatButton3.IsTab = false;
            bunifuFlatButton3.Location = new Point(520, 14);
            bunifuFlatButton3.Margin = new Padding(4, 3, 4, 3);
            bunifuFlatButton3.Name = "bunifuFlatButton3";
            bunifuFlatButton3.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton3.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton3.OnHoverTextColor = Color.White;
            bunifuFlatButton3.selected = false;
            bunifuFlatButton3.Size = new Size(166, 48);
            bunifuFlatButton3.TabIndex = 3;
            bunifuFlatButton3.Text = "bunifuFlatButton3";
            bunifuFlatButton3.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton3.Textcolor = Color.White;
            bunifuFlatButton3.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // bunifuFlatButton2
            // 
            bunifuFlatButton2.Active = false;
            bunifuFlatButton2.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton2.BorderRadius = 0;
            bunifuFlatButton2.ButtonText = "bunifuFlatButton2";
            bunifuFlatButton2.DisabledColor = Color.Gray;
            bunifuFlatButton2.Iconcolor = Color.Transparent;
            bunifuFlatButton2.Iconimage = (Image)resources.GetObject("bunifuFlatButton2.Iconimage");
            bunifuFlatButton2.Iconimage_right = null;
            bunifuFlatButton2.Iconimage_right_Selected = null;
            bunifuFlatButton2.Iconimage_Selected = null;
            bunifuFlatButton2.IconMarginLeft = 0;
            bunifuFlatButton2.IconMarginRight = 0;
            bunifuFlatButton2.IconRightVisible = true;
            bunifuFlatButton2.IconRightZoom = 0D;
            bunifuFlatButton2.IconVisible = true;
            bunifuFlatButton2.IconZoom = 90D;
            bunifuFlatButton2.IsTab = false;
            bunifuFlatButton2.Location = new Point(318, 6);
            bunifuFlatButton2.Margin = new Padding(4, 3, 4, 3);
            bunifuFlatButton2.Name = "bunifuFlatButton2";
            bunifuFlatButton2.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton2.OnHoverTextColor = Color.White;
            bunifuFlatButton2.selected = false;
            bunifuFlatButton2.Size = new Size(166, 48);
            bunifuFlatButton2.TabIndex = 1;
            bunifuFlatButton2.Text = "bunifuFlatButton2";
            bunifuFlatButton2.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton2.Textcolor = Color.White;
            bunifuFlatButton2.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.BackColor = Color.FromArgb(255, 128, 128);
            flowLayoutPanel3.Location = new Point(9, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(700, 0);
            flowLayoutPanel3.TabIndex = 2;
            flowLayoutPanel3.WrapContents = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel4.BackColor = Color.FromArgb(255, 128, 128);
            flowLayoutPanel4.Location = new Point(9, 9);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(650, 0);
            flowLayoutPanel4.TabIndex = 3;
            flowLayoutPanel4.WrapContents = false;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(368, 422);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(89, 36);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(868, 683);
            Controls.Add(iconButton1);
            Controls.Add(panelCart);
            Controls.Add(panelParent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Test";
            Padding = new Padding(40, 0, 40, 40);
            Text = "Test";
            panelParent.ResumeLayout(false);
            panelCart.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private ReaLTaiizor.Controls.MaterialCard panelParent;
        private FlowLayoutPanel flowLayoutPanel1;
        //private FlowLayoutPanel panelCart;
        private ReaLTaiizor.Controls.MaterialCard panelCart;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel panelCategory;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}