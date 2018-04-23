namespace DetailsUnderEachOther {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvRelations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DetailsUnderEachOther.DataSet1();
            this.gvMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_B = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterID_B = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColB1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColB2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterID_A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRelations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRelations
            // 
            this.gvRelations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gvRelations.GridControl = this.gridControl1;
            this.gvRelations.Name = "gvRelations";
            this.gvRelations.OptionsDetail.ShowDetailTabs = false;
            this.gvRelations.OptionsView.ShowColumnHeaders = false;
            this.gvRelations.OptionsView.ShowGroupPanel = false;
            this.gvRelations.OptionsView.ShowIndicator = false;
            this.gvRelations.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvRelations_MasterRowGetRelationName);
            this.gvRelations.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvRelations_MasterRowEmpty);
            this.gvRelations.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvRelations_MasterRowGetChildList);
            this.gvRelations.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvRelations_MasterRowGetRelationCount);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Relation";
            this.gridColumn1.FieldName = "Relation";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataSet1BindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gvRelations;
            gridLevelNode2.LevelTemplate = this.gridView2;
            gridLevelNode2.RelationName = "MasterTable_DetailA";
            gridLevelNode3.LevelTemplate = this.gridView3;
            gridLevelNode3.RelationName = "MasterTable_DetailB";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2,
            gridLevelNode3});
            gridLevelNode1.RelationName = "Relations";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvMaster;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(599, 416);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaster,
            this.gridView3,
            this.gridView2,
            this.gvRelations});
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataMember = "MasterTable";
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMaster
            // 
            this.gvMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colItemName});
            this.gvMaster.GridControl = this.gridControl1;
            this.gvMaster.Name = "gvMaster";
            this.gvMaster.OptionsDetail.ShowDetailTabs = false;
            this.gvMaster.OptionsView.ShowGroupPanel = false;
            this.gvMaster.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvMaster_MasterRowGetRelationName);
            this.gvMaster.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvMaster_MasterRowEmpty);
            this.gvMaster.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvMaster_MasterRowGetChildList);
            this.gvMaster.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvMaster_MasterRowGetRelationCount);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "ItemName";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_B,
            this.colMasterID_B,
            this.colColB1,
            this.colColB2});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colID_B
            // 
            this.colID_B.Caption = "ID";
            this.colID_B.FieldName = "ID";
            this.colID_B.Name = "colID_B";
            this.colID_B.Visible = true;
            this.colID_B.VisibleIndex = 0;
            // 
            // colMasterID_B
            // 
            this.colMasterID_B.Caption = "MasterID";
            this.colMasterID_B.FieldName = "MasterID";
            this.colMasterID_B.Name = "colMasterID_B";
            this.colMasterID_B.Visible = true;
            this.colMasterID_B.VisibleIndex = 1;
            // 
            // colColB1
            // 
            this.colColB1.Caption = "ColB1";
            this.colColB1.FieldName = "ColB1";
            this.colColB1.Name = "colColB1";
            this.colColB1.Visible = true;
            this.colColB1.VisibleIndex = 2;
            // 
            // colColB2
            // 
            this.colColB2.Caption = "ColB2";
            this.colColB2.FieldName = "ColB2";
            this.colColB2.Name = "colColB2";
            this.colColB2.Visible = true;
            this.colColB2.VisibleIndex = 3;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_A,
            this.colMasterID_A,
            this.colColA});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colID_A
            // 
            this.colID_A.Caption = "ID";
            this.colID_A.FieldName = "ID";
            this.colID_A.Name = "colID_A";
            this.colID_A.Visible = true;
            this.colID_A.VisibleIndex = 0;
            // 
            // colMasterID_A
            // 
            this.colMasterID_A.Caption = "MasterID";
            this.colMasterID_A.FieldName = "MasterID";
            this.colMasterID_A.Name = "colMasterID_A";
            this.colMasterID_A.Visible = true;
            this.colMasterID_A.VisibleIndex = 1;
            // 
            // colColA
            // 
            this.colColA.Caption = "ColA";
            this.colColA.FieldName = "ColA";
            this.colColA.Name = "colColA";
            this.colColA.Visible = true;
            this.colColA.VisibleIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 416);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRelations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaster;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID_A;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterID_A;
        private DevExpress.XtraGrid.Columns.GridColumn colColA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colID_B;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterID_B;
        private DevExpress.XtraGrid.Columns.GridColumn colColB1;
        private DevExpress.XtraGrid.Columns.GridColumn colColB2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRelations;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
    }
}

