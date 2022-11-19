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
    public partial class AddPropertyForm : Form
    {
        private DataController DC;
        private SalesClerkMainForm frmMenu;
        private CurrencyManager cmProperty;
        private CurrencyManager cmSuburb;
        private CurrencyManager cmCategory;
        private CurrencyManager cmSeller;
        private int aSuburbID, aCategoryID, aSellerID;

        public AddPropertyForm(DataController dc, SalesClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsKainga, "PROPERTY"];
            cmSeller = (CurrencyManager)this.BindingContext[DC.dsKainga, "SELLER"];
            cmSuburb = (CurrencyManager)this.BindingContext[DC.dsKainga, "SUBURB"];
            cmCategory = (CurrencyManager)this.BindingContext[DC.dsKainga, "CATEGORY"];
        }
        private void AddPropertyForm_Load(object sender, EventArgs e)
        {
            LoadFields();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            DataRow newPropertyRow = DC.dtProperty.NewRow();
            if ((txtStreetAddress.Text == "") || (txtDescription.Text == "") ||
                (nudPrice.Text == "") || (cboSuburb.Text == "") ||
                (cboCategories.Text == "") || (cboSellers.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {

                try  // why do we need try and catch???
                {
                    newPropertyRow["streetAddress"] = txtStreetAddress.Text;
                    newPropertyRow["propertyDescription"] = txtDescription.Text;
                    newPropertyRow["price"] = nudPrice.Value;
                    newPropertyRow["status"] = "Available";
                    newPropertyRow["suburbID"] = aSuburbID.ToString(); // ToString() required??
                    newPropertyRow["categoryID"] = aCategoryID.ToString();  // ToString() required??
                    newPropertyRow["sellerID"] = aSellerID.ToString();  // ToString() required??
                    DC.dtProperty.Rows.Add(newPropertyRow);
                    DC.UpdateProperty();
                    MessageBox.Show("Property added successfully", "Acknowledgement", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error");
                }
                ClearFields();
                LoadFields();
            }
        }
        private void LoadFields()

        {
            foreach (DataRow drSuburb in DC.dtSuburb.Rows)
            {
                cboSuburb.Items.Add(drSuburb["suburbID"] + (" ") + drSuburb["suburbName"]);
            }
            foreach (DataRow drCategory in DC.dtCategory.Rows)
            {
                cboCategories.Items.Add(drCategory["categoryID"] + (": ") + drCategory["categoryDescription"]);
            }
            foreach (DataRow drSeller in DC.dtSeller.Rows)
            {
                cboSellers.Items.Add(drSeller["sellerID"] + (" ") + drSeller["lastName"] + (" ") + drSeller["firstName"]);

            }
        }
        private void ClearFields()
        {
            txtStreetAddress.Text = "";
            txtDescription.Text = "";
            nudPrice.Value = 1000000;
            cboSuburb.Items.Clear();
            cboCategories.Items.Clear();
            cboSellers.Items.Clear();
            cboSuburb.Text = "";
            cboCategories.Text = "";
            cboSellers.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void cboSuburb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboSuburb.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aSuburbID = Convert.ToInt32(subs[0]);
           // cmSuburb.Position = DC.suburbView.Find(aSuburbID);
            //DataRow drSuburb = DC.dtSuburb.Rows[cmSuburb.Position];
        }

        private void cboSellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboSellers.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aSellerID = Convert.ToInt32(subs[0]);
           // cmSeller.Position = DC.sellerView.Find(aSellerID);
          //  DataRow drSeller = DC.dtSeller.Rows[cmSeller.Position];
        }
        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboCategories.SelectedItem.ToString();
            string[] subs = aRow.Split(':');
            aCategoryID = Convert.ToInt32(subs[0]);
         //   cmCategory.Position = DC.categoryView.Find(aCategoryID);
         //   DataRow drCategory = DC.dtCategory.Rows[cmCategory.Position];
        }
    }
}

