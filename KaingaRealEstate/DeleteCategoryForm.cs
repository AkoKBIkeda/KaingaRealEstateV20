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
    public partial class DeleteCategoryForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        private int aCategoryID;
        private CurrencyManager cmCategory;
        public DeleteCategoryForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmCategory = (CurrencyManager)this.BindingContext[DC.dsKainga, "CATEGORY"];
        }
        private void LoadCategories()
        {
            foreach (DataRow drCategory in DC.dtCategory.Rows)
            {
                //added
                DataRow[] drProperties = drCategory.GetChildRows(DC.dtCategory.ChildRelations["CATEGORY_PROPERTY"]);
                if (drProperties.Length == 0) 
                {
                    DataRow[] drBuyers = drCategory.GetChildRows(DC.dtCategory.ChildRelations["CATEGORY_BUYERCATEGORY"]); //changed to "SUBURB_BUYERCATEGORY"
                    if (drBuyers.Length == 0)
                    {
                        cboCategory.Items.Add(drCategory["categoryID"] + (" ") + drCategory["categoryDescription"]);
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
        private void DeleteCategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void ClearFields()
        {
            txtCategoryID.Text = "";
            txtLevel.Text = "";
            txtCategoryDescription.Text = "";
            cboCategory.Text = "";
            cboCategory.Items.Clear();
        }
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboCategory.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aCategoryID = Convert.ToInt32(subs[0]);
            cmCategory.Position = DC.categoryView.Find(aCategoryID);
            DataRow drCategory = DC.dtCategory.Rows[cmCategory.Position];
            txtCategoryID.Text = drCategory["categoryID"].ToString();
            txtLevel.Text = drCategory["level"].ToString();
            txtCategoryDescription.Text = drCategory["categoryDescription"].ToString();
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (cboCategory.Text == "") //added this if statement. the button won't work if there is nothing to remove.
            {
                return;
            }
            else
            {
                DataRow deleteCategoryRow = DC.dtCategory.Rows[cmCategory.Position];
                if (MessageBox.Show("Are you sure to delete this category?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteCategoryRow.Delete();
                    DC.UpdateCategory();
                    MessageBox.Show("Category deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadCategories();
                }
            }
        }
    }
}

