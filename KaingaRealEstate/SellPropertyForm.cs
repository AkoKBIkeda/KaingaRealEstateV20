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
    public partial class SellPropertyForm : Form
    {
        private DataController DC;
        private SalesClerkMainForm frmMenu;
        private int aBuyerID, aPropertyID, aSellerID;
        private CurrencyManager cmProperty, cmBuyer, cmSeller;
        public SellPropertyForm(DataController dc, SalesClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsKainga, "PROPERTY"];
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "BUYER"];
            cmSeller = (CurrencyManager)this.BindingContext[DC.dsKainga, "SELLER"];
        }
        public void ClearFields()
        {
            txtPropertyID.Text = "";
            txtStreetAddress.Text = "";
            txtPropertyDescription.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            cboProperties.Text = "";
            cboProperties.Items.Clear();
            lstOffers.Items.Clear();
        }
        private void LoadProperties()
        {
            foreach (DataRow drProperty in DC.dtProperty.Rows)
            {
                if (drProperty["status"].ToString() == "Available")
                {
                    DataRow[] drOffers = drProperty.GetChildRows(DC.dtProperty.ChildRelations["PROPERTY_OFFER"]);
                    if (drOffers.Length != 0)
                    {
                        cboProperties.Items.Add(drProperty["propertyID"] + (" ") + drProperty["propertyDescription"]);
                    }
                }
            }
        }

        private void lstOffers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOffers.SelectedItem == null)
            {
                lstOffers.SelectedIndex = 0;
            }
            if (lstOffers.SelectedIndex == 0) // nothing happens when the label or empty space is selected
            {
            }
            else
            {
                string aRow = lstOffers.SelectedItem.ToString();
                string[] subs = aRow.Split('\t');
                aBuyerID = Convert.ToInt32(subs[2]);
            }
        }

        private void btnSellProperty_Click(object sender, EventArgs e)
        {
            if ((cboProperties.Text == "")||(lstOffers.SelectedIndex == 0))
            {
                MessageBox.Show("Please select an option properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure to sell this property with the offer?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    object[] keys = new object[2];   // Create an array for the key values to find.
                    keys[0] = aBuyerID; // Set the values of the keys to find.
                    keys[1] = aPropertyID; // Set the values of the keys to find.
                    DataRow successOfferRow = DC.dtOffer.Rows.Find(keys);
                    DataRow drProperty = successOfferRow.GetParentRow(DC.dtOffer.ParentRelations["PROPERTY_OFFER"]);
                    drProperty["status"] = "Sold"; // change the property's status to "Sold"
                    DataRow[] drOffers = drProperty.GetChildRows(DC.dtProperty.ChildRelations["PROPERTY_OFFER"]);
                    foreach (DataRow drOffer in drOffers)
                    {
                        if (drOffer == successOfferRow)
                        {
                            successOfferRow["status"] = "Successful"; // change the selected offer's status to "Successful"
                        }
                        else
                        {
                            drOffer["status"] = "Unsuccessful"; // change the rest of offers' status to "Unsuccessful"
                        }
                    }
                    DC.UpdateProperty();
                    DC.UpdateOffer();
                    MessageBox.Show("Property sold successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadProperties();
                }
                else
                {
                    return;
                }
            }
        }
        private void SellPropertyForm_Load(object sender, EventArgs e)
        {
            LoadProperties();
        }

        private void cboProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOffers.Items.Clear();
            string aRow = cboProperties.SelectedItem.ToString();
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
            txtLastName.Text = drSeller["lastName"].ToString();
            txtFirstName.Text = drSeller["firstName"].ToString();
            LoadOffers();
        }
        private void LoadOffers() // if time allows, sort by offer amount;
        {
            DataRow drProperty = DC.dtProperty.Rows[cmProperty.Position];
            DataRow[] drOffers = drProperty.GetChildRows(DC.dtProperty.ChildRelations["PROPERTY_OFFER"]);
            lstOffers.Items.Add("Offer Amount\r\tOffer Date\r\tBuyer\r\n");
            foreach (DataRow drOffer in drOffers)
            {
                DataRow drBuyer = drOffer.GetParentRow(DC.dtOffer.ParentRelations["BUYER_OFFER"]);
                double amount = Convert.ToDouble(drOffer["offerAmount"]);
                string anOfferAmount = $"{amount:C2}";
                lstOffers.Items.Add(anOfferAmount + "\r\t" + ((DateTime)drOffer["offerDate"]).ToShortDateString() +"\r\t"+ drBuyer["buyerID"]+"\r\t"+drBuyer["firstName"] +" "+drBuyer["lastName"] +"\r\n");
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
    }
}
