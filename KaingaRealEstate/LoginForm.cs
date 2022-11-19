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
    public partial class LoginForm : Form
    {
        private AssistantAdministratorMainForm frmAssistantAdministratorMain; // reference to the Assistant Administrator's Main Menu
        private BuyerLiaisonClerkMainForm frmBuyerLiaisonClerkMain; // reference to the Buyer Liaison Clerk's Main Menu
        private ITClerkMainForm frmITClerkMain; // reference to the IT Clerk's Main Menu
        private SalesClerkMainForm frmSalesClerkMain; // reference to the Sales Clerk's Main Menu
        private int failedLogin = 0; // set a counter to count failed logins
        public LoginForm()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            chkShow.Checked = false;
            txtPassword.UseSystemPasswordChar = false; // To hide password entry when coming back after login showing password
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (((txtUsername.Text == "assistant1") & (txtPassword.Text == "PWAA1")) | ((txtUsername.Text == "assistant2") & (txtPassword.Text == "PWAA2"))
                //| ((txtUsername.Text == "") & (txtPassword.Text == ""))
                )
            {
                failedLogin = 0;
                if (frmAssistantAdministratorMain == null)
                {
                    frmAssistantAdministratorMain = new AssistantAdministratorMainForm(this);
                }
                frmAssistantAdministratorMain.ShowDialog();
                ClearFields(); // login details will not be remain when coming back from users's forms.
                return; // without this  "return;", error message appears when coming back from users' forms.
            }
            if (((txtUsername.Text == "buyerLC1") & (txtPassword.Text == "PWBLC1")) | ((txtUsername.Text == "buyerLC2") & (txtPassword.Text == "PWBLC2")))
            {
                failedLogin = 0;
                if (frmBuyerLiaisonClerkMain == null)
                {
                    frmBuyerLiaisonClerkMain = new BuyerLiaisonClerkMainForm(this);
                }
                frmBuyerLiaisonClerkMain.ShowDialog();
                ClearFields();
                return;
            }
            if (((txtUsername.Text == "sales1") & (txtPassword.Text == "PWSC1")) | ((txtUsername.Text == "sales2") & (txtPassword.Text == "PWSC2")) | ((txtUsername.Text == "sales3") & (txtPassword.Text == "PWSC3")))
            {
                failedLogin = 0;
                if (frmSalesClerkMain == null)
                {
                    frmSalesClerkMain = new SalesClerkMainForm(this);
                }
                frmSalesClerkMain.ShowDialog();
                ClearFields();
                return;
            }
            if ((txtUsername.Text == "itclerk1") & (txtPassword.Text == "PWITC1"))
            {
                failedLogin = 0;
                if (frmITClerkMain == null)
                {
                    frmITClerkMain = new ITClerkMainForm(this);
                }
                frmITClerkMain.ShowDialog();
                ClearFields();
                return;
            }
            else
            {
                if (failedLogin >= 2)
                {
                    MessageBox.Show("You have failed to login three times.\nThe system will shut down.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else
                {
                    MessageBox.Show("Username and/or Password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                    failedLogin += 1;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked) //https://www.youtube.com/watch?v=Sx8K2KDL5uA
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
