using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaingaRealEstate
{
    public partial class AddBuyerForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aAgentID;
        //private CurrencyManager cmAgent;
        private CurrencyManager cmBuyer;
        public AddBuyerForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "Buyer"];
        }
        private void ClearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtEmailAddress.Text = "";
            txtEmailAddress.BackColor = System.Drawing.Color.White;
            txtPhoneNumber.Text = "";
            txtPhoneNumber.BackColor = System.Drawing.Color.White;
            cboAgents.Items.Clear();
            cboAgents.Text = "";
            cboCreditStatus.SelectedIndex = -1;
            cboCreditStatus.Text = "";
            cboMortgageStatus.SelectedIndex = -1;
            cboMortgageStatus.Text = "";
        }
        private void LoadAgent()
        {
            foreach (DataRow drAgent in DC.dtAgent.Rows)
            {
                cboAgents.Items.Add(drAgent["agentID"] + (" ") + drAgent["lastName"] + (" ") + drAgent["firstName"]);
            }
        }

        private void AddBuyerForm_Load(object sender, EventArgs e)
        {
            LoadAgent();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            txtEmailAddress.BackColor = System.Drawing.Color.White;
            txtPhoneNumber.BackColor = System.Drawing.Color.White;
            if ((txtFirstName.Text == "") || (txtLastName.Text == "") ||
                (txtCity.Text == "") || (txtSuburb.Text == "") ||
                (txtStreetAddress.Text == "") ||
                (txtEmailAddress.Text == "") || (txtPhoneNumber.Text == "") ||
                (cboCreditStatus.Text == "") || (cboMortgageStatus.Text == "") ||
                (cboAgents.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!(txtEmailAddress.Text.Contains("@")))
                {
                    MessageBox.Show("Please include full domain name for email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Highlight email text box
                    txtEmailAddress.BackColor = System.Drawing.Color.LightYellow;
                    // setting cursor at the email textbox
                    txtEmailAddress.Select();
                }
                else
                {
                    if (txtPhoneNumber.Text.Length < 9)
                    {
                        MessageBox.Show("Phone number should be at least 9 digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNumber.BackColor = System.Drawing.Color.LightYellow;
                        txtPhoneNumber.Select();
                    }
                    else
                    {
                        try
                        {
                            DataRow newBuyerRow = DC.dtBuyer.NewRow();
                            newBuyerRow["lastName"] = txtLastName.Text;
                            newBuyerRow["firstName"] = txtFirstName.Text;
                            newBuyerRow["streetAddress"] = txtStreetAddress.Text;
                            newBuyerRow["city"] = txtCity.Text;
                            newBuyerRow["suburb"] = txtSuburb.Text;
                            newBuyerRow["emailAddress"] = txtEmailAddress.Text;
                            newBuyerRow["phoneNumber"] = txtPhoneNumber.Text;
                            newBuyerRow["creditStatus"] = cboCreditStatus.Text;
                            newBuyerRow["mortgageStatus"] = cboMortgageStatus.Text;
                            newBuyerRow["agentID"] = aAgentID;

                            DC.dtBuyer.Rows.Add(newBuyerRow);
                            DC.UpdateBuyer();
                            MessageBox.Show("Buyer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadAgent();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
        }
            private void cboAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboAgents.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aAgentID = Convert.ToInt32(subs[0]);
            cmBuyer.Position = DC.buyerView.Find(aAgentID);
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                MessageBox.Show("Name only accepts alphabet, hyphen, and apostrophe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                MessageBox.Show("Name only accepts alphabet, hyphen, and apostrophe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Phone number only accepts numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}


