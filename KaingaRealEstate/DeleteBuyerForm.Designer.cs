
namespace KaingaRealEstate
{
    partial class DeleteBuyerForm
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteBuyer = new System.Windows.Forms.Button();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblDeleteBuyer = new System.Windows.Forms.Label();
            this.txtCreditStatus = new System.Windows.Forms.TextBox();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(491, 327);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(176, 32);
            this.txtCity.TabIndex = 71;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(431, 335);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 24);
            this.lblCity.TabIndex = 70;
            this.lblCity.Text = "City:";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(156, 89);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(20, 24);
            this.lblRequired.TabIndex = 69;
            this.lblRequired.Text = "*";
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(173, 59);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 68;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(569, 423);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 36);
            this.btnReturn.TabIndex = 67;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteBuyer
            // 
            this.btnDeleteBuyer.Location = new System.Drawing.Point(58, 423);
            this.btnDeleteBuyer.Name = "btnDeleteBuyer";
            this.btnDeleteBuyer.Size = new System.Drawing.Size(124, 36);
            this.btnDeleteBuyer.TabIndex = 66;
            this.btnDeleteBuyer.Text = "Delete Buyer";
            this.btnDeleteBuyer.UseVisualStyleBackColor = true;
            this.btnDeleteBuyer.Click += new System.EventHandler(this.btnDeleteBuyer_Click);
            // 
            // cboBuyer
            // 
            this.cboBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(177, 86);
            this.cboBuyer.MaxLength = 57;
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(490, 32);
            this.cboBuyer.TabIndex = 65;
            this.cboBuyer.SelectedIndexChanged += new System.EventHandler(this.cboBuyer_SelectedIndexChanged);
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(177, 328);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(170, 32);
            this.txtSuburb.TabIndex = 64;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(177, 282);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(403, 32);
            this.txtStreetAddress.TabIndex = 63;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(177, 233);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(217, 32);
            this.txtFirstName.TabIndex = 62;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(177, 184);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(217, 32);
            this.txtLastName.TabIndex = 61;
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(177, 135);
            this.txtBuyerID.MaxLength = 7;
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(70, 32);
            this.txtBuyerID.TabIndex = 60;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(99, 336);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 59;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(49, 289);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 58;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(73, 239);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 57;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(74, 189);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 56;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.AutoSize = true;
            this.lblBuyerID.Location = new System.Drawing.Point(88, 139);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(85, 24);
            this.lblBuyerID.TabIndex = 55;
            this.lblBuyerID.Text = "Buyer ID:";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Location = new System.Drawing.Point(106, 89);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(63, 24);
            this.lblBuyer.TabIndex = 54;
            this.lblBuyer.Text = "Buyer:";
            // 
            // lblDeleteBuyer
            // 
            this.lblDeleteBuyer.AutoSize = true;
            this.lblDeleteBuyer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteBuyer.Location = new System.Drawing.Point(309, 15);
            this.lblDeleteBuyer.Name = "lblDeleteBuyer";
            this.lblDeleteBuyer.Size = new System.Drawing.Size(178, 37);
            this.lblDeleteBuyer.TabIndex = 53;
            this.lblDeleteBuyer.Text = "Delete Buyer";
            // 
            // txtCreditStatus
            // 
            this.txtCreditStatus.Location = new System.Drawing.Point(598, 135);
            this.txtCreditStatus.MaxLength = 7;
            this.txtCreditStatus.Name = "txtCreditStatus";
            this.txtCreditStatus.ReadOnly = true;
            this.txtCreditStatus.Size = new System.Drawing.Size(68, 32);
            this.txtCreditStatus.TabIndex = 73;
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.AutoSize = true;
            this.lblCreditStatus.Location = new System.Drawing.Point(480, 143);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(123, 24);
            this.lblCreditStatus.TabIndex = 72;
            this.lblCreditStatus.Text = "Credit Status:";
            // 
            // DeleteBuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 500);
            this.Controls.Add(this.txtCreditStatus);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteBuyer);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.lblDeleteBuyer);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteBuyerForm";
            this.Text = "Delete Buyers";
            this.Load += new System.EventHandler(this.DeleteBuyerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteBuyer;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblDeleteBuyer;
        private System.Windows.Forms.TextBox txtCreditStatus;
        private System.Windows.Forms.Label lblCreditStatus;
    }
}
