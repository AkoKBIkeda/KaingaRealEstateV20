
namespace KaingaRealEstate
{
    partial class UpdateSuburbForm
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
            this.components = new System.ComponentModel.Container();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtSuburbName = new System.Windows.Forms.TextBox();
            this.txtSuburbID = new System.Windows.Forms.TextBox();
            this.cboSuburb = new System.Windows.Forms.ComboBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblSuburbName = new System.Windows.Forms.Label();
            this.lblSuburbID = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateSuburb = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.kaingaRealEstateDataSet = new KaingaRealEstate.KaingaRealEstateDataSet();
            this.errorProviderDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kaingaRealEstateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPostcode
            // 
            this.txtPostcode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPostcode.Location = new System.Drawing.Point(186, 248);
            this.txtPostcode.MaxLength = 4;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(60, 32);
            this.txtPostcode.TabIndex = 53;
            this.txtPostcode.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtSuburbName
            // 
            this.txtSuburbName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSuburbName.Location = new System.Drawing.Point(187, 200);
            this.txtSuburbName.MaxLength = 20;
            this.txtSuburbName.Name = "txtSuburbName";
            this.txtSuburbName.Size = new System.Drawing.Size(246, 32);
            this.txtSuburbName.TabIndex = 51;
            this.txtSuburbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtSuburbID
            // 
            this.txtSuburbID.Location = new System.Drawing.Point(186, 152);
            this.txtSuburbID.Name = "txtSuburbID";
            this.txtSuburbID.ReadOnly = true;
            this.txtSuburbID.Size = new System.Drawing.Size(79, 32);
            this.txtSuburbID.TabIndex = 50;
            // 
            // cboSuburb
            // 
            this.cboSuburb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuburb.FormattingEnabled = true;
            this.cboSuburb.Location = new System.Drawing.Point(186, 104);
            this.cboSuburb.Name = "cboSuburb";
            this.cboSuburb.Size = new System.Drawing.Size(323, 32);
            this.cboSuburb.TabIndex = 49;
            this.cboSuburb.SelectedIndexChanged += new System.EventHandler(this.cboSuburb_SelectedIndexChanged);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(98, 251);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(91, 24);
            this.lblPostcode.TabIndex = 48;
            this.lblPostcode.Text = "Postcode:";
            this.lblPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburbName
            // 
            this.lblSuburbName.AutoSize = true;
            this.lblSuburbName.Location = new System.Drawing.Point(71, 203);
            this.lblSuburbName.Name = "lblSuburbName";
            this.lblSuburbName.Size = new System.Drawing.Size(129, 24);
            this.lblSuburbName.TabIndex = 45;
            this.lblSuburbName.Text = "Suburb Name:";
            this.lblSuburbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburbID
            // 
            this.lblSuburbID.AutoSize = true;
            this.lblSuburbID.Location = new System.Drawing.Point(95, 155);
            this.lblSuburbID.Name = "lblSuburbID";
            this.lblSuburbID.Size = new System.Drawing.Size(97, 24);
            this.lblSuburbID.TabIndex = 44;
            this.lblSuburbID.Text = "Suburb ID:";
            this.lblSuburbID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(113, 107);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 43;
            this.lblSuburb.Text = "Suburb:";
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(325, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(196, 48);
            this.btnReturn.TabIndex = 42;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateSuburb
            // 
            this.btnUpdateSuburb.Location = new System.Drawing.Point(50, 343);
            this.btnUpdateSuburb.Name = "btnUpdateSuburb";
            this.btnUpdateSuburb.Size = new System.Drawing.Size(196, 48);
            this.btnUpdateSuburb.TabIndex = 41;
            this.btnUpdateSuburb.Text = "Update Suburb";
            this.btnUpdateSuburb.UseVisualStyleBackColor = true;
            this.btnUpdateSuburb.Click += new System.EventHandler(this.btnUpdateSuburb_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(190, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 37);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Update Suburb";
            // 
            // kaingaRealEstateDataSet
            // 
            this.kaingaRealEstateDataSet.DataSetName = "KaingaRealEstateDataSet";
            this.kaingaRealEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProviderDetails
            // 
            this.errorProviderDetails.ContainerControl = this;
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(183, 77);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(191, 24);
            this.lblPleaseSelectAnOption.TabIndex = 169;
            this.lblPleaseSelectAnOption.Text = "Please select a suburb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(183, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 24);
            this.label9.TabIndex = 171;
            this.label9.Text = "*Cannot be left blank";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(164, 200);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 175;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(164, 248);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 174;
            this.label11.Text = "*";
            // 
            // UpdateSuburbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 413);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtSuburbName);
            this.Controls.Add(this.txtSuburbID);
            this.Controls.Add(this.cboSuburb);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblSuburbName);
            this.Controls.Add(this.lblSuburbID);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateSuburb);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateSuburbForm";
            this.Text = "Update Suburbs";
            this.Load += new System.EventHandler(this.UpdateSuburbForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kaingaRealEstateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtSuburbName;
        private System.Windows.Forms.TextBox txtSuburbID;
        private System.Windows.Forms.ComboBox cboSuburb;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblSuburbName;
        private System.Windows.Forms.Label lblSuburbID;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateSuburb;
        private System.Windows.Forms.Label lblTitle;
        private KaingaRealEstateDataSet kaingaRealEstateDataSet;
        private System.Windows.Forms.ErrorProvider errorProviderDetails;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}