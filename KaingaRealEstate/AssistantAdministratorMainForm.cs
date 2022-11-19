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
    public partial class AssistantAdministratorMainForm : Form
    {
        // Add references to the DataController and the forms.
        private DataController DC;
        private LoginForm frmMenu;
        private AddSellerForm frmAddSeller;
        private UpdateSellerForm frmUpdateSeller;
        private DeleteSellerForm frmDeleteSeller;
        private SellerReportForm frmSellerReport;
        private AddAgentForm frmAddAgent;
        private UpdateAgentForm frmUpdateAgent;
        private DeleteAgentForm frmDeleteAgent;
        private AgentReportForm frmAgentReport;
        public AssistantAdministratorMainForm(LoginForm mnu)
        {
            InitializeComponent();
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnSellersReport_Click(object sender, EventArgs e)
        {
            if (frmSellerReport == null)
            {
                frmSellerReport = new SellerReportForm(DC, this);
            }
            frmSellerReport.ShowDialog();
        }

        private void AssistantAdministratorMainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); // create the data controller and load the dataset.
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            if (frmAddSeller == null)
            {
                frmAddSeller = new AddSellerForm(DC, this);
            }
            frmAddSeller.ShowDialog();
        }

        private void btnUpdateSeller_Click(object sender, EventArgs e)
        {
            if (frmUpdateSeller == null)
            {
                frmUpdateSeller = new UpdateSellerForm(DC, this);
            }
            frmUpdateSeller.ShowDialog();
        }

        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            if (frmDeleteSeller == null)
            {
                frmDeleteSeller = new DeleteSellerForm(DC, this);
            }
            frmDeleteSeller.ShowDialog();
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            if (frmAddAgent == null)
            {
                frmAddAgent = new AddAgentForm(DC, this);
            }
            frmAddAgent.ShowDialog();
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            if (frmUpdateAgent == null)
            {
                frmUpdateAgent = new UpdateAgentForm(DC, this);
            }
            frmUpdateAgent.ShowDialog();
        }

        private void btnDeleteAgent_Click(object sender, EventArgs e)
        {
            if (frmDeleteAgent == null)
            {
                frmDeleteAgent = new DeleteAgentForm(DC, this);
            }
            frmDeleteAgent.ShowDialog();
        }

        private void btnAgentsReport_Click(object sender, EventArgs e)
        {
            if (frmAgentReport == null)
            {
                frmAgentReport = new AgentReportForm(DC, this);
            }
            frmAgentReport.ShowDialog();
        }
    }
}
