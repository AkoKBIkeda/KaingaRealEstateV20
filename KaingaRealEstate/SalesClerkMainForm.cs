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
    public partial class SalesClerkMainForm : Form
    {
        // Add references to the DataController and the forms.
        private DataController DC;
        private LoginForm frmMenu;
        private AddPropertyForm frmAddProperty;
        private UpdatePropertyForm frmUpdateProperty;
        private SellPropertyForm frmSellProperty;
        private DeletePropertyForm frmDeleteProperty;
        private PropertyReportForm frmPropertyReport;
        public SalesClerkMainForm(LoginForm mnu)
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

        private void SalesClerkMainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); // create the data controller and load the dataset.
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (frmAddProperty == null)
            {
                frmAddProperty = new AddPropertyForm(DC, this);
            }
            frmAddProperty.ShowDialog();
        }

        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {
            if (frmUpdateProperty == null)
            {
                frmUpdateProperty = new UpdatePropertyForm(DC, this);
            }
            frmUpdateProperty.ShowDialog();
        }

        private void btnSellProperty_Click(object sender, EventArgs e)
        {
            if (frmSellProperty == null)
            {
                frmSellProperty = new SellPropertyForm(DC, this);
            }
            frmSellProperty.ShowDialog();
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            if (frmDeleteProperty == null)
            {
                frmDeleteProperty = new DeletePropertyForm(DC, this);
            }
            frmDeleteProperty.ShowDialog();
        }

        private void btnPropertiesReport_Click(object sender, EventArgs e)
        {
            if (frmPropertyReport == null)
            {
                frmPropertyReport = new PropertyReportForm(DC, this);
            }
            frmPropertyReport.ShowDialog();
        }
    }
}
