
namespace ComputerShopForm
{
    partial class UserControlShop
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
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.btnAddToShoppingCart = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSameDayDelivery = new System.Windows.Forms.Label();
            this.lblProductSummary = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 15);
            this.lblName.TabIndex = 0;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductPrice.Location = new System.Drawing.Point(2, 270);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(111, 18);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "ProductPrice";
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStock.Location = new System.Drawing.Point(2, 300);
            this.lblProductStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(97, 16);
            this.lblProductStock.TabIndex = 3;
            this.lblProductStock.Text = "ProductStock";
            // 
            // btnAddToShoppingCart
            // 
            this.btnAddToShoppingCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddToShoppingCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddToShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnAddToShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToShoppingCart.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToShoppingCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToShoppingCart.Location = new System.Drawing.Point(117, 270);
            this.btnAddToShoppingCart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddToShoppingCart.Name = "btnAddToShoppingCart";
            this.btnAddToShoppingCart.Size = new System.Drawing.Size(44, 32);
            this.btnAddToShoppingCart.TabIndex = 4;
            this.btnAddToShoppingCart.Text = "+";
            this.btnAddToShoppingCart.UseVisualStyleBackColor = false;
            this.btnAddToShoppingCart.Click += new System.EventHandler(this.btnAddToShoppingCart_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblProductName.Location = new System.Drawing.Point(2, 174);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(159, 37);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "ProductName";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            this.lblProductName.MouseLeave += new System.EventHandler(this.lblProductName_MouseLeave);
            this.lblProductName.MouseHover += new System.EventHandler(this.lblProductName_MouseHover);
            // 
            // lblSameDayDelivery
            // 
            this.lblSameDayDelivery.AutoSize = true;
            this.lblSameDayDelivery.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSameDayDelivery.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSameDayDelivery.Location = new System.Drawing.Point(2, 330);
            this.lblSameDayDelivery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSameDayDelivery.Name = "lblSameDayDelivery";
            this.lblSameDayDelivery.Size = new System.Drawing.Size(111, 13);
            this.lblSameDayDelivery.TabIndex = 7;
            this.lblSameDayDelivery.Text = "SameDayDelivery";
            // 
            // lblProductSummary
            // 
            this.lblProductSummary.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSummary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProductSummary.Location = new System.Drawing.Point(2, 216);
            this.lblProductSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductSummary.Name = "lblProductSummary";
            this.lblProductSummary.Size = new System.Drawing.Size(159, 37);
            this.lblProductSummary.TabIndex = 6;
            this.lblProductSummary.Text = "ProductSummary: blablabla ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblProductSummary);
            this.Controls.Add(this.lblSameDayDelivery);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnAddToShoppingCart);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "UserControlShop";
            this.Size = new System.Drawing.Size(167, 352);
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
        private System.Windows.Forms.Label lblSameDayDelivery;
        private System.Windows.Forms.Label lblProductSummary;
    }
}
