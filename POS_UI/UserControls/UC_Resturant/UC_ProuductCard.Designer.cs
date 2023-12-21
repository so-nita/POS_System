namespace POS_UI.UserControls
{
    partial class UC_ProuductCard
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
            labelPriceItem = new Label();
            labelNameItem = new Label();
            pictureItem = new PictureBox();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureItem).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(labelPriceItem);
            materialCard1.Controls.Add(labelNameItem);
            materialCard1.Controls.Add(pictureItem);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(7, 2);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(165, 195);
            materialCard1.TabIndex = 0;
            // 
            // labelPriceItem
            // 
            labelPriceItem.AutoSize = true;
            labelPriceItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPriceItem.ForeColor = Color.Red;
            labelPriceItem.Location = new Point(7, 167);
            labelPriceItem.Name = "labelPriceItem";
            labelPriceItem.Size = new Size(36, 19);
            labelPriceItem.TabIndex = 2;
            labelPriceItem.Text = "2.22";
            // 
            // labelNameItem
            // 
            labelNameItem.AutoSize = true;
            labelNameItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNameItem.ForeColor = Color.Black;
            labelNameItem.Location = new Point(6, 146);
            labelNameItem.Name = "labelNameItem";
            labelNameItem.Size = new Size(73, 19);
            labelNameItem.TabIndex = 1;
            labelNameItem.Text = "Coco Cola";
            // 
            // pictureItem
            // 
            pictureItem.Image = Properties.Resources.Food_img1;
            pictureItem.Location = new Point(5, 0);
            pictureItem.Name = "pictureItem";
            pictureItem.Size = new Size(155, 145);
            pictureItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureItem.TabIndex = 0;
            pictureItem.TabStop = false;
            // 
            // UC_ProuductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(materialCard1);
            Name = "UC_ProuductCard";
            Size = new Size(177, 202);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label labelNameItem;
        private PictureBox pictureItem;
        private Label labelPriceItem;
    }
}
