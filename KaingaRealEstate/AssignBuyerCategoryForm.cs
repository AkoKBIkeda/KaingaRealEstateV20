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
    public partial class AssignBuyerCategoryForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        int aCategoryID, aBuyerID;
        private CurrencyManager cmBuyer;
        public AssignBuyerCategoryForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
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
            //added 5x below
            cboCategory.Text = ""; 
            cboCategory.Items.Clear();
            cboImportance.Text = "";
            cboImportance.SelectedIndex = -1;
            lstCategoryAssign.Items.Clear();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }

        private void AssignBuyerCategoryForm_Load(object sender, EventArgs e)
        {
            LoadBuyers();
            LoadCategories(); // moved from "private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)"
        }
        private void LoadBuyers()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                cboBuyer.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
            }
        }

        private void LoadCategories()
        {
            foreach (DataRow drCategory in DC.dtCategory.Rows)
            {
                cboCategory.Items.Add(drCategory["categoryID"] + (": ") + drCategory["categoryDescription"]);
            }
        }
        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCategoryAssign.Items.Clear();  // added
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
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboCategory.SelectedItem.ToString();
            string[] subs = aRow.Split(':');
            aCategoryID = Convert.ToInt32(subs[0]);
        }
        private void btnAssignBuyerCategory_Click(object sender, EventArgs e)
        {
            if ((cboImportance.Text == "") || (cboBuyer.Text == "") || (cboCategory.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataRow newBuyerCategory = DC.dtBuyerCategory.NewRow();
                    newBuyerCategory["buyerID"] = aBuyerID;
                    newBuyerCategory["categoryID"] = aCategoryID;
                    newBuyerCategory["importance"] = cboImportance.Text;
                    DC.dtBuyerCategory.Rows.Add(newBuyerCategory);
                    DC.UpdateBuyerCategory();
                    MessageBox.Show("Category assigned to the buyer sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //added 3x below
                    ClearFields(); 
                    LoadBuyers();
                    LoadCategories();
                }
                catch
                {
                    MessageBox.Show("The category is already assigned to the buyer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadCategoriesAssigned()
        {
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            DataRow[] drBuyerCategories = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERCATEGORY"]);
            var space = new string(' ', 31);
            lstCategoryAssign.Items.Add("ID\r\tDescription" + space + "Importance\r\n");
            if (drBuyerCategories.Length == 0)
            {
                lstCategoryAssign.Items.Add("No category has assigned to this buyer yet.");
            }
            else
            {
                foreach (DataRow drBuyerCategory in drBuyerCategories)
                {
                    DataRow drCategory = drBuyerCategory.GetParentRow(DC.dtBuyerCategory.ParentRelations["CATEGORY_BUYERCATEGORY"]);
                    string aDescription = drCategory["categoryDescription"].ToString();
                    space = new String(' ', (42 - aDescription.Length));
                    lstCategoryAssign.Items.Add(drCategory["categoryID"] + "\r\t" + aDescription + space + drBuyerCategory["importance"] + "\r\n");
                }
            }
        }
    }
}

