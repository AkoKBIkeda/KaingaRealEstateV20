
namespace KaingaRealEstate
{
    partial class UpdateCategoryForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.errorProviderDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.kaingaRealEstateDataSet = new KaingaRealEstate.KaingaRealEstateDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCatDesc = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCatDesc = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaingaRealEstateDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.label11.TabIndex = 189;
            this.label11.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(183, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 24);
            this.label9.TabIndex = 188;
            this.label9.Text = "*Cannot be left blank";
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(183, 77);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 187;
            this.lblPleaseSelectAnOption.Text = "Please select a category";
            // 
            // errorProviderDetails
            // 
            this.errorProviderDetails.ContainerControl = this;
            // 
            // kaingaRealEstateDataSet
            // 
            this.kaingaRealEstateDataSet.DataSetName = "KaingaRealEstateDataSet";
            this.kaingaRealEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label12.TabIndex = 190;
            this.label12.Text = "*";
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txtCatDesc.Location = new System.Drawing.Point(187, 200);
            this.txtCatDesc.MaxLength = 40;
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(350, 32);
            this.txtCatDesc.TabIndex = 185;
            this.txtCatDesc.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(186, 152);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(79, 32);
            this.txtCategoryID.TabIndex = 184;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(186, 104);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(473, 32);
            this.cboCategory.TabIndex = 183;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(120, 251);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(57, 24);
            this.lblLevel.TabIndex = 182;
            this.lblLevel.Text = "Level:";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCatDesc
            // 
            this.lblCatDesc.AutoSize = true;
            this.lblCatDesc.Location = new System.Drawing.Point(18, 203);
            this.lblCatDesc.Name = "lblCatDesc";
            this.lblCatDesc.Size = new System.Drawing.Size(188, 24);
            this.lblCatDesc.TabIndex = 181;
            this.lblCatDesc.Text = "Category Description:";
            this.lblCatDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(92, 155);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(111, 24);
            this.lblCategoryID.TabIndex = 180;
            this.lblCategoryID.Text = "Category ID:";
            this.lblCategoryID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(96, 107);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(89, 24);
            this.lblCategory.TabIndex = 179;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(463, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(196, 48);
            this.btnReturn.TabIndex = 178;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Location = new System.Drawing.Point(50, 343);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(196, 48);
            this.btnUpdateCat.TabIndex = 177;
            this.btnUpdateCat.Text = "Update Category";
            this.btnUpdateCat.UseVisualStyleBackColor = true;
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(190, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 37);
            this.lblTitle.TabIndex = 176;
            this.lblTitle.Text = "Update Category";
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboLevel.Location = new System.Drawing.Point(186, 245);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(54, 32);
            this.cboLevel.TabIndex = 191;
            // 
            // UpdateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 413);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCatDesc);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblCatDesc);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateCategoryForm";
            this.Text = "Update Categories";
            this.Load += new System.EventHandler(this.UpdateCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaingaRealEstateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.ErrorProvider errorProviderDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCatDesc;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCatDesc;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Label lblTitle;
        private KaingaRealEstateDataSet kaingaRealEstateDataSet;
        private System.Windows.Forms.ComboBox cboLevel;
    }
}