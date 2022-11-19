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
    public partial class DeletePropertyForm : Form
    {
        private DataController DC;
        private SalesClerkMainForm frmMenu;
        int aPropertyID, aSellerID;
        private CurrencyManager cmProperty, cmSeller;
        public DeletePropertyForm(DataController dc, SalesClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            frmMenu.Hide();
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsKainga, "PROPERTY"];
            cmSeller = (CurrencyManager)this.BindingContext[DC.dsKainga, "SELLER"];
        }
        private void LoadProperties()
        {
            foreach (DataRow drProperty in DC.dtProperty.Rows)
            {
                if (drProperty["status"].ToString() == "Sold") //added
                {
                    cboProperty.Items.Add(drProperty["propertyID"] + (" ") + drProperty["streetAddress"] + (" ") + drProperty["propertyDescription"]);
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void DeletePropertyForm_Load(object sender, EventArgs e)
        {
            LoadProperties();
        }
        private void ClearFields()
        {
            txtPropertyID.Text = "";
            txtSellerLastName.Text = "";
            txtSellerFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtPropertyDescription.Text = "";
            cboProperty.Text = "";
            cboProperty.Items.Clear();
        }
        private void cboProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string aRow = cboProperty.SelectedItem.ToString();
                string[] subs = aRow.Split(' ');
                aPropertyID = Convert.ToInt32(subs[0]);
                cmProperty.Position = DC.propertyView.Find(aPropertyID);
                DataRow drProperty = DC.dtProperty.Rows[cmProperty.Position];
                txtPropertyID.Text = drProperty["propertyID"].ToString();
                txtStreetAddress.Text = drProperty["streetAddress"].ToString();
                txtPropertyDescription.Text = drProperty["propertyDescription"].ToString();
                aSellerID = Convert.ToInt32(drProperty["sellerID"]);
                cmSeller.Position = DC.sellerView.Find(aSellerID);
                DataRow drSeller = DC.dtSeller.Rows[cmSeller.Position];
                txtSellerLastName.Text = drSeller["lastName"].ToString();
                txtSellerFirstName.Text = drSeller["firstName"].ToString();
            }
        }
        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            if (cboProperty.Text == "") //added this if statement. the button won't work if there is nothing to remove.
            {
                return;
            }
            else
            {
                DataRow deletePropertyRow = DC.dtProperty.Rows[cmProperty.Position];
                if (MessageBox.Show("Are you sure to delete this property?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deletePropertyRow.Delete();
                    DC.UpdateProperty();
                    MessageBox.Show("Property deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadProperties();
                }
            }
        }
    }
}

