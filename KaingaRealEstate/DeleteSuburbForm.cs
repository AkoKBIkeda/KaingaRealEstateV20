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
    public partial class DeleteSuburbForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        int aSuburbID;
        private CurrencyManager cmSuburb;
        public DeleteSuburbForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmSuburb = (CurrencyManager)this.BindingContext[DC.dsKainga, "SUBURB"];
        }
        private void LoadSuburbs()
        {
            foreach (DataRow drSuburb in DC.dtSuburb.Rows)
            {
                DataRow[] drProperties = drSuburb.GetChildRows(DC.dtSuburb.ChildRelations["SUBURB_PROPERTY"]); 
                if (drProperties.Length == 0) // changed from "!=0" to "== 0"
                {
                    DataRow[] drBuyers = drSuburb.GetChildRows(DC.dtSuburb.ChildRelations["SUBURB_BUYERSUBURB"]); //changed to "SUBURB_BUYERSUBURB"
                    if (drBuyers.Length == 0) // changed from "!=0" to "== 0"
                    {
                        cboSuburb.Items.Add(drSuburb["suburbID"] + (" ") + drSuburb["suburbName"]);
                    }
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void DeleteSuburbForm_Load(object sender, EventArgs e)
        {
            LoadSuburbs();
        }

        private void ClearFields()
        {
            txtSuburbID.Text = "";
            txtSuburbName.Text = "";
            txtPostcode.Text = "";
            cboSuburb.Text = "";
            cboSuburb.Items.Clear();
        }
        private void cboSuburb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboSuburb.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aSuburbID = Convert.ToInt32(subs[0]);
            cmSuburb.Position = DC.suburbView.Find(aSuburbID);
            DataRow drSuburb = DC.dtSuburb.Rows[cmSuburb.Position];
            txtSuburbID.Text = drSuburb["suburbID"].ToString();
            txtSuburbName.Text = drSuburb["suburbName"].ToString();
            txtPostcode.Text = drSuburb["postcode"].ToString();
        }
        private void btnDeleteSuburb_Click(object sender, EventArgs e)
        {
            if (cboSuburb.Text == "") //added this if statement. the button won't work if there is nothing to remove.
            {
                return;
            }
            else
            {
                DataRow deleteSuburbRow = DC.dtSuburb.Rows[cmSuburb.Position];
                if (MessageBox.Show("Are you sure to delete this suburb?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteSuburbRow.Delete();
                    DC.UpdateSuburb();
                    MessageBox.Show("Suburb deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadSuburbs();
                }
            }
        }
    }
}


