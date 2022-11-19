
namespace KaingaRealEstate
{
    partial class AssignBuyerSuburbForm
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
            this.lblBuyers = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBuyerSuburbs = new System.Windows.Forms.Label();
            this.cboBuyers = new System.Windows.Forms.ComboBox();
            this.lstSuburbsAssigned = new System.Windows.Forms.ListBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.txtCreditStatus = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblImportance = new System.Windows.Forms.Label();
            this.cboImportance = new System.Windows.Forms.ComboBox();
            this.btnAssignBuyerSuburb = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cboSuburbs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Buyer Suburbs";
            // 
            // lblBuyers
            // 
            this.lblBuyers.Location = new System.Drawing.Point(83, 90);
            this.lblBuyers.Name = "lblBuyers";
            this.lblBuyers.Size = new System.Drawing.Size(71, 24);
            this.lblBuyers.TabIndex = 1;
            this.lblBuyers.Text = "Buyers:";
            this.lblBuyers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.Location = new System.Drawing.Point(474, 137);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(85, 24);
            this.lblBuyerID.TabIndex = 2;
            this.lblBuyerID.Text = "Buyer ID:";
            this.lblBuyerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.Location = new System.Drawing.Point(436, 184);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(123, 24);
            this.lblCreditStatus.TabIndex = 4;
            this.lblCreditStatus.Text = "Credit Status:";
            this.lblCreditStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(52, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(49, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "First Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerSuburbs
            // 
            this.lblBuyerSuburbs.Location = new System.Drawing.Point(18, 231);
            this.lblBuyerSuburbs.Name = "lblBuyerSuburbs";
            this.lblBuyerSuburbs.Size = new System.Drawing.Size(136, 24);
            this.lblBuyerSuburbs.TabIndex = 7;
            this.lblBuyerSuburbs.Text = "Suburbs Assigned:";
            this.lblBuyerSuburbs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBuyers
            // 
            this.cboBuyers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuyers.FormattingEnabled = true;
            this.cboBuyers.Location = new System.Drawing.Point(176, 87);
            this.cboBuyers.Name = "cboBuyers";
            this.cboBuyers.Size = new System.Drawing.Size(469, 32);
            this.cboBuyers.TabIndex = 8;
            this.cboBuyers.SelectedIndexChanged += new System.EventHandler(this.cboBuyers_SelectedIndexChanged);
            // 
            // lstSuburbsAssigned
            // 
            this.lstSuburbsAssigned.AllowDrop = true;
            this.lstSuburbsAssigned.FormattingEnabled = true;
            this.lstSuburbsAssigned.ItemHeight = 24;
            this.lstSuburbsAssigned.Location = new System.Drawing.Point(176, 231);
            this.lstSuburbsAssigned.Name = "lstSuburbsAssigned";
            this.lstSuburbsAssigned.ScrollAlwaysVisible = true;
            this.lstSuburbsAssigned.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSuburbsAssigned.Size = new System.Drawing.Size(362, 76);
            this.lstSuburbsAssigned.TabIndex = 9;
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(575, 134);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(70, 32);
            this.txtBuyerID.TabIndex = 10;
            // 
            // txtCreditStatus
            // 
            this.txtCreditStatus.Location = new System.Drawing.Point(575, 181);
            this.txtCreditStatus.Name = "txtCreditStatus";
            this.txtCreditStatus.ReadOnly = true;
            this.txtCreditStatus.Size = new System.Drawing.Size(70, 32);
            this.txtCreditStatus.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(176, 134);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(217, 32);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(176, 181);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(217, 32);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblSuburb
            // 
            this.lblSuburb.Location = new System.Drawing.Point(79, 331);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 17;
            this.lblSuburb.Text = "Suburb:";
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImportance
            // 
            this.lblImportance.Location = new System.Drawing.Point(43, 374);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(111, 24);
            this.lblImportance.TabIndex = 18;
            this.lblImportance.Text = "Importance:";
            this.lblImportance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboImportance
            // 
            this.cboImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImportance.FormattingEnabled = true;
            this.cboImportance.Items.AddRange(new object[] {
            "high",
            "medium",
            "low"});
            this.cboImportance.Location = new System.Drawing.Point(176, 371);
            this.cboImportance.Name = "cboImportance";
            this.cboImportance.Size = new System.Drawing.Size(115, 32);
            this.cboImportance.TabIndex = 19;
            // 
            // btnAssignBuyerSuburb
            // 
            this.btnAssignBuyerSuburb.Location = new System.Drawing.Point(72, 441);
            this.btnAssignBuyerSuburb.Name = "btnAssignBuyerSuburb";
            this.btnAssignBuyerSuburb.Size = new System.Drawing.Size(166, 36);
            this.btnAssignBuyerSuburb.TabIndex = 20;
            this.btnAssignBuyerSuburb.Text = "Assign Buyer Suburb";
            this.btnAssignBuyerSuburb.UseVisualStyleBackColor = true;
            this.btnAssignBuyerSuburb.Click += new System.EventHandler(this.btnAssignBuyerSuburb_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(478, 441);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(165, 36);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboSuburbs
            // 
            this.cboSuburbs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuburbs.FormattingEnabled = true;
            this.cboSuburbs.Location = new System.Drawing.Point(176, 328);
            this.cboSuburbs.Name = "cboSuburbs";
            this.cboSuburbs.Size = new System.Drawing.Size(273, 32);
            this.cboSuburbs.TabIndex = 22;
            this.cboSuburbs.SelectedIndexChanged += new System.EventHandler(this.cboSuburbs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(154, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(154, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(154, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "*";
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(172, 60);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 90;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // AssignBuyerSuburbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 494);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSuburbs);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssignBuyerSuburb);
            this.Controls.Add(this.cboImportance);
            this.Controls.Add(this.lblImportance);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCreditStatus);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.lstSuburbsAssigned);
            this.Controls.Add(this.cboBuyers);
            this.Controls.Add(this.lblBuyerSuburbs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignBuyerSuburbForm";
            this.Text = "Assign Buyer Suburbs";
            this.Load += new System.EventHandler(this.AssignBuyerSuburbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuyers;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBuyerSuburbs;
        private System.Windows.Forms.ComboBox cboBuyers;
        private System.Windows.Forms.ListBox lstSuburbsAssigned;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.TextBox txtCreditStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblImportance;
        private System.Windows.Forms.ComboBox cboImportance;
        private System.Windows.Forms.Button btnAssignBuyerSuburb;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cboSuburbs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
    }
}
