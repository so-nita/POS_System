namespace POS_UI.UserControls.CardItem
{
    partial class UC_Product_Price
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
            pictureItem = new PictureBox();
            labelPriceItem = new Label();
            labelNameItem = new Label();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureItem).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureItem);
            materialCard1.Controls.Add(labelPriceItem);
            materialCard1.Controls.Add(labelNameItem);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(5, 3);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(157, 184);
            materialCard1.TabIndex = 0;
            // 
            // pictureItem
            // 
            //pictureItem.Image = Properties.Resources.Product_Paneer;
            pictureItem.Location = new Point(3, 3);
            pictureItem.Name = "pictureItem";
            pictureItem.Size = new Size(150, 132);
            pictureItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureItem.TabIndex = 3;
            pictureItem.TabStop = false;
            // 
            // labelPriceItem
            // 
            labelPriceItem.AutoSize = true;
            labelPriceItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelPriceItem.ForeColor = Color.Crimson;
            labelPriceItem.Location = new Point(10, 163);
            labelPriceItem.Name = "labelPriceItem";
            labelPriceItem.Size = new Size(40, 17);
            labelPriceItem.TabIndex = 2;
            labelPriceItem.Text = "0.00$";
            // 
            // labelNameItem
            // 
            labelNameItem.AutoSize = true;
            labelNameItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelNameItem.Location = new Point(7, 138);
            labelNameItem.Name = "labelNameItem";
            labelNameItem.Size = new Size(50, 17);
            labelNameItem.TabIndex = 2;
            labelNameItem.Text = "Paneer";
            // 
            // UC_Product_Price
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "UC_Product_Price";
            Size = new Size(165, 190);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label labelNameItem;
        private Label labelPriceItem;
        private PictureBox pictureItem;
    }
}
