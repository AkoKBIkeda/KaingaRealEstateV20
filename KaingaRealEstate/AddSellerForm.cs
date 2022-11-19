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
    public partial class AddSellerForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        public AddSellerForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
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
            cboStatus.SelectedIndex = -1;
            cboStatus.Text = "";
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            txtEmailAddress.BackColor = System.Drawing.Color.White;
            txtPhoneNumber.BackColor = System.Drawing.Color.White;
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
                (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                (txtCity.Text == "") || (txtPhoneNumber.Text == "") ||
                (txtEmailAddress.Text == "") || (cboStatus.Text == ""))
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
                    // https://social.msdn.microsoft.com/Forums/vstudio/en-US/6cb67cec-bb41-435f-be78-15395c098456/how-to-make-the-textbox-to-highlight-in-c?forum=csharpgeneral
                    txtEmailAddress.BackColor = System.Drawing.Color.LightYellow;
                    // setting cursor at the email textbox
                    // https://stackoverflow.com/questions/20423211/setting-cursor-at-the-end-of-any-text-of-a-textbox
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
                            DataRow newSellerRow = DC.dtSeller.NewRow();
                            newSellerRow["lastName"] = txtLastName.Text;
                            newSellerRow["firstName"] = txtFirstName.Text;
                            newSellerRow["streetAddress"] = txtStreetAddress.Text;
                            newSellerRow["suburb"] = txtSuburb.Text;
                            newSellerRow["city"] = txtCity.Text;
                            newSellerRow["phoneNumber"] = txtPhoneNumber.Text;
                            newSellerRow["emailAddress"] = txtEmailAddress.Text;
                            newSellerRow["status"] = cboStatus.SelectedItem;

                            DC.dtSeller.Rows.Add(newSellerRow);
                            DC.UpdateSeller();
                            MessageBox.Show("Seller added successfully", "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //https://stackoverflow.com/questions/12607087/only-allow-specific-characters-in-textbox
            // 8 is Backspace key; 46 is Delete key. 
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
        
        private void txtEmailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != 8 && ch != 46 && e.KeyChar != '@' && e.KeyChar != '-' && e.KeyChar != '\'')  //   && !char.IsNumber(ch)
            {
                MessageBox.Show("Sorry, that is invaild character for email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }*/
        }
    }
}

