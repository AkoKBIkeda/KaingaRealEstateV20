
namespace KaingaRealEstate
{
    partial class SellPropertyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblPropertyDescription = new System.Windows.Forms.Label();
            this.lblSellerLastName = new System.Windows.Forms.Label();
            this.lblSellerFirstName = new System.Windows.Forms.Label();
            this.lblOffers = new System.Windows.Forms.Label();
            this.cboProperties = new System.Windows.Forms.ComboBox();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtPropertyDescription = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lstOffers = new System.Windows.Forms.ListBox();
            this.btnSellProperty = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sell Property";
            // 
            // lblProperty
            // 
            this.lblProperty.Location = new System.Drawing.Point(98, 97);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(87, 24);
            this.lblProperty.TabIndex = 1;
            this.lblProperty.Text = "Property:";
            this.lblProperty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.Location = new System.Drawing.Point(76, 144);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(109, 24);
            this.lblPropertyID.TabIndex = 2;
            this.lblPropertyID.Text = "Property ID:";
            this.lblPropertyID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.Location = new System.Drawing.Point(48, 191);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Street Address:";
            this.lblStreetAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPropertyDescription
            // 
            this.lblPropertyDescription.Location = new System.Drawing.Point(-1, 238);
            this.lblPropertyDescription.Name = "lblPropertyDescription";
            this.lblPropertyDescription.Size = new System.Drawing.Size(186, 24);
            this.lblPropertyDescription.TabIndex = 4;
            this.lblPropertyDescription.Text = "Property Description:";
            this.lblPropertyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSellerLastName
            // 
            this.lblSellerLastName.Location = new System.Drawing.Point(32, 285);
            this.lblSellerLastName.Name = "lblSellerLastName";
            this.lblSellerLastName.Size = new System.Drawing.Size(153, 24);
            this.lblSellerLastName.TabIndex = 5;
            this.lblSellerLastName.Text = "Seller Last Name:";
            this.lblSellerLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSellerFirstName
            // 
            this.lblSellerFirstName.Location = new System.Drawing.Point(29, 332);
            this.lblSellerFirstName.Name = "lblSellerFirstName";
            this.lblSellerFirstName.Size = new System.Drawing.Size(156, 24);
            this.lblSellerFirstName.TabIndex = 6;
            this.lblSellerFirstName.Text = "Seller First Name:";
            this.lblSellerFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOffers
            // 
            this.lblOffers.Location = new System.Drawing.Point(102, 374);
            this.lblOffers.Name = "lblOffers";
            this.lblOffers.Size = new System.Drawing.Size(83, 24);
            this.lblOffers.TabIndex = 7;
            this.lblOffers.Text = "Offers:";
            this.lblOffers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProperties
            // 
            this.cboProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProperties.FormattingEnabled = true;
            this.cboProperties.Location = new System.Drawing.Point(198, 94);
            this.cboProperties.Name = "cboProperties";
            this.cboProperties.Size = new System.Drawing.Size(473, 27);
            this.cboProperties.TabIndex = 8;
            this.cboProperties.SelectedIndexChanged += new System.EventHandler(this.cboProperties_SelectedIndexChanged);
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(198, 141);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(79, 27);
            this.txtPropertyID.TabIndex = 9;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(198, 188);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(427, 27);
            this.txtStreetAddress.TabIndex = 10;
            // 
            // txtPropertyDescription
            // 
            this.txtPropertyDescription.Location = new System.Drawing.Point(198, 235);
            this.txtPropertyDescription.Name = "txtPropertyDescription";
            this.txtPropertyDescription.ReadOnly = true;
            this.txtPropertyDescription.Size = new System.Drawing.Size(427, 27);
            this.txtPropertyDescription.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(198, 282);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(211, 27);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(198, 329);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(211, 27);
            this.txtFirstName.TabIndex = 13;
            // 
            // lstOffers
            // 
            this.lstOffers.FormattingEnabled = true;
            this.lstOffers.ItemHeight = 19;
            this.lstOffers.Location = new System.Drawing.Point(198, 374);
            this.lstOffers.Name = "lstOffers";
            this.lstOffers.Size = new System.Drawing.Size(593, 118);
            this.lstOffers.TabIndex = 14;
            this.lstOffers.SelectedIndexChanged += new System.EventHandler(this.lstOffers_SelectedIndexChanged);
            // 
            // btnSellProperty
            // 
            this.btnSellProperty.Location = new System.Drawing.Point(80, 533);
            this.btnSellProperty.Name = "btnSellProperty";
            this.btnSellProperty.Size = new System.Drawing.Size(230, 48);
            this.btnSellProperty.TabIndex = 15;
            this.btnSellProperty.Text = "Sell Property";
            this.btnSellProperty.UseVisualStyleBackColor = true;
            this.btnSellProperty.Click += new System.EventHandler(this.btnSellProperty_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(561, 533);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(230, 48);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(194, 67);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(166, 19);
            this.lblPleaseSelectAnOption.TabIndex = 111;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(178, 364);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(17, 19);
            this.lblRequired.TabIndex = 112;
            this.lblRequired.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(178, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 113;
            this.label2.Text = "*";
            // 
            // SellPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSellProperty);
            this.Controls.Add(this.lstOffers);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPropertyDescription);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.cboProperties);
            this.Controls.Add(this.lblOffers);
            this.Controls.Add(this.lblSellerFirstName);
            this.Controls.Add(this.lblSellerLastName);
            this.Controls.Add(this.lblPropertyDescription);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellPropertyForm";
            this.Text = "Sell Properties";
            this.Load += new System.EventHandler(this.SellPropertyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblPropertyDescription;
        private System.Windows.Forms.Label lblSellerLastName;
        private System.Windows.Forms.Label lblSellerFirstName;
        private System.Windows.Forms.Label lblOffers;
        private System.Windows.Forms.ComboBox cboProperties;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtPropertyDescription;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ListBox lstOffers;
        private System.Windows.Forms.Button btnSellProperty;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label2;
    }
}