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
    public partial class RemoveBuyerSuburbForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aBuyerID, aSuburbID;
        private CurrencyManager cmBuyer;
        public RemoveBuyerSuburbForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
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
            lstSuburbsAssigned.Items.Clear();
        }
        private void LoadBuyers()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                DataRow[] drBuyerSuburbs = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERSUBURB"]);
                if (drBuyerSuburbs.Length != 0)
                {
                    cboBuyer.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }

        private void RemoveBuyerSuburbForm_Load(object sender, EventArgs e)
        {
            LoadBuyers();
        }

        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buyer;

            if (cboBuyer.SelectedItem != null)
            {
                lstSuburbsAssigned.Items.Clear();
                // get the selected buyer in the cboBuyer combobox
                buyer = cboBuyer.SelectedItem.ToString();
                // split the string from cboBuyer
                string[] parts = buyer.Split(' ');
                // extract buyerID
                aBuyerID = Convert.ToInt32(parts[0]);
                // Get the position of the selected buyer and assigns it to the Position property of cmBuyer
                cmBuyer.Position = DC.buyerView.Find(aBuyerID);
                // Get the datarow for the selected buyer
                DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
                // Populate buyer textboxes
                txtBuyerID.Text = drBuyer["buyerID"].ToString();
                txtLastName.Text = drBuyer["lastName"].ToString();
                txtFirstName.Text = drBuyer["firstName"].ToString();
                txtCreditStatus.Text = drBuyer["creditStatus"].ToString();
                // load suburbs
                LoadSuburbs();
            }
        }
        private void LoadSuburbs()
        {
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            DataRow[] drBuyerSuburbs = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERSUBURB"]);
            var space = new string(' ', 21);

            lstSuburbsAssigned.Items.Add("ID\r\tName" + space + "Importance\r\n");
            foreach (DataRow drBuyerSuburb in drBuyerSuburbs)
            {
                DataRow drSuburb = drBuyerSuburb.GetParentRow(DC.dtBuyerSuburb.ParentRelations["SUBURB_BUYERSUBURB"]);
                string aName = drSuburb["suburbName"].ToString();
                space = new String(' ', (32 - aName.Length));
                lstSuburbsAssigned.Items.Add(drSuburb["suburbID"] + "\r\t" + aName + space + drBuyerSuburb["importance"] + "\r\n");
            }
        }
        private void lstSuburbsAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuburbsAssigned.SelectedItem == null)
            {
                lstSuburbsAssigned.SelectedIndex = 0;
            }
            if (lstSuburbsAssigned.SelectedIndex == 0)
            {
                // nothing happens
            }
            else
            {
                string suburb = lstSuburbsAssigned.SelectedItem.ToString();
                string[] parts = suburb.Split('\t');
                aSuburbID = Convert.ToInt32(parts[0]);
            }
        }
        private void btnRemoveBuyerSuburb_Click(object sender, EventArgs e)
        {
            // handle if the suburb or buyer is not selected
            if ((lstSuburbsAssigned.SelectedIndex == 0) || (lstSuburbsAssigned.SelectedItem == null)) 
            {
                MessageBox.Show("Please select a buyer and a suburb to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                object[] keys = new object[2];   // Create an array for the key values to find. 
                keys[0] = aBuyerID; // Set the values of the keys to find. 
                keys[1] = aSuburbID; // Set the values of the keys to find. 
                DataRow removeSuburbRow = DC.dtBuyerSuburb.Rows.Find(keys);

                if (MessageBox.Show("Are you sure you want to delete this suburb?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    removeSuburbRow.Delete();
                    DC.UpdateBuyerSuburb();
                    MessageBox.Show("Suburb removed from buyer successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadBuyers();
                }
            }
        }
    }
}