
namespace KaingaRealEstate
{
    partial class AddOfferForm
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
            this.btnAddOffer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuyers = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboBuyers = new System.Windows.Forms.ComboBox();
            this.cboProperties = new System.Windows.Forms.ComboBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.nudOfferAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblOfferAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudOfferAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddOffer
            // 
            this.btnAddOffer.Location = new System.Drawing.Point(165, 508);
            this.btnAddOffer.Name = "btnAddOffer";
            this.btnAddOffer.Size = new System.Drawing.Size(141, 44);
            this.btnAddOffer.TabIndex = 0;
            this.btnAddOffer.Text = "Add Offer";
            this.btnAddOffer.UseVisualStyleBackColor = true;
            this.btnAddOffer.Click += new System.EventHandler(this.btnAddOffer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(494, 508);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 44);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Offer";
            // 
            // lblBuyers
            // 
            this.lblBuyers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBuyers.Location = new System.Drawing.Point(122, 96);
            this.lblBuyers.Name = "lblBuyers";
            this.lblBuyers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBuyers.Size = new System.Drawing.Size(71, 24);
            this.lblBuyers.TabIndex = 3;
            this.lblBuyers.Text = "Buyers:";
            this.lblBuyers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBuyerID.Location = new System.Drawing.Point(108, 135);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(85, 24);
            this.lblBuyerID.TabIndex = 4;
            this.lblBuyerID.Text = "Buyer ID:";
            this.lblBuyerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastName.Location = new System.Drawing.Point(91, 174);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.Location = new System.Drawing.Point(452, 174);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmailAddress.Location = new System.Drawing.Point(60, 213);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmailAddress.Size = new System.Drawing.Size(133, 24);
            this.lblEmailAddress.TabIndex = 8;
            this.lblEmailAddress.Text = "Email Address:";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(52, 252);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhoneNumber.Size = new System.Drawing.Size(141, 24);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProperties
            // 
            this.lblProperties.Location = new System.Drawing.Point(11, 291);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProperties.Size = new System.Drawing.Size(182, 24);
            this.lblProperties.TabIndex = 10;
            this.lblProperties.Text = "Available Properties:";
            this.lblProperties.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.Location = new System.Drawing.Point(84, 330);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(109, 24);
            this.lblPropertyID.TabIndex = 11;
            this.lblPropertyID.Text = "Property ID:";
            this.lblPropertyID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(84, 369);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(109, 24);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBuyers
            // 
            this.cboBuyers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuyers.FormattingEnabled = true;
            this.cboBuyers.Location = new System.Drawing.Point(213, 93);
            this.cboBuyers.Name = "cboBuyers";
            this.cboBuyers.Size = new System.Drawing.Size(454, 32);
            this.cboBuyers.TabIndex = 15;
            this.cboBuyers.SelectedIndexChanged += new System.EventHandler(this.cboBuyers_SelectedIndexChanged);
            // 
            // cboProperties
            // 
            this.cboProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProperties.FormattingEnabled = true;
            this.cboProperties.Location = new System.Drawing.Point(213, 285);
            this.cboProperties.Name = "cboProperties";
            this.cboProperties.Size = new System.Drawing.Size(454, 32);
            this.cboProperties.TabIndex = 16;
            this.cboProperties.SelectedIndexChanged += new System.EventHandler(this.cboProperties_SelectedIndexChanged);
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(213, 132);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(69, 32);
            this.txtBuyerID.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(561, 171);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(221, 32);
            this.txtFirstName.TabIndex = 18;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(213, 209);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(283, 32);
            this.txtEmailAddress.TabIndex = 19;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(213, 247);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(135, 32);
            this.txtPhoneNumber.TabIndex = 20;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(213, 171);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(221, 32);
            this.txtLastName.TabIndex = 21;
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(213, 323);
            this.txtPropertyID.MaxLength = 8;
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(69, 32);
            this.txtPropertyID.TabIndex = 22;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(213, 361);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(411, 39);
            this.txtDescription.TabIndex = 23;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(213, 406);
            this.txtStreetAddress.MaxLength = 25;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(411, 32);
            this.txtStreetAddress.TabIndex = 24;
            // 
            // nudOfferAmount
            // 
            this.nudOfferAmount.DecimalPlaces = 2;
            this.nudOfferAmount.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudOfferAmount.Location = new System.Drawing.Point(213, 470);
            this.nudOfferAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudOfferAmount.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudOfferAmount.Name = "nudOfferAmount";
            this.nudOfferAmount.Size = new System.Drawing.Size(135, 32);
            this.nudOfferAmount.TabIndex = 27;
            this.nudOfferAmount.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(365, 330);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 24);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.Location = new System.Drawing.Point(56, 408);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 29;
            this.lblStreetAddress.Text = "Street Address:";
            this.lblStreetAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(429, 323);
            this.txtPrice.MaxLength = 25;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(106, 32);
            this.txtPrice.TabIndex = 30;
            // 
            // lblOfferAmount
            // 
            this.lblOfferAmount.Location = new System.Drawing.Point(63, 473);
            this.lblOfferAmount.Name = "lblOfferAmount";
            this.lblOfferAmount.Size = new System.Drawing.Size(130, 24);
            this.lblOfferAmount.TabIndex = 31;
            this.lblOfferAmount.Text = "Offer Amount:";
            this.lblOfferAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(188, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(188, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(209, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "**Please enter required details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(209, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "*Please select an option";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(180, 462);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "**";
            // 
            // AddOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 574);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOfferAmount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.nudOfferAmount);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.cboProperties);
            this.Controls.Add(this.cboBuyers);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddOffer);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOfferForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Add Offers";
            this.Load += new System.EventHandler(this.AddOfferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOfferAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOffer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuyers;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cboBuyers;
        private System.Windows.Forms.ComboBox cboProperties;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.NumericUpDown nudOfferAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblOfferAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
