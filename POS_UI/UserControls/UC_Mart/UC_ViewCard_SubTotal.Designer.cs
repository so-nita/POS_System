namespace POS_UI.UserControls.UC_Mart
{
    partial class UC_ViewCard_SubTotal
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
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            labelSubTotal = new Label();
            labelPriceTotal = new Label();
            labelPriceTax = new Label();
            labelPriceDiscount = new Label();
            labelPriceSubTotal = new Label();
            labelTotal = new Label();
            labelTax = new Label();
            labelDiscount = new Label();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(labelSubTotal);
            materialCard1.Controls.Add(labelPriceTotal);
            materialCard1.Controls.Add(labelPriceTax);
            materialCard1.Controls.Add(labelPriceDiscount);
            materialCard1.Controls.Add(labelPriceSubTotal);
            materialCard1.Controls.Add(labelTotal);
            materialCard1.Controls.Add(labelTax);
            materialCard1.Controls.Add(labelDiscount);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(4, 15);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(296, 173);
            materialCard1.TabIndex = 0;
            // 
            // labelSubTotal
            // 
            labelSubTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubTotal.ForeColor = Color.FromArgb(77, 136, 255);
            labelSubTotal.Location = new Point(17, 14);
            labelSubTotal.Name = "labelSubTotal";
            labelSubTotal.Size = new Size(71, 20);
            labelSubTotal.TabIndex = 8;
            labelSubTotal.Text = "Sub Total";
            // 
            // labelPriceTotal
            // 
            labelPriceTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPriceTotal.ForeColor = Color.Red;
            labelPriceTotal.Location = new Point(174, 130);
            labelPriceTotal.Name = "labelPriceTotal";
            labelPriceTotal.Size = new Size(110, 25);
            labelPriceTotal.TabIndex = 7;
            labelPriceTotal.Text = " ";
            labelPriceTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPriceTax
            // 
            labelPriceTax.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriceTax.ForeColor = Color.Red;
            labelPriceTax.Location = new Point(174, 90);
            labelPriceTax.Name = "labelPriceTax";
            labelPriceTax.Size = new Size(107, 20);
            labelPriceTax.TabIndex = 6;
            labelPriceTax.Text = " ";
            labelPriceTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPriceDiscount
            // 
            labelPriceDiscount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriceDiscount.ForeColor = Color.Red;
            labelPriceDiscount.Location = new Point(174, 51);
            labelPriceDiscount.Name = "labelPriceDiscount";
            labelPriceDiscount.Size = new Size(107, 20);
            labelPriceDiscount.TabIndex = 5;
            labelPriceDiscount.Text = " ";
            labelPriceDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPriceSubTotal
            // 
            labelPriceSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPriceSubTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriceSubTotal.ForeColor = Color.Red;
            labelPriceSubTotal.Location = new Point(174, 14);
            labelPriceSubTotal.Name = "labelPriceSubTotal";
            labelPriceSubTotal.Size = new Size(107, 20);
            labelPriceSubTotal.TabIndex = 4;
            labelPriceSubTotal.Text = " ";
            labelPriceSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.FromArgb(77, 136, 255);
            labelTotal.Location = new Point(17, 134);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(48, 21);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Total";
            // 
            // labelTax
            // 
            labelTax.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTax.ForeColor = Color.FromArgb(77, 136, 255);
            labelTax.Location = new Point(17, 90);
            labelTax.Name = "labelTax";
            labelTax.Size = new Size(30, 20);
            labelTax.TabIndex = 2;
            labelTax.Text = "Tax";
            // 
            // labelDiscount
            // 
            labelDiscount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDiscount.ForeColor = Color.FromArgb(77, 136, 255);
            labelDiscount.Location = new Point(17, 51);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(67, 20);
            labelDiscount.TabIndex = 1;
            labelDiscount.Text = "Discount";
            // 
            // UC_ViewCard_SubTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(materialCard1);
            Name = "UC_ViewCard_SubTotal";
            Size = new Size(311, 191);
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label labelTotal;
        private Label labelTax;
        private Label labelDiscount;
        private Label labelPriceSubTotal;
        private Label labelPriceTotal;
        private Label labelPriceTax;
        private Label labelPriceDiscount;
        private Label labelSubTotal;
    }
}
