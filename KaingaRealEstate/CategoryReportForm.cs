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
    public partial class CategoryReportForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        private int buyerCount, propertyCount;
        private DataRow[] categoriesForPrint;
        public CategoryReportForm(DataController dc, ITClerkMainForm mnu)
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
            txtCategories.Text = "";
        }
        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string strFilter = null;
            string strSort = "categoryDescription";
            categoriesForPrint = DC.dsKainga.Tables["CATEGORY"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            txtCategories.Text = "";
            string categoryText = "";
            foreach (DataRow drCategory in categoriesForPrint)
            {
                categoryText += "Category ID: " + drCategory["categoryID"] + "\r\tLevel: " + drCategory["level"] 
                            + "\r\nCategory Description: " + drCategory["categoryDescription"] +"\r\n\r\n";
                DataRow[] drBuyers = drCategory.GetChildRows(DC.dtCategory.ChildRelations["CATEGORY_BUYERCATEGORY"]);
                if (drBuyers.Length != 0)
                {
                    foreach (DataRow drBuyer in drBuyers)
                    {
                        buyerCount++;
                    }
                    categoryText += "Number of buyers assosiated with the category: " + buyerCount;
                }
                else
                {
                    categoryText += "This category is currently not assosiated with any buyers.";
                }
                categoryText += "\r\n";
                DataRow[] drProperties = drCategory.GetChildRows(DC.dtCategory.ChildRelations["CATEGORY_PROPERTY"]);
                if (drProperties.Length != 0)
                {
                    foreach (DataRow drProperty in drProperties)
                    {
                        propertyCount++;
                    }
                    categoryText += "Number of properties assosiated with the category: " + propertyCount;
                }
                else
                {
                    categoryText += "This category is currently not assosiated with any properties.";
                }
                categoryText += "\r\n\r\n----------------------------------------------------\r\n\r\n";
                txtCategories.Text += categoryText;
                propertyCount = buyerCount = 0;
                categoryText = "";
            }
        }
    }
}
