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
    public partial class AddOfferForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aBuyerID, aPropertyID;
        private CurrencyManager cmBuyer;
        private CurrencyManager cmProperty;
        public AddOfferForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "BUYER"];
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsKainga, "PROPERTY"];
        }
        private void ClearFields()
        {
            txtBuyerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            cboBuyers.Text = "";
            cboBuyers.Items.Clear();
            cboProperties.Text = "";
            cboProperties.Items.Clear();
            txtPropertyID.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            txtStreetAddress.Text = "";
            nudOfferAmount.Value = 1000000;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void AddOfferForm_Load(object sender, EventArgs e)
        {
            LoadFields();

        }
        private void LoadFields()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                {
                    cboBuyers.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
                }
            }
            foreach (DataRow drProperty in DC.dtProperty.Rows)
            {
                if (drProperty["status"].ToString() == "Available") // added
                {
                    cboProperties.Items.Add(drProperty["propertyID"] + (" ") + drProperty["propertyDescription"]);
                }
            }
        }
        private void btnAddOffer_Click(object sender, EventArgs e)
        {
            if ((nudOfferAmount.Text == "") || (cboBuyers.Text == "") || (cboProperties.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataRow newOffer = DC.dtOffer.NewRow();
                    newOffer["buyerID"] = aBuyerID;
                    newOffer["propertyID"] = aPropertyID;
                    newOffer["offerAmount"] = nudOfferAmount.Value;
                    newOffer["status"] = "Pending";
                    newOffer["offerDate"] = DateTime.Today;
                    DC.dtOffer.Rows.Add(newOffer);
                    DC.UpdateOffer();
                    MessageBox.Show("Offer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadFields();
                }
                catch (System.Data.ConstraintException)
                {
                    object[] keys = new object[2];   // Create an array for the key values to find.
                    keys[0] = aBuyerID; // Set the values of the keys to find.
                    keys[1] = aPropertyID; // Set the values of the keys to find.
                    DataRow updateOfferRow = DC.dtOffer.Rows.Find(keys);
                    updateOfferRow["offerAmount"] = nudOfferAmount.Value;
                    updateOfferRow["offerDate"] = DateTime.Today;
                    if (MessageBox.Show("The buyer already have an offer on this property. Update the offer amount?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DC.UpdateOffer();
                        MessageBox.Show("The offer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadFields();
                    }
                }
            }
        }
        private void cboBuyers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboBuyers.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aBuyerID = Convert.ToInt32(subs[0]);
            cmBuyer.Position = DC.buyerView.Find(aBuyerID);
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            txtBuyerID.Text = drBuyer["buyerID"].ToString();
            txtLastName.Text = drBuyer["lastName"].ToString();
            txtFirstName.Text = drBuyer["firstName"].ToString();
            txtEmailAddress.Text = drBuyer["emailAddress"].ToString();
            txtPhoneNumber.Text = drBuyer["phoneNumber"].ToString();
        }

        private void cboProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboProperties.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aPropertyID = Convert.ToInt32(subs[0]);
            cmProperty.Position = DC.propertyView.Find(aPropertyID);
            DataRow drProperty = DC.dtProperty.Rows[cmProperty.Position];
            txtPropertyID.Text = drProperty["propertyID"].ToString();
            txtDescription.Text = drProperty["propertyDescription"].ToString();
            txtStreetAddress.Text = drProperty["streetAddress"].ToString();
            double amount = Convert.ToDouble(drProperty["price"]);
            string aPrice = $"{amount:C2}";
            txtPrice.Text = aPrice;
        }
    }
}

