
namespace KaingaRealEstate
{
    partial class DeleteSellerForm
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
            this.btnDeleteSeller = new System.Windows.Forms.Button();
            this.cboSeller = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSellerID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSellerID = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblDeleteSeller = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(159, 99);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(20, 24);
            this.lblRequired.TabIndex = 33;
            this.lblRequired.Text = "*";
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(175, 69);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 32;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(560, 387);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 36);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.Location = new System.Drawing.Point(49, 387);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.Size = new System.Drawing.Size(124, 36);
            this.btnDeleteSeller.TabIndex = 30;
            this.btnDeleteSeller.Text = "Delete Seller";
            this.btnDeleteSeller.UseVisualStyleBackColor = true;
            this.btnDeleteSeller.Click += new System.EventHandler(this.btnDeleteSeller_Click);
            // 
            // cboSeller
            // 
            this.cboSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeller.FormattingEnabled = true;
            this.cboSeller.Location = new System.Drawing.Point(179, 96);
            this.cboSeller.MaxLength = 57;
            this.cboSeller.Name = "cboSeller";
            this.cboSeller.Size = new System.Drawing.Size(490, 32);
            this.cboSeller.TabIndex = 29;
            this.cboSeller.SelectedIndexChanged += new System.EventHandler(this.cboSeller_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(570, 145);
            this.txtStatus.MaxLength = 8;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 32);
            this.txtStatus.TabIndex = 28;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(179, 292);
            this.txtEmailAddress.MaxLength = 30;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(249, 32);
            this.txtEmailAddress.TabIndex = 27;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(179, 243);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(210, 32);
            this.txtFirstName.TabIndex = 26;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(179, 194);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(210, 32);
            this.txtLastName.TabIndex = 25;
            // 
            // txtSellerID
            // 
            this.txtSellerID.Location = new System.Drawing.Point(179, 145);
            this.txtSellerID.MaxLength = 7;
            this.txtSellerID.Name = "txtSellerID";
            this.txtSellerID.ReadOnly = true;
            this.txtSellerID.Size = new System.Drawing.Size(70, 32);
            this.txtSellerID.TabIndex = 24;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(496, 153);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 24);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Status:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(53, 299);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(133, 24);
            this.lblEmailAddress.TabIndex = 22;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(75, 249);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(76, 199);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 20;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblSellerID
            // 
            this.lblSellerID.AutoSize = true;
            this.lblSellerID.Location = new System.Drawing.Point(91, 149);
            this.lblSellerID.Name = "lblSellerID";
            this.lblSellerID.Size = new System.Drawing.Size(83, 24);
            this.lblSellerID.TabIndex = 19;
            this.lblSellerID.Text = "Seller ID:";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(109, 99);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(61, 24);
            this.lblSeller.TabIndex = 18;
            this.lblSeller.Text = "Seller:";
            // 
            // lblDeleteSeller
            // 
            this.lblDeleteSeller.AutoSize = true;
            this.lblDeleteSeller.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSeller.Location = new System.Drawing.Point(297, 25);
            this.lblDeleteSeller.Name = "lblDeleteSeller";
            this.lblDeleteSeller.Size = new System.Drawing.Size(174, 37);
            this.lblDeleteSeller.TabIndex = 17;
            this.lblDeleteSeller.Text = "Delete Seller";
            // 
            // DeleteSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 479);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteSeller);
            this.Controls.Add(this.cboSeller);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtSellerID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblSellerID);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.lblDeleteSeller);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteSellerForm";
            this.Text = "Delete Sellers";
            this.Load += new System.EventHandler(this.DeleteSellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteSeller;
        private System.Windows.Forms.ComboBox cboSeller;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSellerID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSellerID;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblDeleteSeller;
    }
}
