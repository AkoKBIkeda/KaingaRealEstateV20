
namespace KaingaRealEstate
{
    partial class DeleteSuburbForm
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
            this.btnDeleteSuburb = new System.Windows.Forms.Button();
            this.cboSuburb = new System.Windows.Forms.ComboBox();
            this.txtSuburbName = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtSuburbID = new System.Windows.Forms.TextBox();
            this.lblSuburbName = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblSuburbID = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblDeleteSuburb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(163, 106);
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
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(180, 76);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 89;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(433, 287);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 36);
            this.btnReturn.TabIndex = 88;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteSuburb
            // 
            this.btnDeleteSuburb.Location = new System.Drawing.Point(65, 287);
            this.btnDeleteSuburb.Name = "btnDeleteSuburb";
            this.btnDeleteSuburb.Size = new System.Drawing.Size(124, 36);
            this.btnDeleteSuburb.TabIndex = 87;
            this.btnDeleteSuburb.Text = "Delete Suburb";
            this.btnDeleteSuburb.UseVisualStyleBackColor = true;
            this.btnDeleteSuburb.Click += new System.EventHandler(this.btnDeleteSuburb_Click);
            // 
            // cboSuburb
            // 
            this.cboSuburb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuburb.FormattingEnabled = true;
            this.cboSuburb.Location = new System.Drawing.Point(184, 103);
            this.cboSuburb.MaxLength = 57;
            this.cboSuburb.Name = "cboSuburb";
            this.cboSuburb.Size = new System.Drawing.Size(373, 32);
            this.cboSuburb.TabIndex = 86;
            this.cboSuburb.SelectedIndexChanged += new System.EventHandler(this.cboSuburb_SelectedIndexChanged);
            // 
            // txtSuburbName
            // 
            this.txtSuburbName.Location = new System.Drawing.Point(184, 154);
            this.txtSuburbName.MaxLength = 20;
            this.txtSuburbName.Name = "txtSuburbName";
            this.txtSuburbName.ReadOnly = true;
            this.txtSuburbName.Size = new System.Drawing.Size(170, 32);
            this.txtSuburbName.TabIndex = 85;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(184, 207);
            this.txtPostcode.MaxLength = 4;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.ReadOnly = true;
            this.txtPostcode.Size = new System.Drawing.Size(55, 32);
            this.txtPostcode.TabIndex = 84;
            // 
            // txtSuburbID
            // 
            this.txtSuburbID.Location = new System.Drawing.Point(487, 152);
            this.txtSuburbID.MaxLength = 7;
            this.txtSuburbID.Name = "txtSuburbID";
            this.txtSuburbID.ReadOnly = true;
            this.txtSuburbID.Size = new System.Drawing.Size(70, 32);
            this.txtSuburbID.TabIndex = 81;
            // 
            // lblSuburbName
            // 
            this.lblSuburbName.AutoSize = true;
            this.lblSuburbName.Location = new System.Drawing.Point(64, 157);
            this.lblSuburbName.Name = "lblSuburbName";
            this.lblSuburbName.Size = new System.Drawing.Size(129, 24);
            this.lblSuburbName.TabIndex = 80;
            this.lblSuburbName.Text = "Suburb Name:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(84, 214);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(91, 24);
            this.lblPostcode.TabIndex = 79;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblSuburbID
            // 
            this.lblSuburbID.AutoSize = true;
            this.lblSuburbID.Location = new System.Drawing.Point(398, 156);
            this.lblSuburbID.Name = "lblSuburbID";
            this.lblSuburbID.Size = new System.Drawing.Size(97, 24);
            this.lblSuburbID.TabIndex = 76;
            this.lblSuburbID.Text = "Suburb ID:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(113, 106);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 75;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblDeleteSuburb
            // 
            this.lblDeleteSuburb.AutoSize = true;
            this.lblDeleteSuburb.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSuburb.Location = new System.Drawing.Point(244, 27);
            this.lblDeleteSuburb.Name = "lblDeleteSuburb";
            this.lblDeleteSuburb.Size = new System.Drawing.Size(194, 37);
            this.lblDeleteSuburb.TabIndex = 74;
            this.lblDeleteSuburb.Text = "Delete Suburb";
            // 
            // DeleteSuburbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 371);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteSuburb);
            this.Controls.Add(this.cboSuburb);
            this.Controls.Add(this.txtSuburbName);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtSuburbID);
            this.Controls.Add(this.lblSuburbName);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblSuburbID);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblDeleteSuburb);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteSuburbForm";
            this.Text = "Delete Suburbs";
            this.Load += new System.EventHandler(this.DeleteSuburbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteSuburb;
        private System.Windows.Forms.ComboBox cboSuburb;
        private System.Windows.Forms.TextBox txtSuburbName;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtSuburbID;
        private System.Windows.Forms.Label lblSuburbName;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblSuburbID;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblDeleteSuburb;
    }
}
