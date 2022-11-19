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
    public partial class AddSuburbForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        public AddSuburbForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        private void AddSuburbForm_Load(object sender, EventArgs e)
        {
        }
        private void ClearFields()
        {
            txtSuburbName.Text = "";
            txtCode.Text = "";
            txtCode.BackColor = System.Drawing.Color.White;
        }
        private void btnAddSuburb_Click(object sender, EventArgs e)
        {
            txtCode.BackColor = System.Drawing.Color.White;
            if ((txtSuburbName.Text == "") || (txtCode.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else
            {
                if (txtCode.Text.Length != 4)
                {
                    MessageBox.Show("Postcode should be 4 digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Highlight postcode text box
                    txtCode.BackColor = System.Drawing.Color.LightYellow;
                    // setting cursor at the postcode textbox
                    txtCode.Select();
                }
                else
                {
                    try
                    {
                        DataRow newSuburbRow = DC.dtSuburb.NewRow();
                        newSuburbRow["suburbName"] = txtSuburbName.Text;
                        newSuburbRow["postCode"] = txtCode.Text;
                        DC.dtSuburb.Rows.Add(newSuburbRow);
                        DC.UpdateSuburb();
                        MessageBox.Show("Suburb added successfully", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        ClearFields();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error");
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

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Postcode only accepts numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}

