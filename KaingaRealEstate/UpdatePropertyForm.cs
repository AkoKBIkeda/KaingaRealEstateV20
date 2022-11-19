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
    public partial class UpdatePropertyForm : Form
    {
        private DataController DC;
        private SalesClerkMainForm frmMenu;
        private int aSuburbID, aPropertyID, aSellerID, aCategoryID;
        private CurrencyManager cmProperty, cmSuburb, cmSeller, cmCategory;
        private void UpdatePropertyForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadProperties();
            DisableUpdate(this);
        }

        public UpdatePropertyForm(DataController dc, SalesClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsKainga, "PROPERTY"];
            cmSuburb = (CurrencyManager)this.BindingContext[DC.dsKainga, "SUBURB"];
            cmCategory = (CurrencyManager)this.BindingContext[DC.dsKainga, "CATEGORY"];
            cmSeller = (CurrencyManager)this.BindingContext[DC.dsKainga, "SELLER"];
        }
        public void ClearFields()
        {
            cboProperties.Text = "";
            cboProperties.Items.Clear();
            txtPropertyID.Text = "";
            txtStatus.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtPropertyDescription.Text = "";
            nudPrice.ResetText();
            txtCategoryDescription.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
        }
        private void LoadProperties()
        {
            foreach (DataRow drProperty in DC.dtProperty.Rows)
            {
                if (drProperty["status"].ToString() == "Available")
                {
                    cboProperties.Items.Add(drProperty["propertyID"] + (" ") + drProperty["propertyDescription"]);
                }
            }
        }
        private void cboProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboProperties.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aPropertyID = Convert.ToInt32(subs[0]);
            cmProperty.Position = DC.propertyView.Find(aPropertyID);
            DataRow drProperty = DC.dtProperty.Rows[cmProperty.Position];
            txtPropertyID.Text = drProperty["propertyID"].ToString();
            txtStatus.Text = drProperty["status"].ToString();
            txtStreetAddress.Text = drProperty["streetAddress"].ToString();
            aSuburbID = Convert.ToInt32(drProperty["suburbID"]);
            cmSuburb.Position = DC.suburbView.Find(aSuburbID);
            DataRow drSuburb = DC.dtSuburb.Rows[cmSuburb.Position];
            txtSuburb.Text = drSuburb["suburbName"].ToString();
            txtPropertyDescription.Text = drProperty["propertyDescription"].ToString();
            nudPrice.Value = Convert.ToDecimal(drProperty["price"]);
            aCategoryID = Convert.ToInt32(drProperty["categoryID"]);
            cmCategory.Position = DC.categoryView.Find(aCategoryID);
            DataRow drCategory = DC.dtCategory.Rows[cmCategory.Position];
            txtCategoryDescription.Text = drCategory["categoryDescription"].ToString();
            aSellerID = Convert.ToInt32(drProperty["sellerID"]);
            cmSeller.Position = DC.sellerView.Find(aSellerID);
            DataRow drSeller = DC.dtSeller.Rows[cmSeller.Position];
            txtLastName.Text = drSeller["lastName"].ToString();
            txtFirstName.Text = drSeller["firstName"].ToString();

            EnableUpdate(this);
        }
        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {
            if ((txtPropertyDescription.Text == "") || (txtStreetAddress.Text == "")||(nudPrice.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this property?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DataRow updatePropertyRow = DC.dtProperty.Rows[cmProperty.Position];
                        updatePropertyRow["streetAddress"] = txtStreetAddress.Text;
                        updatePropertyRow["propertyDescription"] = txtPropertyDescription.Text;
                        updatePropertyRow["price"] = nudPrice.Value;
                        DC.UpdateProperty();
                        MessageBox.Show("Property updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadProperties();
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
        private void DisableUpdate(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Enabled = false;
                }
            }
            nudPrice.Enabled = false;
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
            nudPrice.Enabled = true;
        }
    }
}
