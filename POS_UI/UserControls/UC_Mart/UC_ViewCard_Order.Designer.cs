
namespace POS_UI.UserControls.UC_Mart
{
    partial class UC_ViewCard_Order
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
            materialCardOrder = new ReaLTaiizor.Controls.MaterialCard();
            iconButtonSumCardOrder = new FontAwesome.Sharp.IconButton();
            iconButtonSubCardOrder = new FontAwesome.Sharp.IconButton();
            labelNumberQty = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            labelPriceCardOrder = new Label();
            pictureBoxCardOrder = new PictureBox();
            labelNameCardOrder = new Label();
            materialCardOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCardOrder).BeginInit();
            SuspendLayout();
            // 
            // materialCardOrder
            // 
            materialCardOrder.BackColor = Color.FromArgb(255, 255, 255);
            materialCardOrder.Controls.Add(iconButtonSumCardOrder);
            materialCardOrder.Controls.Add(iconButtonSubCardOrder);
            materialCardOrder.Controls.Add(labelNumberQty);
            materialCardOrder.Controls.Add(iconButton4);
            materialCardOrder.Controls.Add(labelPriceCardOrder);
            materialCardOrder.Controls.Add(pictureBoxCardOrder);
            materialCardOrder.Controls.Add(labelNameCardOrder);
            materialCardOrder.Depth = 0;
            materialCardOrder.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardOrder.Location = new Point(5, 5);
            materialCardOrder.Margin = new Padding(14);
            materialCardOrder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCardOrder.Name = "materialCardOrder";
            materialCardOrder.Padding = new Padding(14);
            materialCardOrder.Size = new Size(275, 54);
            materialCardOrder.TabIndex = 14;
            // 
            // iconButtonSumCardOrder
            // 
            iconButtonSumCardOrder.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonSumCardOrder.FlatStyle = FlatStyle.Flat;
            iconButtonSumCardOrder.ForeColor = Color.Gainsboro;
            iconButtonSumCardOrder.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButtonSumCardOrder.IconColor = Color.RoyalBlue;
            iconButtonSumCardOrder.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButtonSumCardOrder.IconSize = 18;
            iconButtonSumCardOrder.Location = new Point(164, 16);
            iconButtonSumCardOrder.Name = "iconButtonSumCardOrder";
            iconButtonSumCardOrder.Size = new Size(22, 22);
            iconButtonSumCardOrder.TabIndex = 116;
            iconButtonSumCardOrder.UseVisualStyleBackColor = false;
            iconButtonSumCardOrder.Click += iconButtonSumCardOrder_Click;
            // 
            // iconButtonSubCardOrder
            // 
            iconButtonSubCardOrder.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonSubCardOrder.FlatStyle = FlatStyle.Flat;
            iconButtonSubCardOrder.ForeColor = Color.Gainsboro;
            iconButtonSubCardOrder.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButtonSubCardOrder.IconColor = Color.RoyalBlue;
            iconButtonSubCardOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSubCardOrder.IconSize = 18;
            iconButtonSubCardOrder.Location = new Point(207, 16);
            iconButtonSubCardOrder.Name = "iconButtonSubCardOrder";
            iconButtonSubCardOrder.Size = new Size(22, 22);
            iconButtonSubCardOrder.TabIndex = 115;
            iconButtonSubCardOrder.UseVisualStyleBackColor = false;
            iconButtonSubCardOrder.Click += iconButtonSubCardOrder_Click;
            // 
            // labelNumberQty
            // 
            labelNumberQty.AutoSize = true;
            labelNumberQty.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumberQty.ForeColor = Color.RoyalBlue;
            labelNumberQty.Location = new Point(190, 19);
            labelNumberQty.Name = "labelNumberQty";
            labelNumberQty.Size = new Size(13, 15);
            labelNumberQty.TabIndex = 114;
            labelNumberQty.Text = "1";
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.WhiteSmoke;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.RoyalBlue;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton4.IconSize = 18;
            iconButton4.Location = new Point(517, 177);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(22, 22);
            iconButton4.TabIndex = 107;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // labelPriceCardOrder
            // 
            labelPriceCardOrder.AutoSize = true;
            labelPriceCardOrder.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriceCardOrder.ForeColor = Color.Red;
            labelPriceCardOrder.Location = new Point(232, 20);
            labelPriceCardOrder.Name = "labelPriceCardOrder";
            labelPriceCardOrder.Size = new Size(34, 15);
            labelPriceCardOrder.TabIndex = 19;
            labelPriceCardOrder.Text = "$1.00";
            // 
            // pictureBoxCardOrder
            // 
            pictureBoxCardOrder.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCardOrder.Image = Properties.Resources.Food_img1;
            pictureBoxCardOrder.Location = new Point(0, 0);
            pictureBoxCardOrder.Name = "pictureBoxCardOrder";
            pictureBoxCardOrder.Size = new Size(64, 54);
            pictureBoxCardOrder.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCardOrder.TabIndex = 3;
            pictureBoxCardOrder.TabStop = false;
            // 
            // labelNameCardOrder
            // 
            labelNameCardOrder.AutoSize = true;
            labelNameCardOrder.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameCardOrder.Location = new Point(73, 20);
            labelNameCardOrder.Name = "labelNameCardOrder";
            labelNameCardOrder.Size = new Size(40, 15);
            labelNameCardOrder.TabIndex = 15;
            labelNameCardOrder.Text = "OREO";
            // 
            // UC_ViewCard_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(materialCardOrder);
            Name = "UC_ViewCard_Order";
            Size = new Size(285, 65);
            materialCardOrder.ResumeLayout(false);
            materialCardOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCardOrder).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCardOrder;
        private FontAwesome.Sharp.IconButton iconButtonSumCardOrder;
        private Label labelNumberQty;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label labelPriceCardOrder;
        private PictureBox pictureBoxCardOrder;
        private Label labelNameCardOrder;
        private FontAwesome.Sharp.IconButton iconButtonSubCardOrder;
    }
}
