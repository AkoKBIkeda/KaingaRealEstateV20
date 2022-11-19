
namespace KaingaRealEstate
{
    partial class AssignBuyerCategoryForm
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
            this.txtCreditStatus = new System.Windows.Forms.TextBox();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAssignBuyerCategory = new System.Windows.Forms.Button();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.lblImportance = new System.Windows.Forms.Label();
            this.lblCategoryAssign = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblAssignBuyerCategory = new System.Windows.Forms.Label();
            this.cboImportance = new System.Windows.Forms.ComboBox();
            this.lstCategoryAssign = new System.Windows.Forms.ListBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCreditStatus
            // 
            this.txtCreditStatus.Location = new System.Drawing.Point(592, 175);
            this.txtCreditStatus.MaxLength = 7;
            this.txtCreditStatus.Name = "txtCreditStatus";
            this.txtCreditStatus.ReadOnly = true;
            this.txtCreditStatus.Size = new System.Drawing.Size(70, 32);
            this.txtCreditStatus.TabIndex = 94;
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.AutoSize = true;
            this.lblCreditStatus.Location = new System.Drawing.Point(474, 183);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(123, 24);
            this.lblCreditStatus.TabIndex = 93;
            this.lblCreditStatus.Text = "Credit Status:";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(151, 79);
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
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(167, 53);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 89;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(495, 438);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(165, 36);
            this.btnReturn.TabIndex = 88;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAssignBuyerCategory
            // 
            this.btnAssignBuyerCategory.Location = new System.Drawing.Point(67, 438);
            this.btnAssignBuyerCategory.Name = "btnAssignBuyerCategory";
            this.btnAssignBuyerCategory.Size = new System.Drawing.Size(165, 36);
            this.btnAssignBuyerCategory.TabIndex = 87;
            this.btnAssignBuyerCategory.Text = "Assign Buyer Category";
            this.btnAssignBuyerCategory.UseVisualStyleBackColor = true;
            this.btnAssignBuyerCategory.Click += new System.EventHandler(this.btnAssignBuyerCategory_Click);
            // 
            // cboBuyer
            // 
            this.cboBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(171, 80);
            this.cboBuyer.MaxLength = 57;
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(490, 32);
            this.cboBuyer.TabIndex = 86;
            this.cboBuyer.SelectedIndexChanged += new System.EventHandler(this.cboBuyer_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(171, 180);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(217, 32);
            this.txtFirstName.TabIndex = 83;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(171, 131);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(217, 32);
            this.txtLastName.TabIndex = 82;
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(591, 131);
            this.txtBuyerID.MaxLength = 7;
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(70, 32);
            this.txtBuyerID.TabIndex = 81;
            this.txtBuyerID.Text = " ";
            // 
            // lblImportance
            // 
            this.lblImportance.Location = new System.Drawing.Point(42, 387);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(111, 24);
            this.lblImportance.TabIndex = 80;
            this.lblImportance.Text = "Importance:";
            this.lblImportance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategoryAssign
            // 
            this.lblCategoryAssign.Location = new System.Drawing.Point(6, 236);
            this.lblCategoryAssign.Name = "lblCategoryAssign";
            this.lblCategoryAssign.Size = new System.Drawing.Size(147, 24);
            this.lblCategoryAssign.TabIndex = 79;
            this.lblCategoryAssign.Text = "Categories Assigned:";
            this.lblCategoryAssign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(48, 186);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 78;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(51, 136);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 77;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.AutoSize = true;
            this.lblBuyerID.Location = new System.Drawing.Point(502, 135);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(85, 24);
            this.lblBuyerID.TabIndex = 76;
            this.lblBuyerID.Text = "Buyer ID:";
            // 
            // lblBuyer
            // 
            this.lblBuyer.Location = new System.Drawing.Point(90, 83);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(63, 24);
            this.lblBuyer.TabIndex = 75;
            this.lblBuyer.Text = "Buyer:";
            this.lblBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssignBuyerCategory
            // 
            this.lblAssignBuyerCategory.AutoSize = true;
            this.lblAssignBuyerCategory.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignBuyerCategory.Location = new System.Drawing.Point(255, 9);
            this.lblAssignBuyerCategory.Name = "lblAssignBuyerCategory";
            this.lblAssignBuyerCategory.Size = new System.Drawing.Size(294, 37);
            this.lblAssignBuyerCategory.TabIndex = 74;
            this.lblAssignBuyerCategory.Text = "Assign Buyer Category";
            // 
            // cboImportance
            // 
            this.cboImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImportance.FormattingEnabled = true;
            this.cboImportance.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cboImportance.Location = new System.Drawing.Point(171, 387);
            this.cboImportance.MaxLength = 6;
            this.cboImportance.Name = "cboImportance";
            this.cboImportance.Size = new System.Drawing.Size(83, 32);
            this.cboImportance.TabIndex = 95;
            // 
            // lstCategoryAssign
            // 
            this.lstCategoryAssign.FormattingEnabled = true;
            this.lstCategoryAssign.ItemHeight = 24;
            this.lstCategoryAssign.Location = new System.Drawing.Point(171, 236);
            this.lstCategoryAssign.Name = "lstCategoryAssign";
            this.lstCategoryAssign.ScrollAlwaysVisible = true;
            this.lstCategoryAssign.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCategoryAssign.Size = new System.Drawing.Size(490, 76);
            this.lstCategoryAssign.TabIndex = 96;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(172, 348);
            this.cboCategory.MaxLength = 6;
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(398, 32);
            this.cboCategory.TabIndex = 98;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(64, 348);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(89, 24);
            this.lblCategory.TabIndex = 97;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(151, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(151, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 100;
            this.label2.Text = "*";
            // 
            // AssignBuyerCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lstCategoryAssign);
            this.Controls.Add(this.cboImportance);
            this.Controls.Add(this.txtCreditStatus);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssignBuyerCategory);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.lblImportance);
            this.Controls.Add(this.lblCategoryAssign);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.lblAssignBuyerCategory);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignBuyerCategoryForm";
            this.Text = "Assign Buyer Categories";
            this.Load += new System.EventHandler(this.AssignBuyerCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreditStatus;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAssignBuyerCategory;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.Label lblImportance;
        private System.Windows.Forms.Label lblCategoryAssign;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblAssignBuyerCategory;
        private System.Windows.Forms.ComboBox cboImportance;
        private System.Windows.Forms.ListBox lstCategoryAssign;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
