namespace POS_UI.UserControls
{
    partial class UC_ViewCard
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
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            labelItemPrice = new Label();
            lableItemName = new Label();
            pictureItem = new PictureBox();
            iconButton14 = new FontAwesome.Sharp.IconButton();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureItem).BeginInit();
            SuspendLayout();
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(labelItemPrice);
            materialCard2.Controls.Add(lableItemName);
            materialCard2.Controls.Add(pictureItem);
            materialCard2.Controls.Add(iconButton14);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(11, 11);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(120, 147);
            materialCard2.TabIndex = 16;
            // 
            // labelItemPrice
            // 
            labelItemPrice.AutoSize = true;
            labelItemPrice.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelItemPrice.ForeColor = Color.Red;
            labelItemPrice.Location = new Point(7, 127);
            labelItemPrice.Name = "labelItemPrice";
            labelItemPrice.Size = new Size(34, 15);
            labelItemPrice.TabIndex = 110;
            labelItemPrice.Text = "$1.00";
            // 
            // lableItemName
            // 
            lableItemName.AutoSize = true;
            lableItemName.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lableItemName.Location = new Point(4, 109);
            lableItemName.Name = "lableItemName";
            lableItemName.Size = new Size(40, 15);
            lableItemName.TabIndex = 109;
            lableItemName.Text = "OREO";
            // 
            // pictureItem
            // 
            pictureItem.BackgroundImage = Properties.Resources.orio;
            pictureItem.BackgroundImageLayout = ImageLayout.Zoom;
            pictureItem.Location = new Point(0, 2);
            pictureItem.Name = "pictureItem";
            pictureItem.Size = new Size(120, 104);
            pictureItem.TabIndex = 108;
            pictureItem.TabStop = false;
            // 
            // iconButton14
            // 
            iconButton14.BackColor = Color.WhiteSmoke;
            iconButton14.FlatStyle = FlatStyle.Flat;
            iconButton14.ForeColor = Color.Gainsboro;
            iconButton14.IconChar = FontAwesome.Sharp.IconChar.Plus;
            iconButton14.IconColor = Color.RoyalBlue;
            //iconButton14.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton14.IconSize = 18;
            iconButton14.Location = new Point(517, 177);
            iconButton14.Name = "iconButton14";
            iconButton14.Size = new Size(22, 22);
            iconButton14.TabIndex = 107;
            iconButton14.UseVisualStyleBackColor = false;
            // 
            // UC_ViewCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(materialCard2);
            Name = "UC_ViewCard";
            Size = new Size(142, 169);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private FontAwesome.Sharp.IconButton iconButton14;
        private PictureBox pictureItem;
        private Label labelItemPrice;
        private Label lableItemName;
    }
}
