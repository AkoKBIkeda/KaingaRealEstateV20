
namespace KaingaRealEstate
{
    partial class ITClerkMainForm
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
            this.btnAddSuburb = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCategoriesReport = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnSuburbsReport = new System.Windows.Forms.Button();
            this.btnDeleteSuburb = new System.Windows.Forms.Button();
            this.btnUpdateSuburb = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSuburb
            // 
            this.btnAddSuburb.Location = new System.Drawing.Point(40, 126);
            this.btnAddSuburb.Name = "btnAddSuburb";
            this.btnAddSuburb.Size = new System.Drawing.Size(240, 45);
            this.btnAddSuburb.TabIndex = 29;
            this.btnAddSuburb.Text = "Add Suburb";
            this.btnAddSuburb.UseVisualStyleBackColor = true;
            this.btnAddSuburb.Click += new System.EventHandler(this.btnAddSuburb_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(187, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 45);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCategoriesReport
            // 
            this.btnCategoriesReport.Location = new System.Drawing.Point(326, 321);
            this.btnCategoriesReport.Name = "btnCategoriesReport";
            this.btnCategoriesReport.Size = new System.Drawing.Size(240, 45);
            this.btnCategoriesReport.TabIndex = 27;
            this.btnCategoriesReport.Text = "Categories Report";
            this.btnCategoriesReport.UseVisualStyleBackColor = true;
            this.btnCategoriesReport.Click += new System.EventHandler(this.btnCategoriesReport_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(326, 256);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(240, 45);
            this.btnDeleteCategory.TabIndex = 26;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(326, 191);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(240, 45);
            this.btnUpdateCategory.TabIndex = 25;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnSuburbsReport
            // 
            this.btnSuburbsReport.Location = new System.Drawing.Point(40, 321);
            this.btnSuburbsReport.Name = "btnSuburbsReport";
            this.btnSuburbsReport.Size = new System.Drawing.Size(240, 45);
            this.btnSuburbsReport.TabIndex = 24;
            this.btnSuburbsReport.Text = "Suburbs Report";
            this.btnSuburbsReport.UseVisualStyleBackColor = true;
            this.btnSuburbsReport.Click += new System.EventHandler(this.btnSuburbsReport_Click);
            // 
            // btnDeleteSuburb
            // 
            this.btnDeleteSuburb.Location = new System.Drawing.Point(40, 256);
            this.btnDeleteSuburb.Name = "btnDeleteSuburb";
            this.btnDeleteSuburb.Size = new System.Drawing.Size(240, 45);
            this.btnDeleteSuburb.TabIndex = 23;
            this.btnDeleteSuburb.Text = "Delete Suburb";
            this.btnDeleteSuburb.UseVisualStyleBackColor = true;
            this.btnDeleteSuburb.Click += new System.EventHandler(this.btnDeleteSuburb_Click);
            // 
            // btnUpdateSuburb
            // 
            this.btnUpdateSuburb.Location = new System.Drawing.Point(40, 191);
            this.btnUpdateSuburb.Name = "btnUpdateSuburb";
            this.btnUpdateSuburb.Size = new System.Drawing.Size(240, 45);
            this.btnUpdateSuburb.TabIndex = 22;
            this.btnUpdateSuburb.Text = "Update Suburb";
            this.btnUpdateSuburb.UseVisualStyleBackColor = true;
            this.btnUpdateSuburb.Click += new System.EventHandler(this.btnUpdateSuburb_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(326, 126);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(240, 45);
            this.btnAddCategory.TabIndex = 21;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(227, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 74);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "IT Clerk\r\nMain Menu\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ITClerkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 456);
            this.Controls.Add(this.btnAddSuburb);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCategoriesReport);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnSuburbsReport);
            this.Controls.Add(this.btnDeleteSuburb);
            this.Controls.Add(this.btnUpdateSuburb);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ITClerkMainForm";
            this.Text = "Kāinga Real Estate";
            this.Load += new System.EventHandler(this.ITClerkMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSuburb;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCategoriesReport;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnSuburbsReport;
        private System.Windows.Forms.Button btnDeleteSuburb;
        private System.Windows.Forms.Button btnUpdateSuburb;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblTitle;
    }
}