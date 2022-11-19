
namespace KaingaRealEstate
{
    partial class SalesClerkMainForm
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
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPropertiesReport = new System.Windows.Forms.Button();
            this.btnSellProperty = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(28, 127);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(240, 45);
            this.btnAddProperty.TabIndex = 26;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(172, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 45);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPropertiesReport
            // 
            this.btnPropertiesReport.Location = new System.Drawing.Point(172, 247);
            this.btnPropertiesReport.Name = "btnPropertiesReport";
            this.btnPropertiesReport.Size = new System.Drawing.Size(240, 45);
            this.btnPropertiesReport.TabIndex = 24;
            this.btnPropertiesReport.Text = "Properties Report";
            this.btnPropertiesReport.UseVisualStyleBackColor = true;
            this.btnPropertiesReport.Click += new System.EventHandler(this.btnPropertiesReport_Click);
            // 
            // btnSellProperty
            // 
            this.btnSellProperty.Location = new System.Drawing.Point(323, 127);
            this.btnSellProperty.Name = "btnSellProperty";
            this.btnSellProperty.Size = new System.Drawing.Size(240, 45);
            this.btnSellProperty.TabIndex = 23;
            this.btnSellProperty.Text = "Sell Property";
            this.btnSellProperty.UseVisualStyleBackColor = true;
            this.btnSellProperty.Click += new System.EventHandler(this.btnSellProperty_Click);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(323, 187);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(240, 45);
            this.btnDeleteProperty.TabIndex = 22;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(28, 187);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(240, 45);
            this.btnUpdateProperty.TabIndex = 21;
            this.btnUpdateProperty.Text = "Update Property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(207, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 74);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Sales Clerk\r\nMain Menu\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesClerkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 413);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPropertiesReport);
            this.Controls.Add(this.btnSellProperty);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesClerkMainForm";
            this.Text = "SalesClerkMainForm";
            this.Load += new System.EventHandler(this.SalesClerkMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPropertiesReport;
        private System.Windows.Forms.Button btnSellProperty;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Label lblTitle;
    }
}