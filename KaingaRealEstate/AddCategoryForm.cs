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
    public partial class AddCategoryForm : Form
    {
        private DataController DC;
        private ITClerkMainForm frmMenu;
        public AddCategoryForm(DataController dc, ITClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
        }
        private void ClearFields()
        {
            cboLevel.Text = "";
            cboLevel.SelectedIndex = -1;
            txtDescription.Text = "";
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            DataRow newCategoryRow = DC.dtCategory.NewRow();
            if ((cboLevel.Text == "") || (txtDescription.Text == ""))
            {
                MessageBox.Show("You are missing one or more field", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else
            {
                //try
                //{
                    newCategoryRow["Level"] = cboLevel.Text;
                    newCategoryRow["categoryDescription"] = txtDescription.Text;
                    DC.dtCategory.Rows.Add(newCategoryRow);
                    DC.UpdateCategory();
                    MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    ClearFields();
               // }
               /* catch (FormatException)
                {
                    MessageBox.Show("Error");
                }*/
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }
    }
}




























