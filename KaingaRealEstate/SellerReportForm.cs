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
    public partial class SellerReportForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        private int propertyCount;
        private DataRow[] sellersForPrint;
        public SellerReportForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string strFilter = null;
            string strSort = "lastName, firstName"; //https://social.msdn.microsoft.com/Forums/en-US/3b02e870-ca20-4630-8968-7e11c0f68d92/c-datatable-sorting?forum=aspwebforms
            sellersForPrint = DC.dsKainga.Tables["SELLER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            txtSellers.Text = "";
            string sellerText = "";
            foreach (DataRow drSeller in sellersForPrint)
            {
                sellerText += "Seller ID: " + drSeller["sellerID"] + "\r\tName: " + drSeller["firstName"] + " " + drSeller["lastName"]
                            + "\r\nAddress: " + drSeller["streetAddress"] + ", " + drSeller["suburb"] + ", " + drSeller["city"]
                            + "\r\nPhone Number: " + drSeller["phoneNumber"] + "\r\t\r\tEmail Address: " + drSeller["emailAddress"]
                            + "\r\nStatus: " + drSeller["status"] + "\r\n\r\n";
                DataRow[] drProperties = drSeller.GetChildRows(DC.dtSeller.ChildRelations["SELLER_PROPERTY"]);
                if (drProperties.Length != 0)
                {
                    foreach (DataRow drProperty in drProperties)
                    {
                        string status = drProperty["status"].ToString();
                        if (status == "Available")
                        {
                            propertyCount++;
                        }
                    }
                    sellerText += "Number of available properties: " + propertyCount;
                }
                else
                {
                    sellerText += "This seller does not have any available properties currently.";
                }
                sellerText += "\r\n\r\n----------------------------------------------------\r\n\r\n";
                txtSellers.Text += sellerText;
                propertyCount = 0;
                sellerText = "";
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            txtSellers.Text = "";
        }
    }
}
