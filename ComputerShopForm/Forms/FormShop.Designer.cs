
namespace ComputerShopForm
{
    partial class FormShop
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShop));
            this.flowMainShopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.pnlMidTop = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.picBallBox = new System.Windows.Forms.PictureBox();
            this.pnlTopRightButton = new System.Windows.Forms.Panel();
            this.lblItemsInCart = new System.Windows.Forms.Label();
            this.picCartButtonCircle = new System.Windows.Forms.PictureBox();
            this.pnlLeftSortOptions = new System.Windows.Forms.Panel();
            this.grpBoxComp = new System.Windows.Forms.GroupBox();
            this.radLaptop = new System.Windows.Forms.RadioButton();
            this.radWorkstation = new System.Windows.Forms.RadioButton();
            this.radGamingPc = new System.Windows.Forms.RadioButton();
            this.picSocialMedia = new System.Windows.Forms.PictureBox();
            this.btnShoppingCart = new ComputerShopForm.RoundButton();
            this.pnlMidTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBallBox)).BeginInit();
            this.pnlTopRightButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartButtonCircle)).BeginInit();
            this.pnlLeftSortOptions.SuspendLayout();
            this.grpBoxComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSocialMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // flowMainShopPanel
            // 
            this.flowMainShopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowMainShopPanel.AutoScroll = true;
            this.flowMainShopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowMainShopPanel.BackColor = System.Drawing.Color.White;
            this.flowMainShopPanel.Location = new System.Drawing.Point(259, 100);
            this.flowMainShopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowMainShopPanel.Name = "flowMainShopPanel";
            this.flowMainShopPanel.Size = new System.Drawing.Size(843, 499);
            this.flowMainShopPanel.TabIndex = 2;
            // 
            // btnTemp
            // 
            this.btnTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemp.ForeColor = System.Drawing.Color.White;
            this.btnTemp.Location = new System.Drawing.Point(10, 15);
            this.btnTemp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(91, 27);
            this.btnTemp.TabIndex = 4;
            this.btnTemp.Text = "button2";
            this.btnTemp.UseVisualStyleBackColor = false;
            this.btnTemp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(121, 15);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(91, 27);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Showall";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(349, 51);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchBar.MaximumSize = new System.Drawing.Size(570, 21);
            this.txtSearchBar.MinimumSize = new System.Drawing.Size(7, 7);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchBar.Size = new System.Drawing.Size(570, 22);
            this.txtSearchBar.TabIndex = 5;
            this.txtSearchBar.Text = "What are you looking for?";
            this.txtSearchBar.Enter += new System.EventHandler(this.txtSearchBar_Enter);
            this.txtSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBar_KeyDown);
            // 
            // pnlMidTop
            // 
            this.pnlMidTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlMidTop.Controls.Add(this.lblSubTitle);
            this.pnlMidTop.Controls.Add(this.lblCompanyName);
            this.pnlMidTop.Controls.Add(this.picBallBox);
            this.pnlMidTop.Controls.Add(this.pnlTopRightButton);
            this.pnlMidTop.Controls.Add(this.txtSearchBar);
            this.pnlMidTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMidTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMidTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMidTop.Name = "pnlMidTop";
            this.pnlMidTop.Size = new System.Drawing.Size(1102, 100);
            this.pnlMidTop.TabIndex = 6;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(207, 53);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(88, 23);
            this.lblSubTitle.TabIndex = 10;
            this.lblSubTitle.Text = "GLOBAL";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Location = new System.Drawing.Point(105, 11);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(195, 42);
            this.lblCompanyName.TabIndex = 6;
            this.lblCompanyName.Text = "BLUEBALL";
            // 
            // picBallBox
            // 
            this.picBallBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picBallBox.Image = global::ComputerShopForm.Properties.Resources.blueball;
            this.picBallBox.Location = new System.Drawing.Point(0, 0);
            this.picBallBox.Name = "picBallBox";
            this.picBallBox.Size = new System.Drawing.Size(133, 100);
            this.picBallBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBallBox.TabIndex = 7;
            this.picBallBox.TabStop = false;
            // 
            // pnlTopRightButton
            // 
            this.pnlTopRightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopRightButton.Controls.Add(this.lblItemsInCart);
            this.pnlTopRightButton.Controls.Add(this.picCartButtonCircle);
            this.pnlTopRightButton.Controls.Add(this.btnShoppingCart);
            this.pnlTopRightButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRightButton.Location = new System.Drawing.Point(993, 0);
            this.pnlTopRightButton.Name = "pnlTopRightButton";
            this.pnlTopRightButton.Size = new System.Drawing.Size(109, 100);
            this.pnlTopRightButton.TabIndex = 0;
            // 
            // lblItemsInCart
            // 
            this.lblItemsInCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemsInCart.BackColor = System.Drawing.Color.White;
            this.lblItemsInCart.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsInCart.Location = new System.Drawing.Point(73, 11);
            this.lblItemsInCart.Name = "lblItemsInCart";
            this.lblItemsInCart.Size = new System.Drawing.Size(18, 15);
            this.lblItemsInCart.TabIndex = 8;
            this.lblItemsInCart.Text = "0";
            this.lblItemsInCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemsInCart.Visible = false;
            // 
            // picCartButtonCircle
            // 
            this.picCartButtonCircle.BackgroundImage = global::ComputerShopForm.Properties.Resources.wdotsmaller;
            this.picCartButtonCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCartButtonCircle.InitialImage = null;
            this.picCartButtonCircle.Location = new System.Drawing.Point(69, 6);
            this.picCartButtonCircle.Name = "picCartButtonCircle";
            this.picCartButtonCircle.Size = new System.Drawing.Size(25, 25);
            this.picCartButtonCircle.TabIndex = 10;
            this.picCartButtonCircle.TabStop = false;
            this.picCartButtonCircle.Visible = false;
            // 
            // pnlLeftSortOptions
            // 
            this.pnlLeftSortOptions.AutoScroll = true;
            this.pnlLeftSortOptions.BackColor = System.Drawing.Color.White;
            this.pnlLeftSortOptions.Controls.Add(this.picSocialMedia);
            this.pnlLeftSortOptions.Controls.Add(this.grpBoxComp);
            this.pnlLeftSortOptions.Controls.Add(this.btnShowAll);
            this.pnlLeftSortOptions.Controls.Add(this.btnTemp);
            this.pnlLeftSortOptions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLeftSortOptions.Location = new System.Drawing.Point(0, 100);
            this.pnlLeftSortOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLeftSortOptions.Name = "pnlLeftSortOptions";
            this.pnlLeftSortOptions.Size = new System.Drawing.Size(251, 499);
            this.pnlLeftSortOptions.TabIndex = 7;
            // 
            // grpBoxComp
            // 
            this.grpBoxComp.Controls.Add(this.radLaptop);
            this.grpBoxComp.Controls.Add(this.radWorkstation);
            this.grpBoxComp.Controls.Add(this.radGamingPc);
            this.grpBoxComp.Location = new System.Drawing.Point(12, 59);
            this.grpBoxComp.Name = "grpBoxComp";
            this.grpBoxComp.Size = new System.Drawing.Size(200, 93);
            this.grpBoxComp.TabIndex = 11;
            this.grpBoxComp.TabStop = false;
            this.grpBoxComp.Text = "Computer";
            // 
            // radLaptop
            // 
            this.radLaptop.AutoSize = true;
            this.radLaptop.Location = new System.Drawing.Point(6, 67);
            this.radLaptop.Name = "radLaptop";
            this.radLaptop.Size = new System.Drawing.Size(63, 17);
            this.radLaptop.TabIndex = 2;
            this.radLaptop.TabStop = true;
            this.radLaptop.Text = "Laptop";
            this.radLaptop.UseVisualStyleBackColor = true;
            // 
            // radWorkstation
            // 
            this.radWorkstation.AutoSize = true;
            this.radWorkstation.Location = new System.Drawing.Point(5, 44);
            this.radWorkstation.Name = "radWorkstation";
            this.radWorkstation.Size = new System.Drawing.Size(92, 17);
            this.radWorkstation.TabIndex = 1;
            this.radWorkstation.TabStop = true;
            this.radWorkstation.Text = "Workstation";
            this.radWorkstation.UseVisualStyleBackColor = true;
            // 
            // radGamingPc
            // 
            this.radGamingPc.AutoSize = true;
            this.radGamingPc.Location = new System.Drawing.Point(6, 21);
            this.radGamingPc.Name = "radGamingPc";
            this.radGamingPc.Size = new System.Drawing.Size(86, 17);
            this.radGamingPc.TabIndex = 0;
            this.radGamingPc.TabStop = true;
            this.radGamingPc.Text = "Gaming Pc";
            this.radGamingPc.UseVisualStyleBackColor = true;
            // 
            // picSocialMedia
            // 
            this.picSocialMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSocialMedia.BackColor = System.Drawing.Color.White;
            this.picSocialMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSocialMedia.Image = global::ComputerShopForm.Properties.Resources.Social_Media_banner;
            this.picSocialMedia.Location = new System.Drawing.Point(3, 450);
            this.picSocialMedia.Name = "picSocialMedia";
            this.picSocialMedia.Size = new System.Drawing.Size(245, 46);
            this.picSocialMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSocialMedia.TabIndex = 10;
            this.picSocialMedia.TabStop = false;
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShoppingCart.BackgroundImage = global::ComputerShopForm.Properties.Resources.cartWsmall2;
            this.btnShoppingCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShoppingCart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoppingCart.Location = new System.Drawing.Point(12, 5);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(85, 85);
            this.btnShoppingCart.TabIndex = 7;
            this.btnShoppingCart.Text = "0";
            this.btnShoppingCart.Click += new System.EventHandler(this.rndbtnShoppingCart_Click);
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 599);
            this.Controls.Add(this.pnlLeftSortOptions);
            this.Controls.Add(this.flowMainShopPanel);
            this.Controls.Add(this.pnlMidTop);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormShop";
            this.pnlMidTop.ResumeLayout(false);
            this.pnlMidTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBallBox)).EndInit();
            this.pnlTopRightButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCartButtonCircle)).EndInit();
            this.pnlLeftSortOptions.ResumeLayout(false);
            this.grpBoxComp.ResumeLayout(false);
            this.grpBoxComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSocialMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowMainShopPanel;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Panel pnlMidTop;
        private System.Windows.Forms.Panel pnlLeftSortOptions;
        private RoundButton btnShoppingCart;
        private System.Windows.Forms.Label lblItemsInCart;
        private System.Windows.Forms.PictureBox picSocialMedia;
        private System.Windows.Forms.PictureBox picBallBox;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Panel pnlTopRightButton;
        private System.Windows.Forms.PictureBox picCartButtonCircle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.GroupBox grpBoxComp;
        private System.Windows.Forms.RadioButton radLaptop;
        private System.Windows.Forms.RadioButton radWorkstation;
        private System.Windows.Forms.RadioButton radGamingPc;
    }
}

