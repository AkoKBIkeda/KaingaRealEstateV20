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
    public partial class RemoveBuyerCategoryForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aBuyerID, aCategoryID;
        private CurrencyManager cmBuyer;
        public RemoveBuyerCategoryForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "BUYER"];
        }
        private void ClearFields()
        {
            txtBuyerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtCreditStatus.Text = "";
            cboBuyer.Text = "";
            cboBuyer.Items.Clear();
            lstCategoriesAssigned.Items.Clear();
        }
        private void LoadBuyers()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                DataRow[] drBuyerCategories = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERCATEGORY"]);
                if (drBuyerCategories.Length != 0)
                {
                    cboBuyer.Items.Add(drBuyer["buyerID"]+(" ")+drBuyer["lastName"]+(" ")+drBuyer["firstName"]);
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void RemoveBuyerCategoryForm_Load(object sender, EventArgs e)
        {
            LoadBuyers();
        }
        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCategoriesAssigned.Items.Clear();
            string aRow = cboBuyer.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aBuyerID = Convert.ToInt32(subs[0]);
            cmBuyer.Position = DC.buyerView.Find(aBuyerID);
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            txtBuyerID.Text = drBuyer["buyerID"].ToString();
            txtLastName.Text = drBuyer["lastName"].ToString();
            txtFirstName.Text = drBuyer["firstName"].ToString();
            txtCreditStatus.Text = drBuyer["creditStatus"].ToString();
            LoadCategoriesAssigned();
        }
        private void LoadCategoriesAssigned()
        {
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            DataRow[] drBuyerCategories = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERCATEGORY"]);
            var space = new string(' ', 31);
            lstCategoriesAssigned.Items.Add("ID\r\tDescription"+space+"Importance\r\n");
            foreach (DataRow drBuyerCategory in drBuyerCategories)
            {
                DataRow drCategory = drBuyerCategory.GetParentRow(DC.dtBuyerCategory.ParentRelations["CATEGORY_BUYERCATEGORY"]);
                string aDescription = drCategory["categoryDescription"].ToString();
                space = new String(' ', (42 - aDescription.Length));
                lstCategoriesAssigned.Items.Add(drCategory["categoryID"] + "\r\t" + aDescription + space + drBuyerCategory["importance"] +"\r\n");
            }
        }
        private void lstCategoriesAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategoriesAssigned.SelectedItem == null)
            {
                lstCategoriesAssigned.SelectedIndex = 0;
            }
            if (lstCategoriesAssigned.SelectedIndex == 0) // nothing happens when the label/white space is selected
            {
            }
            else
            {
                string aRow = lstCategoriesAssigned.SelectedItem.ToString();
                string[] subs = aRow.Split('\t');
                aCategoryID = Convert.ToInt32(subs[0]);
            }
        }
        private void btnRemoveBuyerCategory_Click(object sender, EventArgs e)
        {
            // this handles empty cboBuyer too as the lstCategoriesAssigned won't be loaded when the cboBuyer is empty.
            if ((lstCategoriesAssigned.SelectedIndex == 0) || (lstCategoriesAssigned.SelectedItem == null))
            {
                {
                    MessageBox.Show("Please select an option properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                object[] keys = new object[2];   // Create an array for the key values to find.
                keys[0] = aBuyerID; // Set the values of the keys to find.
                keys[1] = aCategoryID; // Set the values of the keys to find.
                DataRow removeCategoryRow = DC.dtBuyerCategory.Rows.Find(keys);

                if (MessageBox.Show("Are you sure to delete this category?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    removeCategoryRow.Delete();
                    DC.UpdateBuyerCategory();
                    MessageBox.Show("Category removed from buyer successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadBuyers();
                }
            }
        }
    }
}
