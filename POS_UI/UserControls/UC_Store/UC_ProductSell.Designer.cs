namespace POS_UI.UserControls.CardItem
{
    partial class UC_ProductSell
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
            pictureBox1 = new PictureBox();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            lablePrice = new ReaLTaiizor.Controls.BigLabel();
            btnAdd = new ReaLTaiizor.Controls.Button();
            lableQty = new ReaLTaiizor.Controls.BigLabel();
            btnSubstract = new ReaLTaiizor.Controls.Button();
            lableName = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = Properties.Resources.Product_Paneer1;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lablePrice);
            materialCard1.Controls.Add(btnAdd);
            materialCard1.Controls.Add(lableQty);
            materialCard1.Controls.Add(btnSubstract);
            materialCard1.Controls.Add(lableName);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(1, 2);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(320, 55);
            materialCard1.TabIndex = 0;
            // 
            // lablePrice
            // 
            lablePrice.BackColor = Color.Transparent;
            lablePrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lablePrice.ForeColor = Color.Red;
            lablePrice.Location = new Point(193, 12);
            lablePrice.Name = "lablePrice";
            lablePrice.Size = new Size(37, 30);
            lablePrice.TabIndex = 10;
            lablePrice.TextAlign = ContentAlignment.MiddleLeft;
            lablePrice.Click += lablePrice_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(224, 224, 224);
            btnAdd.BorderColor = Color.FromArgb(32, 34, 37);
            btnAdd.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnAdd.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAdd.Font = new Font("Microsoft Sans Serif", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Image = null;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.InactiveColor = Color.FromArgb(32, 34, 37);
            btnAdd.Location = new Point(287, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnAdd.PressedColor = Color.FromArgb(165, 37, 37);
            btnAdd.Size = new Size(22, 22);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "+";
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // lableQty
            // 
            lableQty.BackColor = Color.Transparent;
            lableQty.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableQty.ForeColor = Color.FromArgb(80, 80, 80);
            lableQty.Location = new Point(260, 15);
            lableQty.Name = "lableQty";
            lableQty.Size = new Size(22, 27);
            lableQty.TabIndex = 8;
            lableQty.TextAlign = ContentAlignment.MiddleCenter;
            lableQty.Click += lableQty_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.BackColor = Color.FromArgb(224, 224, 224);
            btnSubstract.BorderColor = Color.FromArgb(64, 64, 64);
            btnSubstract.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSubstract.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSubstract.Font = new Font("Microsoft Sans Serif", 13.5F);
            btnSubstract.Image = null;
            btnSubstract.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubstract.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSubstract.Location = new Point(235, 16);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSubstract.PressedColor = Color.FromArgb(165, 37, 37);
            btnSubstract.Size = new Size(22, 22);
            btnSubstract.TabIndex = 7;
            btnSubstract.Text = "-";
            btnSubstract.TextAlignment = StringAlignment.Center;
            btnSubstract.Click += btnSubstract_Click;
            // 
            // lableName
            // 
            lableName.BackColor = Color.Transparent;
            lableName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lableName.ForeColor = Color.FromArgb(80, 80, 80);
            lableName.Location = new Point(61, 12);
            lableName.Name = "lableName";
            lableName.Size = new Size(126, 30);
            lableName.TabIndex = 6;
            lableName.TextAlign = ContentAlignment.MiddleLeft;
            lableName.Click += lableName_Click;
            // 
            // UC_ProductSell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "UC_ProductSell";
            Size = new Size(325, 60);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.BigLabel lablePrice;
        private ReaLTaiizor.Controls.Button btnAdd;
        private ReaLTaiizor.Controls.BigLabel lableQty;
        private ReaLTaiizor.Controls.Button btnSubstract;
        private ReaLTaiizor.Controls.BigLabel lableName;
    }
}
