
namespace KaingaRealEstate
{
    partial class DeletePropertyForm
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
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.cboProperty = new System.Windows.Forms.ComboBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblDeleteProperty = new System.Windows.Forms.Label();
            this.txtSellerFirstName = new System.Windows.Forms.TextBox();
            this.txtSellerLastName = new System.Windows.Forms.TextBox();
            this.lblSellerFirstName = new System.Windows.Forms.Label();
            this.lblSellerLastName = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.txtPropertyDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(216, 104);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(20, 24);
            this.lblRequired.TabIndex = 90;
            this.lblRequired.Text = "*";
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(233, 67);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 89;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(512, 438);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(128, 36);
            this.btnReturn.TabIndex = 88;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(75, 438);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(124, 36);
            this.btnDeleteProperty.TabIndex = 87;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // cboProperty
            // 
            this.cboProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProperty.FormattingEnabled = true;
            this.cboProperty.Location = new System.Drawing.Point(237, 101);
            this.cboProperty.MaxLength = 57;
            this.cboProperty.Name = "cboProperty";
            this.cboProperty.Size = new System.Drawing.Size(403, 32);
            this.cboProperty.TabIndex = 86;
            this.cboProperty.SelectedIndexChanged += new System.EventHandler(this.cboProperty_SelectedIndexChanged);
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(237, 195);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(403, 32);
            this.txtStreetAddress.TabIndex = 84;
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(237, 148);
            this.txtPropertyID.MaxLength = 7;
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(70, 32);
            this.txtPropertyID.TabIndex = 81;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(109, 199);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 79;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Location = new System.Drawing.Point(130, 151);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(109, 24);
            this.lblPropertyID.TabIndex = 76;
            this.lblPropertyID.Text = "Property ID:";
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(150, 103);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(87, 24);
            this.lblProperty.TabIndex = 75;
            this.lblProperty.Text = "Property:";
            // 
            // lblDeleteProperty
            // 
            this.lblDeleteProperty.AutoSize = true;
            this.lblDeleteProperty.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteProperty.Location = new System.Drawing.Point(283, 30);
            this.lblDeleteProperty.Name = "lblDeleteProperty";
            this.lblDeleteProperty.Size = new System.Drawing.Size(214, 37);
            this.lblDeleteProperty.TabIndex = 74;
            this.lblDeleteProperty.Text = "Delete Property";
            // 
            // txtSellerFirstName
            // 
            this.txtSellerFirstName.Location = new System.Drawing.Point(237, 357);
            this.txtSellerFirstName.MaxLength = 25;
            this.txtSellerFirstName.Name = "txtSellerFirstName";
            this.txtSellerFirstName.ReadOnly = true;
            this.txtSellerFirstName.Size = new System.Drawing.Size(217, 32);
            this.txtSellerFirstName.TabIndex = 96;
            // 
            // txtSellerLastName
            // 
            this.txtSellerLastName.Location = new System.Drawing.Point(237, 310);
            this.txtSellerLastName.MaxLength = 25;
            this.txtSellerLastName.Name = "txtSellerLastName";
            this.txtSellerLastName.ReadOnly = true;
            this.txtSellerLastName.Size = new System.Drawing.Size(217, 32);
            this.txtSellerLastName.TabIndex = 95;
            // 
            // lblSellerFirstName
            // 
            this.lblSellerFirstName.AutoSize = true;
            this.lblSellerFirstName.Location = new System.Drawing.Point(93, 363);
            this.lblSellerFirstName.Name = "lblSellerFirstName";
            this.lblSellerFirstName.Size = new System.Drawing.Size(156, 24);
            this.lblSellerFirstName.TabIndex = 94;
            this.lblSellerFirstName.Text = "Seller First Name:";
            // 
            // lblSellerLastName
            // 
            this.lblSellerLastName.AutoSize = true;
            this.lblSellerLastName.Location = new System.Drawing.Point(94, 311);
            this.lblSellerLastName.Name = "lblSellerLastName";
            this.lblSellerLastName.Size = new System.Drawing.Size(153, 24);
            this.lblSellerLastName.TabIndex = 93;
            this.lblSellerLastName.Text = "Seller Last Name:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(71, 245);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(186, 24);
            this.lblSuburb.TabIndex = 80;
            this.lblSuburb.Text = "Property Description:";
            // 
            // txtPropertyDescription
            // 
            this.txtPropertyDescription.Location = new System.Drawing.Point(237, 242);
            this.txtPropertyDescription.MaxLength = 50;
            this.txtPropertyDescription.Multiline = true;
            this.txtPropertyDescription.Name = "txtPropertyDescription";
            this.txtPropertyDescription.ReadOnly = true;
            this.txtPropertyDescription.Size = new System.Drawing.Size(217, 48);
            this.txtPropertyDescription.TabIndex = 85;
            // 
            // DeletePropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 505);
            this.Controls.Add(this.txtSellerFirstName);
            this.Controls.Add(this.txtSellerLastName);
            this.Controls.Add(this.lblSellerFirstName);
            this.Controls.Add(this.lblSellerLastName);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.cboProperty);
            this.Controls.Add(this.txtPropertyDescription);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.lblDeleteProperty);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeletePropertyForm";
            this.Text = "Delete Properties";
            this.Load += new System.EventHandler(this.DeletePropertyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.ComboBox cboProperty;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.Label lblDeleteProperty;
        private System.Windows.Forms.TextBox txtSellerFirstName;
        private System.Windows.Forms.TextBox txtSellerLastName;
        private System.Windows.Forms.Label lblSellerFirstName;
        private System.Windows.Forms.Label lblSellerLastName;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtPropertyDescription;
    }
}
