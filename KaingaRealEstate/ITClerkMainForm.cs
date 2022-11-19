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
    public partial class ITClerkMainForm : Form
    {
        // Add references to the DataController and the forms.
        private DataController DC;
        private LoginForm frmMenu;
        private AddSuburbForm frmAddSuburb;
        private UpdateSuburbForm frmUpdateSuburb;
        private DeleteSuburbForm frmDeleteSuburb;
        private SuburbReportForm frmSuburbReport;
        private AddCategoryForm frmAddCategory;
        private UpdateCategoryForm frmUpdateCategory;
        private DeleteCategoryForm frmDeleteCategory;
        private CategoryReportForm frmCategoryReport;
        public ITClerkMainForm(LoginForm mnu)
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

        private void ITClerkMainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); // create the data controller and load the dataset.
        }

        private void btnAddSuburb_Click(object sender, EventArgs e)
        {
            if (frmAddSuburb == null)
            {
                frmAddSuburb = new AddSuburbForm(DC, this);
            }
            frmAddSuburb.ShowDialog();
        }

        private void btnUpdateSuburb_Click(object sender, EventArgs e)
        {
            if (frmUpdateSuburb == null)
            {
                frmUpdateSuburb = new UpdateSuburbForm(DC, this);
            }
            frmUpdateSuburb.ShowDialog();
        }

        private void btnDeleteSuburb_Click(object sender, EventArgs e)
        {
            if (frmDeleteSuburb == null)
            {
                frmDeleteSuburb = new DeleteSuburbForm(DC, this);
            }
            frmDeleteSuburb.ShowDialog();
        }

        private void btnSuburbsReport_Click(object sender, EventArgs e)
        {
            if (frmSuburbReport == null)
            {
                frmSuburbReport = new SuburbReportForm(DC, this);
            }
            frmSuburbReport.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (frmAddCategory == null)
            {
                frmAddCategory = new AddCategoryForm(DC, this);
            }
            frmAddCategory.ShowDialog();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (frmUpdateCategory == null)
            {
                frmUpdateCategory = new UpdateCategoryForm(DC, this);
            }
            frmUpdateCategory.ShowDialog();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (frmDeleteCategory == null)
            {
                frmDeleteCategory = new DeleteCategoryForm(DC, this);
            }
            frmDeleteCategory.ShowDialog();
        }

        private void btnCategoriesReport_Click(object sender, EventArgs e)
        {
            if (frmCategoryReport == null)
            {
                frmCategoryReport = new CategoryReportForm(DC, this);
            }
            frmCategoryReport.ShowDialog();
        }
    }
}
