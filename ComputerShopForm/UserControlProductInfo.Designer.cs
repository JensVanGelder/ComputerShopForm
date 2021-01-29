
namespace ComputerShopForm
{
    partial class UserControlProductInfo
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
            this.pictureBoxProductInfo = new System.Windows.Forms.PictureBox();
            this.lblNameDontUse = new System.Windows.Forms.Label();
            this.lblPriceDontUse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.txtboxInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProductInfo
            // 
            this.pictureBoxProductInfo.Location = new System.Drawing.Point(18, 14);
            this.pictureBoxProductInfo.Name = "pictureBoxProductInfo";
            this.pictureBoxProductInfo.Size = new System.Drawing.Size(176, 198);
            this.pictureBoxProductInfo.TabIndex = 0;
            this.pictureBoxProductInfo.TabStop = false;
            // 
            // lblNameDontUse
            // 
            this.lblNameDontUse.AutoSize = true;
            this.lblNameDontUse.Location = new System.Drawing.Point(201, 14);
            this.lblNameDontUse.Name = "lblNameDontUse";
            this.lblNameDontUse.Size = new System.Drawing.Size(38, 13);
            this.lblNameDontUse.TabIndex = 1;
            this.lblNameDontUse.Text = "Name:";
            // 
            // lblPriceDontUse
            // 
            this.lblPriceDontUse.AutoSize = true;
            this.lblPriceDontUse.Location = new System.Drawing.Point(202, 41);
            this.lblPriceDontUse.Name = "lblPriceDontUse";
            this.lblPriceDontUse.Size = new System.Drawing.Size(34, 13);
            this.lblPriceDontUse.TabIndex = 3;
            this.lblPriceDontUse.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Extra info:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(295, 11);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(430, 20);
            this.txtBoxName.TabIndex = 8;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(295, 38);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(430, 20);
            this.txtBoxPrice.TabIndex = 9;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(295, 64);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(430, 20);
            this.txtBoxDescription.TabIndex = 10;
            // 
            // txtboxInfo
            // 
            this.txtboxInfo.Location = new System.Drawing.Point(295, 90);
            this.txtboxInfo.Multiline = true;
            this.txtboxInfo.Name = "txtboxInfo";
            this.txtboxInfo.Size = new System.Drawing.Size(430, 78);
            this.txtboxInfo.TabIndex = 11;
            // 
            // UserControlProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtboxInfo);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPriceDontUse);
            this.Controls.Add(this.lblNameDontUse);
            this.Controls.Add(this.pictureBoxProductInfo);
            this.Name = "UserControlProductInfo";
            this.Size = new System.Drawing.Size(781, 235);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProductInfo;
        private System.Windows.Forms.Label lblNameDontUse;
        private System.Windows.Forms.Label lblPriceDontUse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.TextBox txtboxInfo;
    }
}
