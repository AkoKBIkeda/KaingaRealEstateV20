
namespace KaingaRealEstate
{
    partial class AssistantAdministratorMainForm
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
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAgentsReport = new System.Windows.Forms.Button();
            this.btnDeleteAgent = new System.Windows.Forms.Button();
            this.btnUpdateAgent = new System.Windows.Forms.Button();
            this.btnSellersReport = new System.Windows.Forms.Button();
            this.btnDeleteSeller = new System.Windows.Forms.Button();
            this.btnUpdateSeller = new System.Windows.Forms.Button();
            this.btnAddAgent = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.Location = new System.Drawing.Point(44, 105);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(240, 45);
            this.btnAddSeller.TabIndex = 19;
            this.btnAddSeller.Text = "Add Seller";
            this.btnAddSeller.UseVisualStyleBackColor = true;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(185, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 45);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAgentsReport
            // 
            this.btnAgentsReport.Location = new System.Drawing.Point(326, 300);
            this.btnAgentsReport.Name = "btnAgentsReport";
            this.btnAgentsReport.Size = new System.Drawing.Size(240, 45);
            this.btnAgentsReport.TabIndex = 17;
            this.btnAgentsReport.Text = "Agents Report";
            this.btnAgentsReport.UseVisualStyleBackColor = true;
            this.btnAgentsReport.Click += new System.EventHandler(this.btnAgentsReport_Click);
            // 
            // btnDeleteAgent
            // 
            this.btnDeleteAgent.Location = new System.Drawing.Point(326, 235);
            this.btnDeleteAgent.Name = "btnDeleteAgent";
            this.btnDeleteAgent.Size = new System.Drawing.Size(240, 45);
            this.btnDeleteAgent.TabIndex = 16;
            this.btnDeleteAgent.Text = "Delete Agent";
            this.btnDeleteAgent.UseVisualStyleBackColor = true;
            this.btnDeleteAgent.Click += new System.EventHandler(this.btnDeleteAgent_Click);
            // 
            // btnUpdateAgent
            // 
            this.btnUpdateAgent.Location = new System.Drawing.Point(326, 170);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(240, 45);
            this.btnUpdateAgent.TabIndex = 15;
            this.btnUpdateAgent.Text = "Update Agent";
            this.btnUpdateAgent.UseVisualStyleBackColor = true;
            this.btnUpdateAgent.Click += new System.EventHandler(this.btnUpdateAgent_Click);
            // 
            // btnSellersReport
            // 
            this.btnSellersReport.Location = new System.Drawing.Point(44, 300);
            this.btnSellersReport.Name = "btnSellersReport";
            this.btnSellersReport.Size = new System.Drawing.Size(240, 45);
            this.btnSellersReport.TabIndex = 14;
            this.btnSellersReport.Text = "Sellers Report";
            this.btnSellersReport.UseVisualStyleBackColor = true;
            this.btnSellersReport.Click += new System.EventHandler(this.btnSellersReport_Click);
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.Location = new System.Drawing.Point(44, 235);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.Size = new System.Drawing.Size(240, 45);
            this.btnDeleteSeller.TabIndex = 13;
            this.btnDeleteSeller.Text = "Delete Seller";
            this.btnDeleteSeller.UseVisualStyleBackColor = true;
            this.btnDeleteSeller.Click += new System.EventHandler(this.btnDeleteSeller_Click);
            // 
            // btnUpdateSeller
            // 
            this.btnUpdateSeller.Location = new System.Drawing.Point(44, 170);
            this.btnUpdateSeller.Name = "btnUpdateSeller";
            this.btnUpdateSeller.Size = new System.Drawing.Size(240, 45);
            this.btnUpdateSeller.TabIndex = 12;
            this.btnUpdateSeller.Text = "Update Seller";
            this.btnUpdateSeller.UseVisualStyleBackColor = true;
            this.btnUpdateSeller.Click += new System.EventHandler(this.btnUpdateSeller_Click);
            // 
            // btnAddAgent
            // 
            this.btnAddAgent.Location = new System.Drawing.Point(326, 105);
            this.btnAddAgent.Name = "btnAddAgent";
            this.btnAddAgent.Size = new System.Drawing.Size(240, 45);
            this.btnAddAgent.TabIndex = 11;
            this.btnAddAgent.Text = "Add Agent";
            this.btnAddAgent.UseVisualStyleBackColor = true;
            this.btnAddAgent.Click += new System.EventHandler(this.btnAddAgent_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(154, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(308, 74);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Assistant Administrator\r\nMain Menu\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssistantAdministratorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 439);
            this.Controls.Add(this.btnAddSeller);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAgentsReport);
            this.Controls.Add(this.btnDeleteAgent);
            this.Controls.Add(this.btnUpdateAgent);
            this.Controls.Add(this.btnSellersReport);
            this.Controls.Add(this.btnDeleteSeller);
            this.Controls.Add(this.btnUpdateSeller);
            this.Controls.Add(this.btnAddAgent);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssistantAdministratorMainForm";
            this.Text = "Kāinga Real Estate";
            this.Load += new System.EventHandler(this.AssistantAdministratorMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSeller;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAgentsReport;
        private System.Windows.Forms.Button btnDeleteAgent;
        private System.Windows.Forms.Button btnUpdateAgent;
        private System.Windows.Forms.Button btnSellersReport;
        private System.Windows.Forms.Button btnDeleteSeller;
        private System.Windows.Forms.Button btnUpdateSeller;
        private System.Windows.Forms.Button btnAddAgent;
        private System.Windows.Forms.Label lblTitle;
    }
}