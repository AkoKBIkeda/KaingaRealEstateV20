using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaingaRealEstate
{
    public partial class UpdateBuyerForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aBuyerID, aAgentID;
        private CurrencyManager cmBuyer, cmAgent;

        bool reset = false;
        public UpdateBuyerForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "BUYER"];
            cmAgent = (CurrencyManager)this.BindingContext[DC.dsKainga, "AGENT"];
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

            reset = true;
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);

            ClearFields();
        }

        private void ClearFields()
        {
            txtBuyerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAgentLastName.Text = "";
            txtAgentFirstName.Text = "";
            cboMortStatus.Text = "";
            cboMortStatus.Items.Clear();
            cboCreditStatus.Text = "";
            cboCreditStatus.Items.Clear();
            cboBuyer.Text = "";
            cboBuyer.Items.Clear();
        }

        private void LoadBuyers()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                cboBuyer.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
            }
            cboCreditStatus.Items.Add("Valid");
            cboCreditStatus.Items.Add("Invalid");
            cboMortStatus.Items.Add("Confirmed");
            cboMortStatus.Items.Add("Unconfirmed");
        }
        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buyer;

            if (reset)
            {
                reset = false;
            }

            if (cboBuyer.SelectedItem != null)
            {
                // get the selected seller
                buyer = cboBuyer.SelectedItem.ToString();
                // split the string from cbo
                string[] parts = buyer.Split(' ');
                // extract ID
                aBuyerID = Convert.ToInt32(parts[0]);
                // Get the position of the selected buyer and assigns it to the Position property of cmBuyer
                cmBuyer.Position = DC.buyerView.Find(aBuyerID);
                // Get the datarow for the selected seller
                DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
                // Populate seller textboxes
                txtBuyerID.Text = drBuyer["buyerID"].ToString();
                txtLastName.Text = drBuyer["lastName"].ToString();
                txtFirstName.Text = drBuyer["firstName"].ToString();
                txtStreetAddress.Text = drBuyer["streetAddress"].ToString();
                txtSuburb.Text = drBuyer["suburb"].ToString();
                txtCity.Text = drBuyer["city"].ToString();
                txtEmail.Text = drBuyer["emailAddress"].ToString();
                txtPhone.Text = drBuyer["phoneNumber"].ToString();
                cboMortStatus.Text = drBuyer["mortgageStatus"].ToString();
                cboCreditStatus.Text = drBuyer["creditStatus"].ToString();
                //Repeat for agent
                aAgentID = Convert.ToInt32(drBuyer["agentID"]);
                cmAgent.Position = DC.agentView.Find(aAgentID);
                DataRow drAgent = DC.dtAgent.Rows[cmAgent.Position];
                //Populate agent textboxes
                txtAgentLastName.Text = drAgent["lastName"].ToString();
                txtAgentFirstName.Text = drAgent["firstName"].ToString();
            }
            EnableUpdate(this);
        }
        private void btnUpdateBuyer_Click(object sender, EventArgs e)
        {
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);
            if (detailValid)
            {
                // get data row for selected buyer
                DataRow updateBuyerrow = DC.dtBuyer.Rows[cmBuyer.Position];
                // assign textbox values to updateBuyerRow
                updateBuyerrow["lastName"] = txtLastName.Text;
                updateBuyerrow["firstName"] = txtFirstName.Text;
                updateBuyerrow["streetAddress"] = txtStreetAddress.Text;
                updateBuyerrow["suburb"] = txtSuburb.Text;
                updateBuyerrow["city"] = txtCity.Text;
                updateBuyerrow["emailAddress"] = txtEmail.Text;
                updateBuyerrow["phoneNumber"] = txtPhone.Text;
                updateBuyerrow["CreditStatus"] = cboCreditStatus.Text;
                //updateBuyerrow["MortStatus"] = cboMortStatus.Text;
                // End current edit if confirmed
                if (MessageBox.Show("Are you sure you want to update this buyer?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmBuyer.EndCurrentEdit();
                    DC.UpdateBuyer();
                    MessageBox.Show("Buyer updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadBuyers();
                }
            }
        }


        private void DisableUpdate(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Enabled = false;
                }
            }
            cboCreditStatus.Enabled = false;
            cboMortStatus.Enabled = false;
        }
        private void EnableUpdate(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Enabled = true;
                }
            }
            cboCreditStatus.Enabled = true;
            cboMortStatus.Enabled = false;
        }

        private void UpdateBuyerForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadBuyers();
            DisableUpdate(this);
        }
        private void tbValidation(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string tbName = tb.Name;
            Label tbLabel = this.Controls.Find("lbl" + tbName.Substring(3), true)[0] as Label;

            if (reset)
            {
                e.Cancel = false;
                errorProviderDetails.SetError(tb, null);
                return;
            }

            if (validateContent(tb))
            {
                e.Cancel = false;
                errorProviderDetails.SetError(tb, null);
            }
            else
            {
                e.Cancel = true;
                tb.Focus();
                errorProviderDetails.SetError(tb, $"{tbLabel.Text} is incorrect or missing.");
            }
        }

        private bool validateContent(TextBox tb)
        {
            string tbName = tb.Name;
            bool fieldIsValid = true;

            if (string.IsNullOrEmpty(tb.Text))
            {
                fieldIsValid = false;
            }

            else if (tbName == "txtEmail")
            {
                string email = tb.Text;
                fieldIsValid = isEmailValid(email);
            }

            else if (tbName == "txtPhone")
            {
                string phoneNumber = tb.Text;
                Regex regex = new Regex(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
                Match match = regex.Match(phoneNumber);

                fieldIsValid = match.Success;
            }

            else if (tbName == "txtLastName" || tbName == "txtFirstName")
            {
                string alpha = tb.Text;
                fieldIsValid = alpha.All(x => char.IsLetter(x) || x == ' ' || x == '-');
            }

            return fieldIsValid;
        }
        private bool isEmailValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }
}
