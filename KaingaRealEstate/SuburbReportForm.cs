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
    public partial class SuburbReportForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        private int buyerCount, propertyCount;
        private DataRow[] suburbsForPrint;
        public SuburbReportForm(DataController dc, ITClerkMainForm mnu)
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
            txtSuburbs.Text = "";
        }
        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string strFilter = null;
            string strSort = "suburbName";
            suburbsForPrint = DC.dsKainga.Tables["SUBURB"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            txtSuburbs.Text = "";
            string suburbText = "";
            foreach (DataRow drSuburb in suburbsForPrint) 
            {
                suburbText += "Suburb ID: " + drSuburb["suburbID"] + "\r\tSuburb Name: " + drSuburb["suburbName"] + "\r\tPostcode: " + drSuburb["postcode"] + "\r\n\r\n";
                DataRow[] drBuyers = drSuburb.GetChildRows(DC.dtSuburb.ChildRelations["SUBURB_BUYERSUBURB"]);
                if (drBuyers.Length != 0)
                {
                    foreach (DataRow drBuyer in drBuyers)
                    {
                        buyerCount++;
                    }
                    suburbText += "Number of buyers assosiated with the suburb: " + buyerCount;
                }
                else
                {
                    suburbText += "This suburb is currently not assosiated with any buyers.";
                }
                suburbText += "\r\n";
                DataRow[] drProperties = drSuburb.GetChildRows(DC.dtSuburb.ChildRelations["SUBURB_PROPERTY"]);
                if (drProperties.Length != 0)
                {
                    foreach (DataRow drProperty in drProperties)
                    {
                        propertyCount++;
                    }
                    suburbText += "Number of properties assosiated with the suburb: " + propertyCount;
                }
                else
                {
                    suburbText += "This suburb is currently not assosiated with any properties.";
                }
                suburbText += "\r\n\r\n----------------------------------------------------\r\n\r\n";
                txtSuburbs.Text += suburbText;
                propertyCount = buyerCount = 0;
                suburbText = "";
            }
        }
    }
}
