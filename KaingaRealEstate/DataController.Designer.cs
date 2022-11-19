
namespace KaingaRealEstate
{
    partial class DataController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataController));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ctnKainga = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daAgent = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daBuyer = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daBuyerCategory = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.daBuyerSuburb = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.daCategory = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.daOffer = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
            this.daProperty = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
            this.daSeller = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand9 = new System.Data.OleDb.OleDbCommand();
            this.daSuburb = new System.Data.OleDb.OleDbDataAdapter();
            this.dsKainga = new KaingaRealEstate.KaingaRealEstateDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dsKainga)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT                 agentID, lastName, firstName, streetAddress, suburb, email" +
    "Address, phoneNumber, certification, salary\r\nFROM                   AGENT\r\nORDER" +
    " BY           agentID";
            this.oleDbSelectCommand1.Connection = this.ctnKainga;
            // 
            // ctnKainga
            // 
            this.ctnKainga.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\5607\\KaingaRealEstate.mdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `AGENT` (`lastName`, `firstName`, `streetAddress`, `suburb`, `emailAd" +
    "dress`, `phoneNumber`, `certification`, `salary`) VALUES (?, ?, ?, ?, ?, ?, ?, ?" +
    ")";
            this.oleDbInsertCommand1.Connection = this.ctnKainga;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 0, "lastName"),
            new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 0, "firstName"),
            new System.Data.OleDb.OleDbParameter("streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "streetAddress"),
            new System.Data.OleDb.OleDbParameter("suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "suburb"),
            new System.Data.OleDb.OleDbParameter("emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "emailAddress"),
            new System.Data.OleDb.OleDbParameter("phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "phoneNumber"),
            new System.Data.OleDb.OleDbParameter("certification", System.Data.OleDb.OleDbType.VarWChar, 0, "certification"),
            new System.Data.OleDb.OleDbParameter("salary", System.Data.OleDb.OleDbType.Currency, 0, "salary")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.ctnKainga;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 0, "lastName"),
            new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 0, "firstName"),
            new System.Data.OleDb.OleDbParameter("streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "streetAddress"),
            new System.Data.OleDb.OleDbParameter("suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "suburb"),
            new System.Data.OleDb.OleDbParameter("emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "emailAddress"),
            new System.Data.OleDb.OleDbParameter("phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "phoneNumber"),
            new System.Data.OleDb.OleDbParameter("certification", System.Data.OleDb.OleDbType.VarWChar, 0, "certification"),
            new System.Data.OleDb.OleDbParameter("salary", System.Data.OleDb.OleDbType.Currency, 0, "salary"),
            new System.Data.OleDb.OleDbParameter("Original_agentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agentID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_lastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_firstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_streetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_emailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_phoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_certification", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "certification", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_certification", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "certification", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "salary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "salary", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.ctnKainga;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_agentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agentID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_lastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_firstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_streetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_emailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_phoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_certification", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "certification", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_certification", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "certification", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "salary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "salary", System.Data.DataRowVersion.Original, null)});
            // 
            // daAgent
            // 
            this.daAgent.DeleteCommand = this.oleDbDeleteCommand1;
            this.daAgent.InsertCommand = this.oleDbInsertCommand1;
            this.daAgent.SelectCommand = this.oleDbSelectCommand1;
            this.daAgent.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AGENT", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("agentID", "agentID"),
                        new System.Data.Common.DataColumnMapping("lastName", "lastName"),
                        new System.Data.Common.DataColumnMapping("firstName", "firstName"),
                        new System.Data.Common.DataColumnMapping("streetAddress", "streetAddress"),
                        new System.Data.Common.DataColumnMapping("suburb", "suburb"),
                        new System.Data.Common.DataColumnMapping("emailAddress", "emailAddress"),
                        new System.Data.Common.DataColumnMapping("phoneNumber", "phoneNumber"),
                        new System.Data.Common.DataColumnMapping("certification", "certification"),
                        new System.Data.Common.DataColumnMapping("salary", "salary")})});
            this.daAgent.UpdateCommand = this.oleDbUpdateCommand1;
            this.daAgent.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daAgent_RowUpdated);
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = resources.GetString("oleDbSelectCommand2.CommandText");
            this.oleDbSelectCommand2.Connection = this.ctnKainga;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `BUYER` (`lastName`, `firstName`, `streetAddress`, `suburb`, `city`, " +
    "`emailAddress`, `phoneNumber`, `creditStatus`, `mortgageStatus`, `agentID`) VALU" +
    "ES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.ctnKainga;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 0, "lastName"),
            new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 0, "firstName"),
            new System.Data.OleDb.OleDbParameter("streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "streetAddress"),
            new System.Data.OleDb.OleDbParameter("suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "suburb"),
            new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.VarWChar, 0, "city"),
            new System.Data.OleDb.OleDbParameter("emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "emailAddress"),
            new System.Data.OleDb.OleDbParameter("phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "phoneNumber"),
            new System.Data.OleDb.OleDbParameter("creditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "creditStatus"),
            new System.Data.OleDb.OleDbParameter("mortgageStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "mortgageStatus"),
            new System.Data.OleDb.OleDbParameter("agentID", System.Data.OleDb.OleDbType.Integer, 0, "agentID")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.ctnKainga;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 0, "lastName"),
            new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 0, "firstName"),
            new System.Data.OleDb.OleDbParameter("streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "streetAddress"),
            new System.Data.OleDb.OleDbParameter("suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "suburb"),
            new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.VarWChar, 0, "city"),
            new System.Data.OleDb.OleDbParameter("emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "emailAddress"),
            new System.Data.OleDb.OleDbParameter("phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "phoneNumber"),
            new System.Data.OleDb.OleDbParameter("creditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "creditStatus"),
            new System.Data.OleDb.OleDbParameter("mortgageStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "mortgageStatus"),
            new System.Data.OleDb.OleDbParameter("agentID", System.Data.OleDb.OleDbType.Integer, 0, "agentID"),
            new System.Data.OleDb.OleDbParameter("Original_buyerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "buyerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_lastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_firstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_streetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_city", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_city", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_emailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_phoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_creditStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "creditStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_creditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "creditStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_mortgageStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "mortgageStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_mortgageStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "mortgageStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_agentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agentID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_agentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agentID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnKainga;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_buyerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "buyerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_lastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_firstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_streetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_city", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_city", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_emailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_phoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_creditStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "creditStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_creditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "creditStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_mortgageStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "mortgageStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_mortgageStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "mortgageStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_agentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agentID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_agentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agentID", System.Data.DataRowVersion.Original, null)});
            // 
            // daBuyer
            // 
            this.daBuyer.DeleteCommand = this.oleDbDeleteCommand2;
            this.daBuyer.InsertCommand = this.oleDbInsertCommand2;
            this.daBuyer.SelectCommand = this.oleDbSelectCommand2;
            this.daBuyer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BUYER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("buyerID", "buyerID"),
                        new System.Data.Common.DataColumnMapping("lastName", "lastName"),
                        new System.Data.Common.DataColumnMapping("firstName", "firstName"),
                        new System.Data.Common.DataColumnMapping("streetAddress", "streetAddress"),
                        new System.Data.Common.DataColumnMapping("suburb", "suburb"),
                        new System.Data.Common.DataColumnMapping("city", "city"),
                        new System.Data.Common.DataColumnMapping("emailAddress", "emailAddress"),
                        new System.Data.Common.DataColumnMapping("phoneNumber", "phoneNumber"),
                        new System.Data.Common.DataColumnMapping("creditStatus", "creditStatus"),
                        new System.Data.Common.DataColumnMapping("mortgageStatus", "mortgageStatus"),
                        new System.Data.Common.DataColumnMapping("agentID", "agentID")})});
            this.daBuyer.UpdateCommand = this.oleDbUpdateCommand2;
            this.daBuyer.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daBuyer_RowUpdated);
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT                 buyerID, categoryID, importance\r\nFROM                   BU" +
    "YERCATEGORY\r\nORDER BY           buyerID, categoryID";
            this.oleDbSelectCommand3.Connection = this.ctnKainga;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `BUYERCATEGORY` (`buyerID`, `categoryID`, `importance`) VALUES (?, ?," +
    " ?)";
            this.oleDbInsertCommand3.Connection = this.ctnKainga;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("buyerID", System.Data.OleDb.OleDbType.Integer, 0, "buyerID"),
            new System.Data.OleDb.OleDbParameter("categoryID", System.Data.OleDb.OleDbType.Integer, 0, "categoryID"),
            new System.Data.OleDb.OleDbParameter("importance", System.Data.OleDb.OleDbType.VarWChar, 0, "importance")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE `BUYERCATEGORY` SET `buyerID` = ?, `categoryID` = ?, `importance` = ? WHER" +
    "E ((`buyerID` = ?) AND (`categoryID` = ?) AND ((? = 1 AND `importance` IS NULL) " +
    "OR (`importance` = ?)))";
            this.oleDbUpdateCommand3.Connection = this.ctnKainga;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("buyerID", System.Data.OleDb.OleDbType.Integer, 0, "buyerID"),
            new System.Data.OleDb.OleDbParameter("categoryID", System.Data.OleDb.OleDbType.Integer, 0, "categoryID"),
            new System.Data.OleDb.OleDbParameter("importance", System.Data.OleDb.OleDbType.VarWChar, 0, "importance"),
            new System.Data.OleDb.OleDbParameter("Original_buyerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "buyerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_categoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "categoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_importance", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "importance", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_importance", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "importance", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM `BUYERCATEGORY` WHERE ((`buyerID` = ?) AND (`categoryID` = ?) AND ((?" +
    " = 1 AND `importance` IS NULL) OR (`importance` = ?)))";
            this.oleDbDeleteCommand3.Connection = this.ctnKainga;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_buyerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "buyerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_categoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "categoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_importance", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "importance", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_importance", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "importance", System.Data.DataRowVersion.Original, null)});
            // 
            // daBuyerCategory
            // 
            this.daBuyerCategory.DeleteCommand = this.oleDbDeleteCommand3;
            this.daBuyerCategory.InsertCommand = this.oleDbInsertCommand3;
            this.daBuyerCategory.SelectCommand = this.oleDbSelectCommand3;
            this.daBuyerCategory.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BUYERCATEGORY", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("buyerID", "buyerID"),
                        new System.Data.Common.DataColumnMapping("categoryID", "categoryID"),
                        new System.Data.Common.DataColumnMapping("importance", "importance")})});
            this.daBuyerCategory.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT                 buyerID, suburbID, importance\r\nFROM                   BUYE" +
    "RSUBURB\r\nORDER BY           buyerID, suburbID";
            this.oleDbSelectCommand4.Connection = this.ctnKainga;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO `BUYERSUBURB` (`buyerID`, `suburbID`, `importance`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand4.Connection = this.ctnKainga;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("buyerID", System.Data.OleDb.OleDbType.Integer, 0, "buyerID"),
            new System.Data.OleDb.OleDbParameter("suburbID", System.Data.OleDb.OleDbType.Integer, 0, "suburbID"),
            new System.Data.OleDb.OleDbParameter("importance", System.Data.OleDb.OleDbType.VarWChar, 0, "importance")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = "UPDATE `BUYERSUBURB` SET `buyerID` = ?, `suburbID` = ?, `importance` = ? WHERE ((" +
    "`buyerID` = ?) AND (`suburbID` = ?) AND ((? = 1 AND `importance` IS NULL) OR (`i" +
    "mportance` = ?)))";
            this.oleDbUpdateCommand4.Connection = this.ctnKainga;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("buyerID", System.Data.OleDb.OleDbType.Integer, 0, "buyerID"),
            new System.Data.OleDb.OleDbParameter("suburbID", System.Data.OleDb.OleDbType.Integer, 0, "suburbID"),
            new System.Data.OleDb.OleDbParameter("importance", System.Data.OleDb.OleDbType.VarWChar, 0, "importance"),
            new System.Data.OleDb.OleDbParameter("Original_buyerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "buyerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_suburbID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburbID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_importance", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "importance", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_importance", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "importance", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = "DELETE FROM `BUYERSUBURB` WHERE ((`buyerID` = ?) AND (`suburbID` = ?) AND ((? = 1" +
    " AND `importance` IS NULL) OR (`importance` = ?)))";
            this.oleDbDeleteCommand4.Connection = this.ctnKainga;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_buyerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "buyerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_suburbID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburbID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_importance", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "importance", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_importance", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "importance", System.Data.DataRowVersion.Original, null)});
            // 
            // daBuyerSuburb
            // 
            this.daBuyerSuburb.DeleteCommand = this.oleDbDeleteCommand4;
            this.daBuyerSuburb.InsertCommand = this.oleDbInsertCommand4;
            this.daBuyerSuburb.SelectCommand = this.oleDbSelectCommand4;
            this.daBuyerSuburb.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BUYERSUBURB", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("buyerID", "buyerID"),
                        new System.Data.Common.DataColumnMapping("suburbID", "suburbID"),
                        new System.Data.Common.DataColumnMapping("importance", "importance")})});
            this.daBuyerSuburb.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT                 categoryID, categoryDescription, [level]\r\nFROM            " +
    "       CATEGORY\r\nORDER BY           categoryID";
            this.oleDbSelectCommand5.Connection = this.ctnKainga;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `CATEGORY` (`categoryDescription`, `level`) VALUES (?, ?)";
            this.oleDbInsertCommand5.Connection = this.ctnKainga;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("categoryDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "categoryDescription"),
            new System.Data.OleDb.OleDbParameter("level", System.Data.OleDb.OleDbType.VarWChar, 0, "level")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.ctnKainga;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("categoryDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "categoryDescription"),
            new System.Data.OleDb.OleDbParameter("level", System.Data.OleDb.OleDbType.VarWChar, 0, "level"),
            new System.Data.OleDb.OleDbParameter("Original_categoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "categoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_categoryDescription", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "categoryDescription", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_categoryDescription", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "categoryDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_level", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "level", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_level", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "level", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = "DELETE FROM `CATEGORY` WHERE ((`categoryID` = ?) AND ((? = 1 AND `categoryDescrip" +
    "tion` IS NULL) OR (`categoryDescription` = ?)) AND ((? = 1 AND `level` IS NULL) " +
    "OR (`level` = ?)))";
            this.oleDbDeleteCommand5.Connection = this.ctnKainga;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_categoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "categoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_categoryDescription", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "categoryDescription", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_categoryDescription", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "categoryDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_level", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "level", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_level", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "level", System.Data.DataRowVersion.Original, null)});
            // 
            // daCategory
            // 
            this.daCategory.DeleteCommand = this.oleDbDeleteCommand5;
            this.daCategory.InsertCommand = this.oleDbInsertCommand5;
            this.daCategory.SelectCommand = this.oleDbSelectCommand5;
            this.daCategory.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CATEGORY", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("categoryID", "categoryID"),
                        new System.Data.Common.DataColumnMapping("categoryDescription", "categoryDescription"),
                        new System.Data.Common.DataColumnMapping("level", "level")})});
            this.daCategory.UpdateCommand = this.oleDbUpdateCommand5;
            this.daCategory.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daCategory_RowUpdated);
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = "SELECT                 buyerID, propertyID, offerAmount, status, offerDate\r\nFROM " +
    "                  OFFER\r\nORDER BY           buyerID, propertyID";
            this.oleDbSelectCommand6.Connection = this.ctnKainga;
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = "INSERT INTO `OFFER` (`buyerID`, `propertyID`, `offerAmount`, `status`, `offerDate" +
    "`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand6.Connection = this.ctnKainga;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("buyerID", System.Data.OleDb.OleDbType.Integer, 0, "buyerID"),
            new System.Data.OleDb.OleDbParameter("propertyID", System.Data.OleDb.OleDbType.Integer, 0, "propertyID"),
            new System.Data.OleDb.OleDbParameter("offerAmount", System.Data.OleDb.OleDbType.Currency, 0, "offerAmount"),
            new System.Data.OleDb.OleDbParameter("status", System.Data.OleDb.OleDbType.VarWChar, 0, "status"),
            new System.Data.OleDb.OleDbParameter("offerDate", System.Data.OleDb.OleDbType.Date, 0, "offerDate")});
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = resources.GetString("oleDbUpdateCommand6.CommandText");
            this.oleDbUpdateCommand6.Connection = this.ctnKainga;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("buyerID", System.Data.OleDb.OleDbType.Integer, 0, "buyerID"),
            new System.Data.OleDb.OleDbParameter("propertyID", System.Data.OleDb.OleDbType.Integer, 0, "propertyID"),
            new System.Data.OleDb.OleDbParameter("offerAmount", System.Data.OleDb.OleDbType.Currency, 0, "offerAmount"),
            new System.Data.OleDb.OleDbParameter("status", System.Data.OleDb.OleDbType.VarWChar, 0, "status"),
            new System.Data.OleDb.OleDbParameter("offerDate", System.Data.OleDb.OleDbType.Date, 0, "offerDate"),
            new System.Data.OleDb.OleDbParameter("Original_buyerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "buyerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_propertyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "propertyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_offerAmount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "offerAmount", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_offerAmount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "offerAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_offerDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "offerDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_offerDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "offerDate", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.ctnKainga;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_buyerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "buyerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_propertyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "propertyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_offerAmount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "offerAmount", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_offerAmount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "offerAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_offerDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "offerDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_offerDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "offerDate", System.Data.DataRowVersion.Original, null)});
            // 
            // daOffer
            // 
            this.daOffer.DeleteCommand = this.oleDbDeleteCommand6;
            this.daOffer.InsertCommand = this.oleDbInsertCommand6;
            this.daOffer.SelectCommand = this.oleDbSelectCommand6;
            this.daOffer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "OFFER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("buyerID", "buyerID"),
                        new System.Data.Common.DataColumnMapping("propertyID", "propertyID"),
                        new System.Data.Common.DataColumnMapping("offerAmount", "offerAmount"),
                        new System.Data.Common.DataColumnMapping("status", "status"),
                        new System.Data.Common.DataColumnMapping("offerDate", "offerDate")})});
            this.daOffer.UpdateCommand = this.oleDbUpdateCommand6;
            // 
            // oleDbSelectCommand7
            // 
            this.oleDbSelectCommand7.CommandText = "SELECT                 propertyID, streetAddress, propertyDescription, price, sta" +
    "tus, suburbID, categoryID, sellerID\r\nFROM                   PROPERTY\r\nORDER BY  " +
    "         propertyID";
            this.oleDbSelectCommand7.Connection = this.ctnKainga;
            // 
            // oleDbInsertCommand7
            // 
            this.oleDbInsertCommand7.CommandText = "INSERT INTO `PROPERTY` (`streetAddress`, `propertyDescription`, `price`, `status`" +
    ", `suburbID`, `categoryID`, `sellerID`) VALUES (?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand7.Connection = this.ctnKainga;
            this.oleDbInsertCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "streetAddress"),
            new System.Data.OleDb.OleDbParameter("propertyDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "propertyDescription"),
            new System.Data.OleDb.OleDbParameter("price", System.Data.OleDb.OleDbType.Currency, 0, "price"),
            new System.Data.OleDb.OleDbParameter("status", System.Data.OleDb.OleDbType.VarWChar, 0, "status"),
            new System.Data.OleDb.OleDbParameter("suburbID", System.Data.OleDb.OleDbType.Integer, 0, "suburbID"),
            new System.Data.OleDb.OleDbParameter("categoryID", System.Data.OleDb.OleDbType.Integer, 0, "categoryID"),
            new System.Data.OleDb.OleDbParameter("sellerID", System.Data.OleDb.OleDbType.Integer, 0, "sellerID")});
            // 
            // oleDbUpdateCommand7
            // 
            this.oleDbUpdateCommand7.CommandText = resources.GetString("oleDbUpdateCommand7.CommandText");
            this.oleDbUpdateCommand7.Connection = this.ctnKainga;
            this.oleDbUpdateCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "streetAddress"),
            new System.Data.OleDb.OleDbParameter("propertyDescription", System.Data.OleDb.OleDbType.VarWChar, 0, "propertyDescription"),
            new System.Data.OleDb.OleDbParameter("price", System.Data.OleDb.OleDbType.Currency, 0, "price"),
            new System.Data.OleDb.OleDbParameter("status", System.Data.OleDb.OleDbType.VarWChar, 0, "status"),
            new System.Data.OleDb.OleDbParameter("suburbID", System.Data.OleDb.OleDbType.Integer, 0, "suburbID"),
            new System.Data.OleDb.OleDbParameter("categoryID", System.Data.OleDb.OleDbType.Integer, 0, "categoryID"),
            new System.Data.OleDb.OleDbParameter("sellerID", System.Data.OleDb.OleDbType.Integer, 0, "sellerID"),
            new System.Data.OleDb.OleDbParameter("Original_propertyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "propertyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_streetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_propertyDescription", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "propertyDescription", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_propertyDescription", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "propertyDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburbID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburbID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburbID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburbID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_categoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "categoryID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_categoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "categoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_sellerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sellerID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_sellerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sellerID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand7
            // 
            this.oleDbDeleteCommand7.CommandText = resources.GetString("oleDbDeleteCommand7.CommandText");
            this.oleDbDeleteCommand7.Connection = this.ctnKainga;
            this.oleDbDeleteCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_propertyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "propertyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_streetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_propertyDescription", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "propertyDescription", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_propertyDescription", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "propertyDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburbID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburbID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburbID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburbID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_categoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "categoryID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_categoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "categoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_sellerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sellerID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_sellerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sellerID", System.Data.DataRowVersion.Original, null)});
            // 
            // daProperty
            // 
            this.daProperty.DeleteCommand = this.oleDbDeleteCommand7;
            this.daProperty.InsertCommand = this.oleDbInsertCommand7;
            this.daProperty.SelectCommand = this.oleDbSelectCommand7;
            this.daProperty.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROPERTY", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("propertyID", "propertyID"),
                        new System.Data.Common.DataColumnMapping("streetAddress", "streetAddress"),
                        new System.Data.Common.DataColumnMapping("propertyDescription", "propertyDescription"),
                        new System.Data.Common.DataColumnMapping("price", "price"),
                        new System.Data.Common.DataColumnMapping("status", "status"),
                        new System.Data.Common.DataColumnMapping("suburbID", "suburbID"),
                        new System.Data.Common.DataColumnMapping("categoryID", "categoryID"),
                        new System.Data.Common.DataColumnMapping("sellerID", "sellerID")})});
            this.daProperty.UpdateCommand = this.oleDbUpdateCommand7;
            this.daProperty.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daProperty_RowUpdated);
            // 
            // oleDbSelectCommand8
            // 
            this.oleDbSelectCommand8.CommandText = "SELECT                 sellerID, lastName, firstName, streetAddress, suburb, city" +
    ", emailAddress, phoneNumber, status\r\nFROM                   SELLER\r\nORDER BY    " +
    "       sellerID";
            this.oleDbSelectCommand8.Connection = this.ctnKainga;
            // 
            // oleDbInsertCommand8
            // 
            this.oleDbInsertCommand8.CommandText = "INSERT INTO `SELLER` (`lastName`, `firstName`, `streetAddress`, `suburb`, `city`," +
    " `emailAddress`, `phoneNumber`, `status`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand8.Connection = this.ctnKainga;
            this.oleDbInsertCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 0, "lastName"),
            new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 0, "firstName"),
            new System.Data.OleDb.OleDbParameter("streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "streetAddress"),
            new System.Data.OleDb.OleDbParameter("suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "suburb"),
            new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.VarWChar, 0, "city"),
            new System.Data.OleDb.OleDbParameter("emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "emailAddress"),
            new System.Data.OleDb.OleDbParameter("phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "phoneNumber"),
            new System.Data.OleDb.OleDbParameter("status", System.Data.OleDb.OleDbType.VarWChar, 0, "status")});
            // 
            // oleDbUpdateCommand8
            // 
            this.oleDbUpdateCommand8.CommandText = resources.GetString("oleDbUpdateCommand8.CommandText");
            this.oleDbUpdateCommand8.Connection = this.ctnKainga;
            this.oleDbUpdateCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 0, "lastName"),
            new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 0, "firstName"),
            new System.Data.OleDb.OleDbParameter("streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "streetAddress"),
            new System.Data.OleDb.OleDbParameter("suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "suburb"),
            new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.VarWChar, 0, "city"),
            new System.Data.OleDb.OleDbParameter("emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "emailAddress"),
            new System.Data.OleDb.OleDbParameter("phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "phoneNumber"),
            new System.Data.OleDb.OleDbParameter("status", System.Data.OleDb.OleDbType.VarWChar, 0, "status"),
            new System.Data.OleDb.OleDbParameter("Original_sellerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sellerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_lastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_firstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_streetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_city", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_city", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_emailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_phoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand8
            // 
            this.oleDbDeleteCommand8.CommandText = resources.GetString("oleDbDeleteCommand8.CommandText");
            this.oleDbDeleteCommand8.Connection = this.ctnKainga;
            this.oleDbDeleteCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_sellerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sellerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_lastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_lastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_firstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_firstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "firstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_streetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_streetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "streetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_city", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_city", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_emailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_emailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "emailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_phoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_phoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, null)});
            // 
            // daSeller
            // 
            this.daSeller.DeleteCommand = this.oleDbDeleteCommand8;
            this.daSeller.InsertCommand = this.oleDbInsertCommand8;
            this.daSeller.SelectCommand = this.oleDbSelectCommand8;
            this.daSeller.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SELLER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("sellerID", "sellerID"),
                        new System.Data.Common.DataColumnMapping("lastName", "lastName"),
                        new System.Data.Common.DataColumnMapping("firstName", "firstName"),
                        new System.Data.Common.DataColumnMapping("streetAddress", "streetAddress"),
                        new System.Data.Common.DataColumnMapping("suburb", "suburb"),
                        new System.Data.Common.DataColumnMapping("city", "city"),
                        new System.Data.Common.DataColumnMapping("emailAddress", "emailAddress"),
                        new System.Data.Common.DataColumnMapping("phoneNumber", "phoneNumber"),
                        new System.Data.Common.DataColumnMapping("status", "status")})});
            this.daSeller.UpdateCommand = this.oleDbUpdateCommand8;
            this.daSeller.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daSeller_RowUpdated);
            // 
            // oleDbSelectCommand9
            // 
            this.oleDbSelectCommand9.CommandText = "SELECT                 suburbID, suburbName, postcode\r\nFROM                   SUB" +
    "URB\r\nORDER BY           suburbID";
            this.oleDbSelectCommand9.Connection = this.ctnKainga;
            // 
            // oleDbInsertCommand9
            // 
            this.oleDbInsertCommand9.CommandText = "INSERT INTO `SUBURB` (`suburbName`, `postcode`) VALUES (?, ?)";
            this.oleDbInsertCommand9.Connection = this.ctnKainga;
            this.oleDbInsertCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("suburbName", System.Data.OleDb.OleDbType.VarWChar, 0, "suburbName"),
            new System.Data.OleDb.OleDbParameter("postcode", System.Data.OleDb.OleDbType.VarWChar, 0, "postcode")});
            // 
            // oleDbUpdateCommand9
            // 
            this.oleDbUpdateCommand9.CommandText = "UPDATE `SUBURB` SET `suburbName` = ?, `postcode` = ? WHERE ((`suburbID` = ?) AND " +
    "((? = 1 AND `suburbName` IS NULL) OR (`suburbName` = ?)) AND ((? = 1 AND `postco" +
    "de` IS NULL) OR (`postcode` = ?)))";
            this.oleDbUpdateCommand9.Connection = this.ctnKainga;
            this.oleDbUpdateCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("suburbName", System.Data.OleDb.OleDbType.VarWChar, 0, "suburbName"),
            new System.Data.OleDb.OleDbParameter("postcode", System.Data.OleDb.OleDbType.VarWChar, 0, "postcode"),
            new System.Data.OleDb.OleDbParameter("Original_suburbID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburbID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburbName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburbName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburbName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburbName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_postcode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "postcode", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_postcode", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "postcode", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand9
            // 
            this.oleDbDeleteCommand9.CommandText = "DELETE FROM `SUBURB` WHERE ((`suburbID` = ?) AND ((? = 1 AND `suburbName` IS NULL" +
    ") OR (`suburbName` = ?)) AND ((? = 1 AND `postcode` IS NULL) OR (`postcode` = ?)" +
    "))";
            this.oleDbDeleteCommand9.Connection = this.ctnKainga;
            this.oleDbDeleteCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_suburbID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburbID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_suburbName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "suburbName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_suburbName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "suburbName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_postcode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "postcode", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_postcode", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "postcode", System.Data.DataRowVersion.Original, null)});
            // 
            // daSuburb
            // 
            this.daSuburb.DeleteCommand = this.oleDbDeleteCommand9;
            this.daSuburb.InsertCommand = this.oleDbInsertCommand9;
            this.daSuburb.SelectCommand = this.oleDbSelectCommand9;
            this.daSuburb.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SUBURB", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("suburbID", "suburbID"),
                        new System.Data.Common.DataColumnMapping("suburbName", "suburbName"),
                        new System.Data.Common.DataColumnMapping("postcode", "postcode")})});
            this.daSuburb.UpdateCommand = this.oleDbUpdateCommand9;
            this.daSuburb.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daSuburb_RowUpdated);
            // 
            // dsKainga
            // 
            this.dsKainga.DataSetName = "KaingaRealEstateDataSet";
            this.dsKainga.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DataController";
            this.Text = "DataController";
            ((System.ComponentModel.ISupportInitialize)(this.dsKainga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection ctnKainga;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter daAgent;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daBuyer;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter daBuyerCategory;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter daBuyerSuburb;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter daCategory;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
        private System.Data.OleDb.OleDbDataAdapter daOffer;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
        private System.Data.OleDb.OleDbDataAdapter daProperty;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand8;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
        private System.Data.OleDb.OleDbDataAdapter daSeller;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand9;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand9;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand9;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand9;
        private System.Data.OleDb.OleDbDataAdapter daSuburb;
        public KaingaRealEstateDataSet dsKainga;
    }
}