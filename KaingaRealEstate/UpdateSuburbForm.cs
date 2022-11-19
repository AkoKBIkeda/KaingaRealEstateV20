using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaingaRealEstate
{
    public partial class UpdateSuburbForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        private int aSuburbID;
        private CurrencyManager cmSuburb;

        bool reset = false;
        public UpdateSuburbForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmSuburb = (CurrencyManager)this.BindingContext[DC.dsKainga, "SUBURB"];
        }
        private void ClearFields()
        {
            txtSuburbID.Text = "";
            txtSuburbName.Text = "";
            txtPostcode.Text = "";
            cboSuburb.Text = "";
            cboSuburb.Items.Clear();
        }
        private void LoadSuburbs()
        {
            foreach (DataRow drSuburb in DC.dtSuburb.Rows)
            {
            cboSuburb.Items.Add(drSuburb["suburbID"] + (" ") + drSuburb["suburbName"]);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

            reset = true;
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);

            ClearFields();
        }

        private void cboSuburb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string suburb;

            if (reset)
            {
                reset = false;
            }

            if (cboSuburb.SelectedItem != null)
            {
                // get the selected suburb
                suburb = cboSuburb.SelectedItem.ToString();
                // split the string from cbo
                string[] parts = suburb.Split(' ');
                // extract ID
                aSuburbID = Convert.ToInt32(parts[0]);
                // Get the position of the selected suburb and assigns it to the Position property of cmSuburb
                cmSuburb.Position = DC.suburbView.Find(aSuburbID);
                // Get the datarow for the selected suburb
                DataRow drSuburb = DC.dtSuburb.Rows[cmSuburb.Position];
                // Populate suburb textboxes
                txtSuburbID.Text = drSuburb["suburbID"].ToString();
                txtSuburbName.Text = drSuburb["suburbName"].ToString();
                txtPostcode.Text = drSuburb["postcode"].ToString();
            }
            EnableUpdate(this);
        }
        private void btnUpdateSuburb_Click(object sender, EventArgs e)
        {
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);
            if (detailValid)
            {
                // get data row for selected suburb
                DataRow updateSuburbRow = DC.dtSuburb.Rows[cmSuburb.Position];
                // assign textbox values to updateSuburbRow
                updateSuburbRow["suburbName"] = txtSuburbName.Text;
                updateSuburbRow["postcode"] = txtPostcode.Text;
                // End current edit if confirmed
                if (MessageBox.Show("Are you sure you want to update this suburb?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmSuburb.EndCurrentEdit();
                    DC.UpdateSuburb();
                    MessageBox.Show("Suburb updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadSuburbs();
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
        }
        private void UpdateSuburbForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadSuburbs();
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

            else if (tbName == "txtPostcode")
            {
                string postCode = tb.Text;
                Regex regex = new Regex(@"^\d{4}$");
                Match match = regex.Match(postCode);

                fieldIsValid = match.Success;
            }

            else
            {
                string alpha = tb.Text;
                fieldIsValid = alpha.All(x => char.IsLetter(x) || x == ' ');
            }

            return fieldIsValid;
        }
    }   
}
