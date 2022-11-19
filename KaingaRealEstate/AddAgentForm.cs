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
    public partial class AddAgentForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;

        public AddAgentForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void AddAgentForm_Load(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtEmailAddress.Text = "";
            txtEmailAddress.BackColor = System.Drawing.Color.White;
            txtPhoneNumber.Text = "";
            txtPhoneNumber.BackColor = System.Drawing.Color.White;
            cboCertification.Text = "";
            cboCertification.SelectedIndex = -1;
            nudSalary.Value = 70000;
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            txtEmailAddress.BackColor = System.Drawing.Color.White;
            txtPhoneNumber.BackColor = System.Drawing.Color.White;
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
                (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                (txtEmailAddress.Text == "") || (txtPhoneNumber.Text == "") || (nudSalary.Text == "") ||
                (cboCertification.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                            DataRow newAgentRow = DC.dtAgent.NewRow();
                            newAgentRow["lastName"] = txtLastName.Text;
                            newAgentRow["firstName"] = txtFirstName.Text;
                            newAgentRow["streetAddress"] = txtStreetAddress.Text;
                            newAgentRow["suburb"] = txtSuburb.Text;
                            newAgentRow["emailAddress"] = txtEmailAddress.Text;
                            newAgentRow["phoneNumber"] = txtPhoneNumber.Text;
                            newAgentRow["certification"] = cboCertification.Text;
                            newAgentRow["salary"] = nudSalary.Value;

                            DC.dtAgent.Rows.Add(newAgentRow);
                            DC.UpdateAgent();
                            MessageBox.Show("Agent added successfully");
                            ClearFields();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
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

