
namespace KaingaRealEstate
{
    partial class UpdateBuyerForm
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
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.errorProviderDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.buyercategoryTableAdapter1 = new KaingaRealEstate.KaingaRealEstateDataSetTableAdapters.BUYERCATEGORYTableAdapter();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.cboCreditStatus = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateBuyer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAgentFirstName = new System.Windows.Forms.TextBox();
            this.txtAgentLastName = new System.Windows.Forms.TextBox();
            this.lblAgentFirstName = new System.Windows.Forms.Label();
            this.lblAgentLastName = new System.Windows.Forms.Label();
            this.lblMortgageStatus = new System.Windows.Forms.Label();
            this.cboMortStatus = new System.Windows.Forms.ComboBox();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(130, 320);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 24);
            this.lblCity.TabIndex = 159;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtCity.Location = new System.Drawing.Point(199, 317);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(245, 32);
            this.txtCity.TabIndex = 158;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // errorProviderDetails
            // 
            this.errorProviderDetails.ContainerControl = this;
            // 
            // buyercategoryTableAdapter1
            // 
            this.buyercategoryTableAdapter1.ClearBeforeFill = true;
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.Location = new System.Drawing.Point(450, 398);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(123, 24);
            this.lblCreditStatus.TabIndex = 152;
            this.lblCreditStatus.Text = "Credit Status:";
            this.lblCreditStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCreditStatus
            // 
            this.cboCreditStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCreditStatus.FormattingEnabled = true;
            this.cboCreditStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboCreditStatus.Location = new System.Drawing.Point(592, 395);
            this.cboCreditStatus.Name = "cboCreditStatus";
            this.cboCreditStatus.Size = new System.Drawing.Size(93, 32);
            this.cboCreditStatus.TabIndex = 151;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(36, 398);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(141, 24);
            this.lblPhone.TabIndex = 150;
            this.lblPhone.Text = "Phone Number:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Location = new System.Drawing.Point(199, 395);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 32);
            this.txtPhone.TabIndex = 149;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(44, 359);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(133, 24);
            this.lblEmail.TabIndex = 148;
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(199, 356);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 32);
            this.txtEmail.TabIndex = 147;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // lblSuburb
            // 
            this.lblSuburb.Location = new System.Drawing.Point(102, 281);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 146;
            this.lblSuburb.Text = "Suburb:";
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSuburb
            // 
            this.txtSuburb.BackColor = System.Drawing.SystemColors.Window;
            this.txtSuburb.Location = new System.Drawing.Point(199, 278);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(245, 32);
            this.txtSuburb.TabIndex = 145;
            this.txtSuburb.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.Location = new System.Drawing.Point(40, 242);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 144;
            this.lblStreetAddress.Text = "Street Address:";
            this.lblStreetAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtStreetAddress.Location = new System.Drawing.Point(199, 239);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(486, 32);
            this.txtStreetAddress.TabIndex = 143;
            this.txtStreetAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Location = new System.Drawing.Point(199, 200);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(272, 32);
            this.txtFirstName.TabIndex = 138;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Location = new System.Drawing.Point(199, 161);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(272, 32);
            this.txtLastName.TabIndex = 137;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidation);
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(199, 122);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(79, 32);
            this.txtBuyerID.TabIndex = 136;
            // 
            // cboBuyer
            // 
            this.cboBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(199, 83);
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(486, 32);
            this.cboBuyer.TabIndex = 135;
            this.cboBuyer.SelectedIndexChanged += new System.EventHandler(this.cboBuyer_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(72, 203);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 134;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(75, 164);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 133;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.Location = new System.Drawing.Point(92, 126);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(85, 24);
            this.lblBuyerID.TabIndex = 132;
            this.lblBuyerID.Text = "Buyer ID:";
            this.lblBuyerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeller
            // 
            this.lblSeller.Location = new System.Drawing.Point(114, 86);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(63, 24);
            this.lblSeller.TabIndex = 131;
            this.lblSeller.Text = "Buyer:";
            this.lblSeller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.CausesValidation = false;
            this.btnReturn.Location = new System.Drawing.Point(454, 551);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(231, 48);
            this.btnReturn.TabIndex = 130;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateBuyer
            // 
            this.btnUpdateBuyer.Location = new System.Drawing.Point(69, 551);
            this.btnUpdateBuyer.Name = "btnUpdateBuyer";
            this.btnUpdateBuyer.Size = new System.Drawing.Size(231, 48);
            this.btnUpdateBuyer.TabIndex = 129;
            this.btnUpdateBuyer.Text = "Update Buyer";
            this.btnUpdateBuyer.UseVisualStyleBackColor = true;
            this.btnUpdateBuyer.Click += new System.EventHandler(this.btnUpdateBuyer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(294, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 37);
            this.lblTitle.TabIndex = 128;
            this.lblTitle.Text = "Update Buyer";
            // 
            // txtAgentFirstName
            // 
            this.txtAgentFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAgentFirstName.Location = new System.Drawing.Point(199, 473);
            this.txtAgentFirstName.Name = "txtAgentFirstName";
            this.txtAgentFirstName.ReadOnly = true;
            this.txtAgentFirstName.Size = new System.Drawing.Size(272, 32);
            this.txtAgentFirstName.TabIndex = 164;
            // 
            // txtAgentLastName
            // 
            this.txtAgentLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAgentLastName.Location = new System.Drawing.Point(199, 434);
            this.txtAgentLastName.Name = "txtAgentLastName";
            this.txtAgentLastName.ReadOnly = true;
            this.txtAgentLastName.Size = new System.Drawing.Size(272, 32);
            this.txtAgentLastName.TabIndex = 163;
            // 
            // lblAgentFirstName
            // 
            this.lblAgentFirstName.Location = new System.Drawing.Point(18, 476);
            this.lblAgentFirstName.Name = "lblAgentFirstName";
            this.lblAgentFirstName.Size = new System.Drawing.Size(159, 24);
            this.lblAgentFirstName.TabIndex = 162;
            this.lblAgentFirstName.Text = "Agent First Name:";
            this.lblAgentFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAgentLastName
            // 
            this.lblAgentLastName.Location = new System.Drawing.Point(21, 437);
            this.lblAgentLastName.Name = "lblAgentLastName";
            this.lblAgentLastName.Size = new System.Drawing.Size(156, 24);
            this.lblAgentLastName.TabIndex = 161;
            this.lblAgentLastName.Text = "Agent Last Name:";
            this.lblAgentLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMortgageStatus
            // 
            this.lblMortgageStatus.Location = new System.Drawing.Point(375, 128);
            this.lblMortgageStatus.Name = "lblMortgageStatus";
            this.lblMortgageStatus.Size = new System.Drawing.Size(152, 24);
            this.lblMortgageStatus.TabIndex = 166;
            this.lblMortgageStatus.Text = "Mortgage Status:";
            this.lblMortgageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMortStatus
            // 
            this.cboMortStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMortStatus.FormattingEnabled = true;
            this.cboMortStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboMortStatus.Location = new System.Drawing.Point(543, 125);
            this.cboMortStatus.Name = "cboMortStatus";
            this.cboMortStatus.Size = new System.Drawing.Size(142, 32);
            this.cboMortStatus.TabIndex = 165;
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(196, 56);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(182, 24);
            this.lblPleaseSelectAnOption.TabIndex = 168;
            this.lblPleaseSelectAnOption.Text = "Please select a buyer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(180, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 169;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(196, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 24);
            this.label9.TabIndex = 170;
            this.label9.Text = "*Cannot be left blank";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(180, 240);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 171;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(180, 201);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 172;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(180, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 173;
            this.label12.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(180, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 176;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(180, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 175;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(180, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 174;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(520, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 178;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(569, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 177;
            this.label6.Text = "*";
            // 
            // UpdateBuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.lblMortgageStatus);
            this.Controls.Add(this.cboMortStatus);
            this.Controls.Add(this.txtAgentFirstName);
            this.Controls.Add(this.txtAgentLastName);
            this.Controls.Add(this.lblAgentFirstName);
            this.Controls.Add(this.lblAgentLastName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.cboCreditStatus);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateBuyer);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateBuyerForm";
            this.Text = "Update Buyers";
            this.Load += new System.EventHandler(this.UpdateBuyerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ErrorProvider errorProviderDetails;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.ComboBox cboCreditStatus;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateBuyer;
        private System.Windows.Forms.Label lblTitle;
        private KaingaRealEstateDataSetTableAdapters.BUYERCATEGORYTableAdapter buyercategoryTableAdapter1;
        private System.Windows.Forms.TextBox txtAgentFirstName;
        private System.Windows.Forms.TextBox txtAgentLastName;
        private System.Windows.Forms.Label lblAgentFirstName;
        private System.Windows.Forms.Label lblAgentLastName;
        private System.Windows.Forms.Label lblMortgageStatus;
        private System.Windows.Forms.ComboBox cboMortStatus;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}