
namespace ComputerShopForm
{
    partial class UserController1
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
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.btnAddToShoppingCart = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductSummary = new System.Windows.Forms.Label();
            this.lblSameDayDelivery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(28, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(25, 320);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(89, 15);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "ProductPrice";
            this.lblProductPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Location = new System.Drawing.Point(25, 346);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(72, 13);
            this.lblProductStock.TabIndex = 3;
            this.lblProductStock.Text = "ProductStock";
            // 
            // btnAddToShoppingCart
            // 
            this.btnAddToShoppingCart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddToShoppingCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddToShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnAddToShoppingCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToShoppingCart.Location = new System.Drawing.Point(163, 314);
            this.btnAddToShoppingCart.Name = "btnAddToShoppingCart";
            this.btnAddToShoppingCart.Size = new System.Drawing.Size(53, 45);
            this.btnAddToShoppingCart.TabIndex = 4;
            this.btnAddToShoppingCart.Text = "ADD";
            this.btnAddToShoppingCart.UseVisualStyleBackColor = false;
            this.btnAddToShoppingCart.Click += new System.EventHandler(this.btnAddToShoppingCart_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblProductName.Location = new System.Drawing.Point(25, 237);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(117, 20);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "ProductName";
            this.lblProductName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProductSummary
            // 
            this.lblProductSummary.AutoSize = true;
            this.lblProductSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSummary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProductSummary.Location = new System.Drawing.Point(25, 267);
            this.lblProductSummary.Name = "lblProductSummary";
            this.lblProductSummary.Size = new System.Drawing.Size(138, 13);
            this.lblProductSummary.TabIndex = 6;
            this.lblProductSummary.Text = "ProductSummary: blablabla ";
            // 
            // lblSameDayDelivery
            // 
            this.lblSameDayDelivery.AutoSize = true;
            this.lblSameDayDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSameDayDelivery.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSameDayDelivery.Location = new System.Drawing.Point(25, 372);
            this.lblSameDayDelivery.Name = "lblSameDayDelivery";
            this.lblSameDayDelivery.Size = new System.Drawing.Size(106, 13);
            this.lblSameDayDelivery.TabIndex = 7;
            this.lblSameDayDelivery.Text = "SameDayDelivery";
            // 
            // UserController1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblSameDayDelivery);
            this.Controls.Add(this.lblProductSummary);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnAddToShoppingCart);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Name = "UserController1";
            this.Size = new System.Drawing.Size(245, 414);
            this.Load += new System.EventHandler(this.UserController1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.Button btnAddToShoppingCart;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductSummary;
        private System.Windows.Forms.Label lblSameDayDelivery;
    }
}
