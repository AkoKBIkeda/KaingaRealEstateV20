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
    public partial class DeleteAgentForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        private int aAgentID;
        private CurrencyManager cmAgent;
        public DeleteAgentForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmAgent = (CurrencyManager)this.BindingContext[DC.dsKainga, "AGENT"];
        }
        private void LoadAgents()
        {
            foreach (DataRow drAgent in DC.dtAgent.Rows)
            {
                DataRow[] drBuyers = drAgent.GetChildRows(DC.dtAgent.ChildRelations["AGENT_BUYER"]);
                if (drBuyers.Length == 0) // changed from "!=0" to "== 0"
                {
                    cboAgent.Items.Add(drAgent["agentID"] + (" ") + drAgent["lastName"] + (" ") + drAgent["firstName"]);
                }
            }
        }
        private void DeleteAgentForm_Load(object sender, EventArgs e)
        {
            LoadAgents();
        }
        private void ClearFields()
        {
            txtAgentID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCertification.Text = "";
            cboAgent.Text = "";
            cboAgent.Items.Clear();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
        private void cboAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboAgent.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aAgentID = Convert.ToInt32(subs[0]);
            cmAgent.Position = DC.agentView.Find(aAgentID);
            DataRow drAgent = DC.dtAgent.Rows[cmAgent.Position];
            txtAgentID.Text = drAgent["agentID"].ToString();
            txtLastName.Text = drAgent["lastName"].ToString();
            txtFirstName.Text = drAgent["firstName"].ToString();
            txtStreetAddress.Text = drAgent["streetAddress"].ToString();
            txtSuburb.Text = drAgent["suburb"].ToString();
            txtCertification.Text = drAgent["certification"].ToString();
        }
        private void btnDeleteAgent_Click(object sender, EventArgs e)
        {
            if (cboAgent.Text == "") //added this if statement. the button won't work if there is nobody to remove.
            {
                return;
            }
            else
            {
                DataRow deleteAgentRow = DC.dtAgent.Rows[cmAgent.Position];
                if (MessageBox.Show("Are you sure to delete this agent?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteAgentRow.Delete();
                    DC.UpdateAgent();
                    MessageBox.Show("Agent deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadAgents();
                }
            }
        }
    }
}

