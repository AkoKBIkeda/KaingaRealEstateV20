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
    public partial class UpdateSellerForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        private int aSellerID;
        private CurrencyManager cmSeller;

        bool reset = false;
        public UpdateSellerForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmSeller = (CurrencyManager)this.BindingContext[DC.dsKainga, "SELLER"];
        }
        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

            reset = true;
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);

            ClearFields();
        }
        private void ClearFields()
        {
            txtSellerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            cboStatus.Text = "";
            cboStatus.Items.Clear();
            cboSeller.Text = "";
            cboSeller.Items.Clear();
        }
        private void LoadSellers()
        {
            foreach (DataRow drSeller in DC.dtSeller.Rows)
            {
                cboSeller.Items.Add(drSeller["sellerID"] + (" ") + drSeller["lastName"] + (" ") + drSeller["firstName"]);
            }
            cboStatus.Items.Add("Valid");
            cboStatus.Items.Add("Invalid");
        }
        private void cboSeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seller;

            if (reset)
            {
                reset = false;
            }

            if (cboSeller.SelectedItem != null)
            {
                // get the selected seller
                seller = cboSeller.SelectedItem.ToString();
                // split the string from cbo
                string[] parts = seller.Split(' ');
                // extract ID
                aSellerID = Convert.ToInt32(parts[0]);
                // Get the position of the selected agent and assigns it to the Position property of cmSeller
                cmSeller.Position = DC.sellerView.Find(aSellerID);
                // Get the datarow for the selected seller
                DataRow drSeller = DC.dtSeller.Rows[cmSeller.Position];
                // Populate seller textboxes
                txtSellerID.Text = drSeller["sellerID"].ToString();
                txtLastName.Text = drSeller["lastName"].ToString();
                txtFirstName.Text = drSeller["firstName"].ToString();
                txtStreetAddress.Text = drSeller["streetAddress"].ToString();
                txtSuburb.Text = drSeller["suburb"].ToString();
                txtCity.Text = drSeller["city"].ToString();
                txtEmail.Text = drSeller["emailAddress"].ToString();
                txtPhone.Text = drSeller["phoneNumber"].ToString();
                cboStatus.Text = drSeller["status"].ToString();
            }
            EnableUpdate(this);
        }
        private void btnUpdateSeller_Click(object sender, EventArgs e)
        {
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);
            if (detailValid)
            {
                // get data row for selected agent
                DataRow updateSellerrow = DC.dtSeller.Rows[cmSeller.Position];
                // assign textbox values to updateAgentRow
                updateSellerrow["lastName"] = txtLastName.Text;
                updateSellerrow["firstName"] = txtFirstName.Text;
                updateSellerrow["streetAddress"] = txtStreetAddress.Text;
                updateSellerrow["suburb"] = txtSuburb.Text;
                updateSellerrow["emailAddress"] = txtEmail.Text;
                updateSellerrow["phoneNumber"] = txtPhone.Text;
                updateSellerrow["city"] = txtCity.Text;
                updateSellerrow["status"] = cboStatus.Text;
                // End current edit if confirmed
                if (MessageBox.Show("Are you sure you want to update this Seller?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmSeller.EndCurrentEdit();
                    DC.UpdateSeller();
                    MessageBox.Show("Seller updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadSellers();
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
            cboStatus.Enabled = false;
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
            cboStatus.Enabled = true;
        }
        private void UpdateSellerForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadSellers();
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
