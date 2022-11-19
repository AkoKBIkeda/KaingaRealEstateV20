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
    public partial class UpdateCategoryForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        private int aCategoryID;
        private CurrencyManager cmCategory;

        bool reset = false;
        public UpdateCategoryForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmCategory = (CurrencyManager)this.BindingContext[DC.dsKainga, "CATEGORY"];
        }
        private void ClearFields()
        {
            txtCategoryID.Text = "";
            txtCatDesc.Text = "";
            cboCategory.Text = "";
            cboCategory.Items.Clear();
            cboLevel.Items.Clear();
            cboLevel.Text = "";
        }
        private void LoadCategories()
        {
            foreach (DataRow drCat in DC.dtCategory.Rows)
            {
                cboCategory.Items.Add(drCat["categoryID"] + (" ") + drCat["categoryDescription"]);
            }
            cboLevel.Items.AddRange(Enumerable.Range(1, 8).Select(i => (object)i).ToArray());
        }
        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadCategories();
            DisableUpdate(this);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

            reset = true;
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);

            ClearFields();
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

            return fieldIsValid;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat;

            if (reset)
            {
                reset = false;
            }

            if (cboCategory.SelectedItem != null)
            {
                // get the selected cat
                cat = cboCategory.SelectedItem.ToString();
                // split the string from cbo
                string[] parts = cat.Split(' ');
                // extract ID
                aCategoryID = Convert.ToInt32(parts[0]);
                // Get the position of the selected cat and assigns it to the Position property of cm
                cmCategory.Position = DC.categoryView.Find(aCategoryID);
                // Get the datarow for the selected cat
                DataRow drCategory = DC.dtCategory.Rows[cmCategory.Position];
                // Populate cat textboxes
                txtCategoryID.Text = drCategory["categoryID"].ToString();
                txtCatDesc.Text = drCategory["categoryDescription"].ToString();
                cboLevel.Text = drCategory["level"].ToString();
            }
            EnableUpdate(this);
        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            bool detailValid = ValidateChildren(ValidationConstraints.Enabled);
            if (detailValid)
            {
                // get data row for selected cat
                DataRow updateCatRow = DC.dtCategory.Rows[cmCategory.Position];
                // assign textbox values to updateCatRow
                updateCatRow["categoryDescription"] = txtCatDesc.Text;
                updateCatRow["level"] = cboLevel.Text;
                // End current edit if confirmed
                if (MessageBox.Show("Are you sure you want to update this category?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmCategory.EndCurrentEdit();
                    DC.UpdateSuburb();
                    MessageBox.Show("Category updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadCategories();
                }
            }
        }
    }
}
