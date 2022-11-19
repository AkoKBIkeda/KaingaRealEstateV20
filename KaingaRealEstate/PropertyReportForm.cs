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
    public partial class PropertyReportForm : Form
    {
        private DataController DC;
        private SalesClerkMainForm frmMenu;
        private int offerCount;
        private DataRow[] propertiesForPrint;
        public PropertyReportForm(DataController dc, SalesClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string strFilter = null;
            string strSort = "propertyID";
            propertiesForPrint = DC.dsKainga.Tables["PROPERTY"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            txtProperties.Text = "";
            string propertyText = "";
            foreach (DataRow drProperty in propertiesForPrint)
            {
                DataRow drSuburb = drProperty.GetParentRow(DC.dtProperty.ParentRelations["SUBURB_PROPERTY"]);
                DataRow drCategory = drProperty.GetParentRow(DC.dtProperty.ParentRelations["CATEGORY_PROPERTY"]);
                DataRow drSeller = drProperty.GetParentRow(DC.dtProperty.ParentRelations["SELLER_PROPERTY"]);
                double amount = Convert.ToDouble(drProperty["price"]);
                string aPrice = $"{amount:C2}";
                propertyText += "Property ID: " + drProperty["propertyID"] 
                            + "\r\nAddress: " + drProperty["streetAddress"] +", "+ drSuburb["suburbName"]
                            + "\r\nProperty Description: " + drProperty["propertyDescription"]
                            + "\r\nStatus: " + drProperty["status"] + "\r\t\r\tPrice: " + aPrice
                            + "\r\nCategory Description: " + drCategory["categoryDescription"]
                            + "\r\nSeller Name: "+ drSeller["firstName"]+" "+ drSeller["lastName"] +"\r\n\r\n";
                DataRow[] drOffers = drProperty.GetChildRows(DC.dtProperty.ChildRelations["PROPERTY_OFFER"]);
                if (drOffers.Length != 0)
                {
                    foreach (DataRow drOffer in drOffers)
                    {
                        offerCount += 1;
                    }
                    propertyText += "Number of offers made on the property: " + offerCount;
                }
                else
                {
                    propertyText += "This property has not received any offer yet.";
                }
                propertyText += "\r\n\r\n----------------------------------------------------\r\n\r\n";
                txtProperties.Text += propertyText;
                offerCount = 0;
                propertyText = "";
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            txtProperties.Text = "";
        }
    }
}
