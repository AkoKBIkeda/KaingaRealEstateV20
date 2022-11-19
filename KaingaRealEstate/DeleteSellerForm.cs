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
    public partial class DeleteSellerForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        private int aSellerID;
        private CurrencyManager cmSeller;
        public DeleteSellerForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmSeller = (CurrencyManager)this.BindingContext[DC.dsKainga, "SELLER"];
        }
        private void LoadSellers()
        {
            foreach (DataRow drSeller in DC.dtSeller.Rows)
            {
                DataRow[] drProperties = drSeller.GetChildRows(DC.dtSeller.ChildRelations["SELLER_PROPERTY"]);
                if (drProperties.Length == 0) // changed from "!=0" to "== 0"
                {
                    cboSeller.Items.Add(drSeller["sellerID"] + (" ") + drSeller["lastName"] + (" ") + drSeller["firstName"]);
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void cboSeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboSeller.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aSellerID = Convert.ToInt32(subs[0]);
            cmSeller.Position = DC.sellerView.Find(aSellerID);
            DataRow drSeller = DC.dtSeller.Rows[cmSeller.Position];
            txtSellerID.Text = drSeller["sellerID"].ToString();
            txtLastName.Text = drSeller["lastName"].ToString();
            txtFirstName.Text = drSeller["firstName"].ToString();
            txtStatus.Text = drSeller["status"].ToString();
            txtEmailAddress.Text = drSeller["emailAddress"].ToString();
        }
        private void DeleteSellerForm_Load(object sender, EventArgs e)
        {
            LoadSellers();
        }
        private void ClearFields()
        {
            txtSellerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStatus.Text = "";
            txtEmailAddress.Text = "";
            cboSeller.Text = "";
            cboSeller.Items.Clear();
        }
        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            if (cboSeller.Text == "") //added this if statement. the button won't work if there is nobody to remove.
            {
                return;
            }
            else
            {
                DataRow deleteSellerRow = DC.dtSeller.Rows[cmSeller.Position];
                if (MessageBox.Show("Are you sure to delete this seller?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteSellerRow.Delete();
                    DC.UpdateSeller();
                    MessageBox.Show("Seller deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadSellers();
                }
            }
        }
    }
}

