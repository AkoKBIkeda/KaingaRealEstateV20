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
    public partial class AgentReportForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        private int buyerCount;
        private DataRow[] agentsForPrint;
        public AgentReportForm(DataController dc, AssistantAdministratorMainForm mnu)
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
            txtAgents.Text = "";
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string strFilter = null;
            string strSort = "lastName, firstName";
            agentsForPrint = DC.dsKainga.Tables["AGENT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            txtAgents.Text = "";
            string agentText = "";
            foreach (DataRow drAgent in agentsForPrint)
            {
                agentText += "Agent ID: " + drAgent["agentID"] + "\r\tName: " + drAgent["firstName"] + " " + drAgent["lastName"];
                agentText += "\r\nAddress: " + drAgent["streetAddress"] + ", " + drAgent["suburb"];
                agentText += "\r\nPhone Number: " + drAgent["phoneNumber"] + "\r\t\r\tEmail Address: " + drAgent["emailAddress"];
                double amount = Convert.ToDouble(drAgent["salary"]);
                string aSalary = $"{amount:C2}";
                agentText += "\r\nCertification: " + drAgent["certification"] + "\r\t\r\tSalary: " + aSalary+"\r\n\r\n";
                DataRow[] drBuyers = drAgent.GetChildRows(DC.dtAgent.ChildRelations["AGENT_BUYER"]);
                if (drBuyers.Length != 0)
                {
                    foreach (DataRow drBuyer in drBuyers)
                    {
                        buyerCount++;
                    }
                    agentText += "Number of buyers assigned: " + buyerCount;
                }
                else
                {
                    agentText += "No buyers have been assigned to this agent currently.";
                }
                agentText += "\r\n\r\n----------------------------------------------------\r\n\r\n";
                txtAgents.Text += agentText;
                buyerCount = 0;
                agentText = "";
            }
        }
    }
}
