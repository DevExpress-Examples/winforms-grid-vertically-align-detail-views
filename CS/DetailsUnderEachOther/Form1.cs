using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace DetailsUnderEachOther {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FillDataSet();
            DemoExpand();
        }

        private void FillDataSet() {
            DataSet1.MasterTableRow masterRow = dataSet1.MasterTable.AddMasterTableRow(1, "Item 1");
            dataSet1.DetailA.AddDetailARow(1, masterRow, "detail A / 1");
            dataSet1.DetailB.AddDetailBRow(1, masterRow, "1", "B2 / 1");
            dataSet1.DetailB.AddDetailBRow(2, masterRow, "2", "B2 / 1");

            masterRow = dataSet1.MasterTable.AddMasterTableRow(2, "Item 2");
            dataSet1.DetailA.AddDetailARow(2, masterRow, "detail A / 2");
            dataSet1.DetailB.AddDetailBRow(3, masterRow, "3", "B2 / 2");
        }
        private void DemoExpand() {
            gridControl1.ForceInitialize();
            gvMaster.SetMasterRowExpanded(0, true);
            GridView gridRelations = (GridView)gvMaster.GetDetailView(0, 0);
            gridRelations.SetMasterRowExpanded(0, true);
            gridRelations.SetMasterRowExpanded(1, true);
        }

        private void gvMaster_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            e.IsEmpty = false;
        }

        private void gvMaster_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        private void gvMaster_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Relations";
        }

        private void gvMaster_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            List<RelationName> relations = new List<RelationName>();
            foreach(DataRelation dataRelation in dataSet1.MasterTable.ChildRelations)
                relations.Add(new RelationName(dataRelation.ChildTable.TableName));
            e.ChildList = relations;
        }

        private void gvRelations_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            e.IsEmpty = false;
        }

        private void gvRelations_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        private string GetRelationName(GridView gridRelations, int row) {
            RelationName relation = (RelationName)gridRelations.GetRow(row);
            if(relation == null) return string.Empty;
            string childTableName = relation.Relation;
            DataTable childTable = dataSet1.Tables[childTableName];
            return childTable.ParentRelations[0].RelationName;
        }
        private void gvRelations_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = GetRelationName((GridView)sender, e.RowHandle);
        }

        private void gvRelations_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e) {
            GridView fakeMasterView = (GridView)sender;

            GridView realMasterView = (GridView)fakeMasterView.ParentView;
            int realMasterRow = fakeMasterView.SourceRowHandle;
            int realListSourceRow = realMasterView.GetDataSourceRowIndex(realMasterRow);
            int realRelationIndex =  fakeMasterView.GetDataSourceRowIndex(e.RowHandle); // real relation indexes correspond to fake row indexes
            e.ChildList = GetRelationList(realMasterView, realListSourceRow, realRelationIndex);
        }

        private IList GetRelationList(GridView view, int listSourceRow, int relationIndex) {
            return view.DataController.Helper.RelationList.GetDetailList(listSourceRow, relationIndex);
        }
    }

    class RelationName {
        public RelationName(string relation) {
            _Relation = relation;
        }

        private string _Relation;
        public string Relation {
            get { return _Relation; }
        }
    }
}