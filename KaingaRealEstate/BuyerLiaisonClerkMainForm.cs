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
    public partial class BuyerLiaisonClerkMainForm : Form
    {        
        // Add references to the DataController and the forms.
        private DataController DC;
        private LoginForm frmMenu;
        private AddBuyerForm frmAddBuyer;
        private UpdateBuyerForm frmUpdateBuyer;
        private DeleteBuyerForm frmDeleteBuyer;
        private BuyerReportForm frmBuyerReport;
        private AssignBuyerSuburbForm frmAssignBuyerSuburb;
        private RemoveBuyerSuburbForm frmRemoveBuyerSuburb;
        private AssignBuyerCategoryForm frmAssignBuyerCategory;
        private RemoveBuyerCategoryForm frmRemoveBuyerCategory;
        private AddOfferForm frmAddOffer;
        private RemoveOfferForm frmRemoveOffer;
        private OfferReportForm frmOfferReport;
        public BuyerLiaisonClerkMainForm(LoginForm mnu)
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
        // Do we need this here? or on Login form only??
        private void BuyerLiaisonClerkMainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); // create the data controller and load the dataset.
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            if (frmAddBuyer == null)
            {
                frmAddBuyer = new AddBuyerForm(DC, this);
            }
            frmAddBuyer.ShowDialog();
        }

        private void btnUpdateBuyer_Click(object sender, EventArgs e)
        {
            if (frmUpdateBuyer == null)
            {
                frmUpdateBuyer = new UpdateBuyerForm(DC, this);
            }
            frmUpdateBuyer.ShowDialog();
        }

        private void btnDeleteBuyer_Click(object sender, EventArgs e)
        {
            if (frmDeleteBuyer == null)
            {
                frmDeleteBuyer = new DeleteBuyerForm(DC, this);
            }
            frmDeleteBuyer.ShowDialog();
        }

        private void btnBuyersReport_Click(object sender, EventArgs e)
        {
            if (frmBuyerReport == null)
            {
                frmBuyerReport = new BuyerReportForm(DC, this);
            }
            frmBuyerReport.ShowDialog();
        }

        private void btnAssignBuyerSuburb_Click(object sender, EventArgs e)
        {
            if (frmAssignBuyerSuburb == null)
            {
                frmAssignBuyerSuburb = new AssignBuyerSuburbForm(DC, this);
            }
            frmAssignBuyerSuburb.ShowDialog();
        }

        private void btnRemoveBuyerSuburb_Click(object sender, EventArgs e)
        {
            if (frmRemoveBuyerSuburb == null)
            {
                frmRemoveBuyerSuburb = new RemoveBuyerSuburbForm(DC, this);
            }
            frmRemoveBuyerSuburb.ShowDialog();
        }

        private void btnAssignBuyerCategory_Click(object sender, EventArgs e)
        {
            if (frmAssignBuyerCategory == null)
            {
                frmAssignBuyerCategory = new AssignBuyerCategoryForm(DC, this);
            }
            frmAssignBuyerCategory.ShowDialog();
        }

        private void btnRemoveBuyerCategory_Click(object sender, EventArgs e)
        {
            if (frmRemoveBuyerCategory == null)
            {
                frmRemoveBuyerCategory = new RemoveBuyerCategoryForm(DC, this);
            }
            frmRemoveBuyerCategory.ShowDialog();
        }

        private void btnAddOffer_Click(object sender, EventArgs e)
        {
            if (frmAddOffer == null)
            {
                frmAddOffer = new AddOfferForm(DC, this);
            }
            frmAddOffer.ShowDialog();
        }

        private void btnRemoveOffer_Click(object sender, EventArgs e)
        {
            if (frmRemoveOffer == null)
            {
                frmRemoveOffer = new RemoveOfferForm(DC, this);
            }
            frmRemoveOffer.ShowDialog();
        }

        private void btnOffersReport_Click(object sender, EventArgs e)
        {
            if (frmOfferReport == null)
            {
                frmOfferReport = new OfferReportForm(DC, this);
            }
            frmOfferReport.ShowDialog();
        }
    }
}
