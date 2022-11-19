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
    public partial class UpdateAgentForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        private int aAgentID;
        private CurrencyManager cmAgent;

        bool reset = false;
        public UpdateAgentForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
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
            txtAgentID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            nudSalary.ResetText();
            cboCert.Text = "";
            cboCert.Items.Clear();
            cboAgent.Text = "";
            cboAgent.Items.Clear();
        }
        private void LoadAgents()
        {
            foreach (DataRow drAgent in DC.dtAgent.Rows)
            {
                cboAgent.Items.Add(drAgent["agentID"] + (" ") + drAgent["lastName"] + (" ") + drAgent["firstName"]);
            }
            cboCert.Items.Add("Yes");
            cboCert.Items.Add("No");
        }
        private void cboAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string agent;

            if (reset)
            {
                reset = false;
            }

            if (cboAgent.SelectedItem != null)
            {
                // get the selected agent
                agent = cboAgent.SelectedItem.ToString();
                // split the string from cbo
                string[] parts = agent.Split(' ');
                // extract ID
                aAgentID = Convert.ToInt32(parts[0]);
                // Get the position of the selected agent and assigns it to the Position property of cmAgent
                cmAgent.Position = DC.agentView.Find(aAgentID);
                // Get the datarow for the selected agent
                DataRow drAgent = DC.dtAgent.Rows[cmAgent.Position];
                // Populate agent textboxes
                txtAgentID.Text = drAgent["agentID"].ToString();
                txtLastName.Text = drAgent["lastName"].ToString();
                txtFirstName.Text = drAgent["firstName"].ToString();
                txtStreetAddress.Text = drAgent["streetAddress"].ToString();
                txtSuburb.Text = drAgent["suburb"].ToString();
                txtEmail.Text = drAgent["emailAddress"].ToString();
                txtPhone.Text = drAgent["phoneNumber"].ToString();
                nudSalary.Text = drAgent["salary"].ToString();
                cboCert.Text = drAgent["certification"].ToString();
            }
            EnableUpdate(this);
        }
        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);
            if (detailValid)
            {
                // get data row for selected agent
                DataRow updateAgentRow = DC.dtAgent.Rows[cmAgent.Position];
                // assign textbox values to updateAgentRow
                updateAgentRow["lastName"] = txtLastName.Text;
                updateAgentRow["firstName"] = txtFirstName.Text;
                updateAgentRow["streetAddress"] = txtStreetAddress.Text;
                updateAgentRow["suburb"] = txtSuburb.Text;
                updateAgentRow["emailAddress"] = txtEmail.Text;
                updateAgentRow["phoneNumber"] = txtPhone.Text;
                updateAgentRow["salary"] = nudSalary.Text;
                updateAgentRow["certification"] = cboCert.Text;
                // End current edit if confirmed
                if (MessageBox.Show("Are you sure you want to update this agent?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmAgent.EndCurrentEdit();
                    DC.UpdateAgent();
                    MessageBox.Show("Agent updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadAgents();
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
            nudSalary.Enabled = false;
            cboCert.Enabled = false;
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
            nudSalary.Enabled = true;
            cboCert.Enabled = true;
        }
        private void UpdateAgentForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadAgents();
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
