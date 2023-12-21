namespace POS_UI.UserControls;

partial class UC_ProductForCart
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        picProduct = new PictureBox();
        materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
        lablePrice = new ReaLTaiizor.Controls.BigLabel();
        btnAdd = new ReaLTaiizor.Controls.Button();
        lableQty = new ReaLTaiizor.Controls.BigLabel();
        btnSubstract = new ReaLTaiizor.Controls.Button();
        lableName = new ReaLTaiizor.Controls.BigLabel();
        ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
        materialCard1.SuspendLayout();
        SuspendLayout();
        // 
        // picProduct
        // 
        picProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        picProduct.Image = Properties.Resources.Food_img;
        picProduct.Location = new Point(1, 1);
        picProduct.Name = "picProduct";
        picProduct.Size = new Size(54, 54);
        picProduct.SizeMode = PictureBoxSizeMode.Zoom;
        picProduct.TabIndex = 0;
        picProduct.TabStop = false;
        // 
        // materialCard1
        // 
        materialCard1.BackColor = Color.FromArgb(255, 255, 255);
        materialCard1.Controls.Add(lablePrice);
        materialCard1.Controls.Add(btnAdd);
        materialCard1.Controls.Add(lableQty);
        materialCard1.Controls.Add(btnSubstract);
        materialCard1.Controls.Add(lableName);
        materialCard1.Controls.Add(picProduct);
        materialCard1.Depth = 0;
        materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard1.Location = new Point(3, 3);
        materialCard1.Margin = new Padding(14);
        materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
        materialCard1.Name = "materialCard1";
        materialCard1.Padding = new Padding(14);
        materialCard1.Size = new Size(320, 55);
        materialCard1.TabIndex = 1;
        // 
        // lablePrice
        // 
        lablePrice.BackColor = Color.Transparent;
        lablePrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lablePrice.ForeColor = Color.Red;
        lablePrice.Location = new Point(193, 11);
        lablePrice.Name = "lablePrice";
        lablePrice.Size = new Size(40, 30);
        lablePrice.TabIndex = 5;
        lablePrice.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.White;
        btnAdd.BorderColor = Color.Transparent;
        btnAdd.EnteredBorderColor = Color.FromArgb(165, 37, 37);
        btnAdd.EnteredColor = Color.Red;
        btnAdd.Font = new Font("Microsoft Sans Serif", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAdd.Image = null;
        btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
        btnAdd.InactiveColor = Color.FromArgb(32, 34, 37);
        btnAdd.Location = new Point(286, 15);
        btnAdd.Name = "btnAdd";
        btnAdd.PressedBorderColor = Color.FromArgb(165, 37, 37);
        btnAdd.PressedColor = Color.FromArgb(165, 37, 37);
        btnAdd.Size = new Size(25, 22);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "+";
        btnAdd.TextAlignment = StringAlignment.Center;
        btnAdd.Click += btnAdd_Click;
        // 
        // lableQty
        // 
        lableQty.BackColor = Color.Transparent;
        lableQty.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lableQty.ForeColor = Color.FromArgb(80, 80, 80);
        lableQty.Location = new Point(257, 13);
        lableQty.Name = "lableQty";
        lableQty.Size = new Size(27, 27);
        lableQty.TabIndex = 3;
        lableQty.Text = "111";
        lableQty.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnSubstract
        // 
        btnSubstract.BackColor = Color.White;
        btnSubstract.BorderColor = Color.White;
        btnSubstract.EnteredBorderColor = Color.FromArgb(165, 37, 37);
        btnSubstract.EnteredColor = Color.FromArgb(32, 34, 37);
        btnSubstract.Font = new Font("Microsoft Sans Serif", 13.5F);
        btnSubstract.Image = null;
        btnSubstract.ImageAlign = ContentAlignment.MiddleLeft;
        btnSubstract.InactiveColor = Color.FromArgb(32, 34, 37);
        btnSubstract.Location = new Point(233, 15);
        btnSubstract.Name = "btnSubstract";
        btnSubstract.PressedBorderColor = Color.FromArgb(165, 37, 37);
        btnSubstract.PressedColor = Color.FromArgb(165, 37, 37);
        btnSubstract.Size = new Size(25, 22);
        btnSubstract.TabIndex = 2;
        btnSubstract.Text = "−";
        btnSubstract.TextAlignment = StringAlignment.Center;
        btnSubstract.Click += btnSubstract_Click;
        // 
        // lableName
        // 
        lableName.BackColor = Color.Transparent;
        lableName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lableName.ForeColor = Color.FromArgb(80, 80, 80);
        lableName.Location = new Point(55, 8);
        lableName.Name = "lableName";
        lableName.Size = new Size(129, 30);
        lableName.TabIndex = 1;
        lableName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // UC_ProductForCart
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Transparent;
        Controls.Add(materialCard1);
        Name = "UC_ProductForCart";
        Size = new Size(326, 60);
        ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
        materialCard1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private PictureBox picProduct;
    private ReaLTaiizor.Controls.MaterialCard materialCard1;
    private ReaLTaiizor.Controls.BigLabel lableName;
    private ReaLTaiizor.Controls.Button btnAdd;
    private ReaLTaiizor.Controls.BigLabel lableQty;
    private ReaLTaiizor.Controls.Button btnSubstract;
    private ReaLTaiizor.Controls.BigLabel lablePrice;
}
