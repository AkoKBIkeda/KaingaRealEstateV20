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
    public partial class BuyerReportForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int offerCount;
        private DataRow[] buyersForPrint;
        public BuyerReportForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
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
            txtBuyers.Text = "";
        }
        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string strFilter = null;
            string strSort = "lastName, firstName";
            buyersForPrint = DC.dsKainga.Tables["BUYER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            txtBuyers.Text = "";
            string buyerText = "";
            foreach (DataRow drBuyer in buyersForPrint)
            {
                buyerText += "Buyer ID: " + drBuyer["buyerID"] + "\r\tName: " + drBuyer["firstName"] + " " + drBuyer["lastName"]
                            + "\r\nAddress: " + drBuyer["streetAddress"] + ", " + drBuyer["suburb"] + ", " + drBuyer["city"]
                            + "\r\nPhone Number: " + drBuyer["phoneNumber"] + "\r\t\r\tEmail Address: " + drBuyer["emailAddress"]
                            + "\r\nCredit Status: " + drBuyer["creditStatus"] + "\r\t\r\tMortgage Status: " + drBuyer["mortgageStatus"];
                DataRow drAgent = drBuyer.GetParentRow(DC.dtBuyer.ParentRelations["AGENT_BUYER"]);
                buyerText += "\r\nAgent Name: " + drAgent["firstName"]+" "+ drAgent["lastName"]+"\r\n\r\n";
                DataRow[] drOffers = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_OFFER"]);
                if (drOffers.Length != 0)
                {
                    foreach (DataRow drOffer in drOffers)
                    {
                        offerCount++;
                    }
                    buyerText += "Number of properties made an offer on: " + offerCount;
                }
                else
                {
                    buyerText += "This buyer has not made an offer on any properties yet.";
                }
                buyerText += "\r\n\r\n----------------------------------------------------\r\n\r\n";
                txtBuyers.Text += buyerText;
                offerCount = 0;
                buyerText = "";
            }
        }
    }
}
