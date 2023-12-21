
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
            labelNumber = new Label();
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
            materialCardOrder.Controls.Add(labelNumber);
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
            materialCardOrder.Size = new Size(296, 54);
            materialCardOrder.TabIndex = 14;
            // 
            // iconButtonSumCardOrder
            // 
            iconButtonSumCardOrder.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonSumCardOrder.FlatStyle = FlatStyle.Flat;
            iconButtonSumCardOrder.ForeColor = Color.Gainsboro;
            iconButtonSumCardOrder.IconChar = FontAwesome.Sharp.IconChar.Plus;
            iconButtonSumCardOrder.IconColor = Color.RoyalBlue;
            iconButtonSumCardOrder.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButtonSumCardOrder.IconSize = 18;
            iconButtonSumCardOrder.Location = new Point(164, 16);
            iconButtonSumCardOrder.Name = "iconButtonSumCardOrder";
            iconButtonSumCardOrder.Size = new Size(22, 22);
            iconButtonSumCardOrder.TabIndex = 116;
            iconButtonSumCardOrder.UseVisualStyleBackColor = false;
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
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            labelNumber.ForeColor = Color.RoyalBlue;
            labelNumber.Location = new Point(190, 19);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(13, 15);
            labelNumber.TabIndex = 114;
            labelNumber.Text = "1";
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.WhiteSmoke;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Plus;
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
            labelPriceCardOrder.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            labelPriceCardOrder.ForeColor = Color.RoyalBlue;
            labelPriceCardOrder.Location = new Point(248, 21);
            labelPriceCardOrder.Name = "labelPriceCardOrder";
            labelPriceCardOrder.Size = new Size(34, 15);
            labelPriceCardOrder.TabIndex = 19;
            labelPriceCardOrder.Text = "$1.00";
            // 
            // pictureBoxCardOrder
            // 
            pictureBoxCardOrder.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCardOrder.Location = new Point(-1, 0);
            pictureBoxCardOrder.Name = "pictureBoxCardOrder";
            pictureBoxCardOrder.Size = new Size(64, 54);
            pictureBoxCardOrder.TabIndex = 3;
            pictureBoxCardOrder.TabStop = false;
            // 
            // labelNameCardOrder
            // 
            labelNameCardOrder.AutoSize = true;
            labelNameCardOrder.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            Size = new Size(306, 64);
            materialCardOrder.ResumeLayout(false);
            materialCardOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCardOrder).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCardOrder;
        private FontAwesome.Sharp.IconButton iconButtonSumCardOrder;
        private Label labelNumber;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label labelPriceCardOrder;
        private PictureBox pictureBoxCardOrder;
        private Label labelNameCardOrder;
        private FontAwesome.Sharp.IconButton iconButtonSubCardOrder;
    }
}
