
namespace KaingaRealEstate
{
    partial class UpdatePropertyForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.txtPropertyDescription = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.cboProperties = new System.Windows.Forms.ComboBox();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.lblSellerLastName = new System.Windows.Forms.Label();
            this.lblPropertyDescription = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSellerFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(258, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Update Property";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(203, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 126;
            this.label2.Text = "*";
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(222, 372);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.ReadOnly = true;
            this.txtCategoryDescription.Size = new System.Drawing.Size(343, 27);
            this.txtCategoryDescription.TabIndex = 125;
            // 
            // txtPropertyDescription
            // 
            this.txtPropertyDescription.Location = new System.Drawing.Point(222, 280);
            this.txtPropertyDescription.MaxLength = 50;
            this.txtPropertyDescription.Name = "txtPropertyDescription";
            this.txtPropertyDescription.Size = new System.Drawing.Size(408, 27);
            this.txtPropertyDescription.TabIndex = 123;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(222, 188);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(408, 27);
            this.txtStreetAddress.TabIndex = 122;
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(222, 142);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(79, 27);
            this.txtPropertyID.TabIndex = 121;
            // 
            // cboProperties
            // 
            this.cboProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProperties.FormattingEnabled = true;
            this.cboProperties.Location = new System.Drawing.Point(222, 96);
            this.cboProperties.Name = "cboProperties";
            this.cboProperties.Size = new System.Drawing.Size(473, 27);
            this.cboProperties.TabIndex = 120;
            this.cboProperties.SelectedIndexChanged += new System.EventHandler(this.cboProperties_SelectedIndexChanged);
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.Location = new System.Drawing.Point(11, 375);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(195, 24);
            this.lblCategoryDescription.TabIndex = 119;
            this.lblCategoryDescription.Text = "Category Description:";
            this.lblCategoryDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSellerLastName
            // 
            this.lblSellerLastName.Location = new System.Drawing.Point(53, 421);
            this.lblSellerLastName.Name = "lblSellerLastName";
            this.lblSellerLastName.Size = new System.Drawing.Size(153, 24);
            this.lblSellerLastName.TabIndex = 118;
            this.lblSellerLastName.Text = "Seller Last Name:";
            this.lblSellerLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPropertyDescription
            // 
            this.lblPropertyDescription.Location = new System.Drawing.Point(20, 283);
            this.lblPropertyDescription.Name = "lblPropertyDescription";
            this.lblPropertyDescription.Size = new System.Drawing.Size(186, 24);
            this.lblPropertyDescription.TabIndex = 117;
            this.lblPropertyDescription.Text = "Property Description:";
            this.lblPropertyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.Location = new System.Drawing.Point(69, 191);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 116;
            this.lblStreetAddress.Text = "Street Address:";
            this.lblStreetAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.Location = new System.Drawing.Point(97, 145);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(109, 24);
            this.lblPropertyID.TabIndex = 115;
            this.lblPropertyID.Text = "Property ID:";
            this.lblPropertyID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProperty
            // 
            this.lblProperty.Location = new System.Drawing.Point(119, 99);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(87, 24);
            this.lblProperty.TabIndex = 114;
            this.lblProperty.Text = "Property:";
            this.lblProperty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInstruction.Location = new System.Drawing.Point(219, 69);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(163, 19);
            this.lblInstruction.TabIndex = 170;
            this.lblInstruction.Text = "Please select a property";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(524, 142);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(165, 27);
            this.txtStatus.TabIndex = 174;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(419, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 24);
            this.lblStatus.TabIndex = 172;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(115, 329);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(91, 24);
            this.lblPrice.TabIndex = 171;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(222, 418);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(215, 27);
            this.txtLastName.TabIndex = 177;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(222, 234);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(165, 27);
            this.txtSuburb.TabIndex = 179;
            // 
            // lblSuburb
            // 
            this.lblSuburb.Location = new System.Drawing.Point(119, 237);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(87, 24);
            this.lblSuburb.TabIndex = 178;
            this.lblSuburb.Text = "Suburb:";
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(222, 326);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(123, 27);
            this.nudPrice.TabIndex = 180;
            this.nudPrice.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(203, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 181;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(202, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 182;
            this.label3.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(219, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 19);
            this.label9.TabIndex = 183;
            this.label9.Text = "*Cannot be left blank";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(444, 538);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(196, 48);
            this.btnReturn.TabIndex = 185;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(95, 538);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(196, 48);
            this.btnUpdateProperty.TabIndex = 184;
            this.btnUpdateProperty.Text = "Update Property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(223, 464);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(215, 27);
            this.txtFirstName.TabIndex = 187;
            // 
            // lblSellerFirstName
            // 
            this.lblSellerFirstName.Location = new System.Drawing.Point(20, 467);
            this.lblSellerFirstName.Name = "lblSellerFirstName";
            this.lblSellerFirstName.Size = new System.Drawing.Size(186, 24);
            this.lblSellerFirstName.TabIndex = 186;
            this.lblSellerFirstName.Text = "Seller First Name:";
            this.lblSellerFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdatePropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 598);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblSellerFirstName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.txtPropertyDescription);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.cboProperties);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.lblSellerLastName);
            this.Controls.Add(this.lblPropertyDescription);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdatePropertyForm";
            this.Text = "Update Properties";
            this.Load += new System.EventHandler(this.UpdatePropertyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtPropertyDescription;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.ComboBox cboProperties;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Label lblSellerLastName;
        private System.Windows.Forms.Label lblPropertyDescription;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSellerFirstName;
    }
}