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
    public partial class DeleteBuyerForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aBuyerID;
        private CurrencyManager cmBuyer;
        public DeleteBuyerForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "BUYER"];
        }
        private void LoadBuyers()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                DataRow[] drOffers = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_OFFER"]); //changed from OFFER_BUYER to BUYER_OFFER
                if (drOffers.Length == 0) // changed from "!=0" to "== 0"
                {
                    cboBuyer.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
                }
            }
        }

        private void DeleteBuyerForm_Load(object sender, EventArgs e)
        {
            LoadBuyers();
        }

        private void ClearFields()
        {
            txtBuyerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtCreditStatus.Text = "";
            cboBuyer.Text = "";
            cboBuyer.Items.Clear();
        }
        private void btnDeleteBuyer_Click(object sender, EventArgs e)
        {
            if (cboBuyer.Text == "") //added this if statement. the button won't work if there is nobody to remove.
            {
                return;
            }
            else
            {
                DataRow deleteBuyerRow = DC.dtBuyer.Rows[cmBuyer.Position];
                if (MessageBox.Show("Are you sure to delete this buyer?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // added 12x below lines
                    DataRow[] drBuyerSuburbs = deleteBuyerRow.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERSUBURB"]);
                    foreach (DataRow drBuyerSuburb in drBuyerSuburbs)
                    {
                        drBuyerSuburb.Delete();
                        DC.UpdateBuyerSuburb();
                    }
                    DataRow[] drBuyerCategories = deleteBuyerRow.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERCATEGORY"]);
                    foreach (DataRow drBuyerCategory in drBuyerCategories)
                    {
                        drBuyerCategory.Delete();
                        DC.UpdateBuyerCategory();
                    }

                    deleteBuyerRow.Delete();
                    DC.UpdateBuyer();  // changed from UpdateSeller() to UpdateBuyer()
                    MessageBox.Show("Buyer deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadBuyers();
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }

        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboBuyer.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aBuyerID = Convert.ToInt32(subs[0]);
            cmBuyer.Position = DC.buyerView.Find(aBuyerID);
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            txtBuyerID.Text = drBuyer["buyerID"].ToString();
            txtLastName.Text = drBuyer["lastName"].ToString();
            txtFirstName.Text = drBuyer["firstName"].ToString();
            txtStreetAddress.Text = drBuyer["streetAddress"].ToString();
            txtSuburb.Text = drBuyer["suburb"].ToString();
            txtCreditStatus.Text = drBuyer["creditStatus"].ToString();
            txtCity.Text = drBuyer["city"].ToString();
        }
    }
}