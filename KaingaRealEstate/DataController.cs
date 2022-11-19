using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KaingaRealEstate
{
    public partial class DataController : Form
    {
        public DataTable dtAgent;
        public DataTable dtBuyer;
        public DataTable dtBuyerCategory;
        public DataTable dtBuyerSuburb;
        public DataTable dtCategory;
        public DataTable dtOffer;
        public DataTable dtProperty;
        public DataTable dtSeller;
        public DataTable dtSuburb;
        public DataView agentView;
        public DataView buyerView;
        public DataView buyerCategoryView;
        public DataView buyerSuburbView;
        public DataView categoryView;
        public DataView offerView;
        public DataView propertyView;
        public DataView sellerView;
        public DataView suburbView;
        public DataController()
        {
            InitializeComponent();
            dsKainga.EnforceConstraints = false;
            daAgent.Fill(dsKainga);
            daBuyer.Fill(dsKainga);
            daBuyerCategory.Fill(dsKainga);
            daBuyerSuburb.Fill(dsKainga);
            daCategory.Fill(dsKainga);
            daOffer.Fill(dsKainga);
            daProperty.Fill(dsKainga);
            daSeller.Fill(dsKainga);
            daSuburb.Fill(dsKainga);
            dtAgent = dsKainga.Tables["AGENT"];
            dtBuyer = dsKainga.Tables["BUYER"];
            dtBuyerCategory = dsKainga.Tables["BUYERCATEGORY"];
            dtBuyerSuburb = dsKainga.Tables["BUYERSUBURB"];
            dtCategory = dsKainga.Tables["CATEGORY"];
            dtOffer = dsKainga.Tables["OFFER"];
            dtProperty = dsKainga.Tables["PROPERTY"];
            dtSeller = dsKainga.Tables["SELLER"];
            dtSuburb = dsKainga.Tables["SUBURB"];
            agentView = new DataView(dtAgent);
            agentView.Sort = "agentID";
            buyerView = new DataView(dtBuyer);
            buyerView.Sort = "buyerID";
            buyerCategoryView = new DataView(dtBuyerCategory);
            buyerCategoryView.Sort = "buyerID,categoryID";
            buyerSuburbView = new DataView(dtBuyerSuburb);
            buyerSuburbView.Sort = "buyerID,suburbID";
            categoryView = new DataView(dtCategory);
            categoryView.Sort = "categoryID";
            offerView = new DataView(dtOffer);
            offerView.Sort = "buyerID,propertyID";
            propertyView = new DataView(dtProperty);
            propertyView.Sort = "propertyID";
            sellerView = new DataView(dtSeller);
            sellerView.Sort = "sellerID";
            suburbView = new DataView(dtSuburb);
            suburbView.Sort = "suburbID";
            dsKainga.EnforceConstraints = true;
        }
        public void UpdateSeller()
        {
            daSeller.Update(dsKainga, "SELLER");
        }
        public void UpdateAgent()
        {
            daAgent.Update(dsKainga, "AGENT");
        }
        public void UpdateBuyer()
        {
            daBuyer.Update(dsKainga, "BUYER");
        }
        public void UpdateBuyerSuburb()
        {
            daBuyerSuburb.Update(dsKainga, "BUYERSUBURB");
        }
        public void UpdateBuyerCategory()
        {
            daBuyerCategory.Update(dsKainga, "BUYERCATEGORY");
        }
        public void UpdateProperty()
        {
            daProperty.Update(dsKainga, "PROPERTY");
        }
        public void UpdateOffer()
        {
            daOffer.Update(dsKainga, "OFFER");
        }
        public void UpdateSuburb()
        {
            daSuburb.Update(dsKainga, "SUBURB");
        }
        public void UpdateCategory()
        {
            daCategory.Update(dsKainga, "CATEGORY");
        }
    /*    private void oleDbDataAdapter1_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }*/

        private void daAgent_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnKainga);
            if (e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                //store it in the AgentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["agentID"] = newID;
            }
        }

        private void daBuyer_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnKainga);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["buyerID"] = newID;
            }
        }

        private void daSuburb_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnKainga);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["suburbID"] = newID;
            }
        }

        private void daCategory_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnKainga);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["categoryID"] = newID;
            }
        }

        private void daProperty_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnKainga);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["propertyID"] = newID;
            }
        }

        private void daSeller_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnKainga);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["sellerID"] = newID;
            }
        }
    }
}
