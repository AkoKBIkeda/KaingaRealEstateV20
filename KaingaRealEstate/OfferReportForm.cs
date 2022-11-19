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
    public partial class OfferReportForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private DataRow[] buyersForSorted;
        public OfferReportForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            txtOffers.Text = "";
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string strFilter = null;
            string strSort = "lastName, firstName";
            buyersForSorted = DC.dsKainga.Tables["BUYER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            txtOffers.Text = "";
            string offerText = "";
            foreach (DataRow drBuyer in buyersForSorted)
            {
                DataRow[] drOffers = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_OFFER"]);
                if (drOffers.Length !=0)
                {
                    foreach (DataRow drOffer in drOffers)
                    {
                        DataRow drProperty = drOffer.GetParentRow(DC.dtOffer.ParentRelations["PROPERTY_OFFER"]);
                        DataRow drSeller = drProperty.GetParentRow(DC.dtProperty.ParentRelations["SELLER_PROPERTY"]);
                        double amount = Convert.ToDouble(drOffer["offerAmount"]);
                        string anOfferAmount = $"{amount:C2}";
                        offerText += "Offer Date: " + ((DateTime)drOffer["offerDate"]).ToShortDateString() + "\r\tOffer Amount: " + anOfferAmount + "\r\tStatus: " + drOffer["status"]
                                    + "\r\nBuyer ID: " + drOffer["buyerID"] + "\r\tBuyer Name: " + drBuyer["firstName"] + " " + drBuyer["lastName"]
                                    + "\r\nProperty ID: " + drOffer["propertyID"] + "\r\tAddress: " + drProperty["streetAddress"]
                                    + "\r\nProperty Description: " + drProperty["propertyDescription"]
                                    + "\r\nSeller Name: " + drSeller["firstName"] + " " + drSeller["lastName"]
                                    + "\r\n\r\n----------------------------------------------------\r\n\r\n";
                    }
                    txtOffers.Text += offerText;
                    offerText = "";
                }
            }
        }
    }
}
