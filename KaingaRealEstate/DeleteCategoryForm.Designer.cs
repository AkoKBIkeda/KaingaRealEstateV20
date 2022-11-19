
namespace KaingaRealEstate
{
    partial class DeleteCategoryForm
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
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDeleteCategory = new System.Windows.Forms.Label();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.lblSuburbName = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(211, 84);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 102;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(464, 295);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 36);
            this.btnReturn.TabIndex = 101;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(48, 295);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(124, 36);
            this.btnDeleteCategory.TabIndex = 100;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(215, 111);
            this.cboCategory.MaxLength = 57;
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(373, 32);
            this.cboCategory.TabIndex = 99;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(555, 159);
            this.txtLevel.MaxLength = 1;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(33, 32);
            this.txtLevel.TabIndex = 97;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(214, 160);
            this.txtCategoryID.MaxLength = 7;
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(70, 32);
            this.txtCategoryID.TabIndex = 96;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(501, 162);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(57, 24);
            this.lblLevel.TabIndex = 94;
            this.lblLevel.Text = "Level:";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(106, 164);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(111, 24);
            this.lblCategoryID.TabIndex = 93;
            this.lblCategoryID.Text = "Category ID:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(121, 114);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(89, 24);
            this.lblCategory.TabIndex = 92;
            this.lblCategory.Text = "Category:";
            // 
            // lblDeleteCategory
            // 
            this.lblDeleteCategory.AutoSize = true;
            this.lblDeleteCategory.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCategory.Location = new System.Drawing.Point(242, 35);
            this.lblDeleteCategory.Name = "lblDeleteCategory";
            this.lblDeleteCategory.Size = new System.Drawing.Size(216, 37);
            this.lblDeleteCategory.TabIndex = 91;
            this.lblDeleteCategory.Text = "Delete Category";
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(215, 206);
            this.txtCategoryDescription.MaxLength = 40;
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.ReadOnly = true;
            this.txtCategoryDescription.Size = new System.Drawing.Size(373, 58);
            this.txtCategoryDescription.TabIndex = 105;
            // 
            // lblSuburbName
            // 
            this.lblSuburbName.AutoSize = true;
            this.lblSuburbName.Location = new System.Drawing.Point(44, 209);
            this.lblSuburbName.Name = "lblSuburbName";
            this.lblSuburbName.Size = new System.Drawing.Size(188, 24);
            this.lblSuburbName.TabIndex = 104;
            this.lblSuburbName.Text = "Category Description:";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(198, 114);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(20, 24);
            this.lblRequired.TabIndex = 106;
            this.lblRequired.Text = "*";
            // 
            // DeleteCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 366);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.lblSuburbName);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDeleteCategory);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteCategoryForm";
            this.Text = "Delete Categories";
            this.Load += new System.EventHandler(this.DeleteCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDeleteCategory;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label lblSuburbName;
        private System.Windows.Forms.Label lblRequired;
    }
}
