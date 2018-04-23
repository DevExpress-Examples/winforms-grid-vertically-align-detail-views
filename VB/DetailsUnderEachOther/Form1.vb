Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections

Namespace DetailsUnderEachOther
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            FillDataSet()
            DemoExpand()
        End Sub

        Private Sub FillDataSet()
            Dim masterRow As DetailsUnderEachOther.DataSet1.MasterTableRow = dataSet1_Renamed.MasterTable.AddMasterTableRow(1, "Item 1")
            dataSet1_Renamed.DetailA.AddDetailARow(1, masterRow, "detail A / 1")
            dataSet1_Renamed.DetailB.AddDetailBRow(1, masterRow, "1", "B2 / 1")
            dataSet1_Renamed.DetailB.AddDetailBRow(2, masterRow, "2", "B2 / 1")

            masterRow = dataSet1_Renamed.MasterTable.AddMasterTableRow(2, "Item 2")
            dataSet1_Renamed.DetailA.AddDetailARow(2, masterRow, "detail A / 2")
            dataSet1_Renamed.DetailB.AddDetailBRow(3, masterRow, "3", "B2 / 2")
        End Sub
        Private Sub DemoExpand()
            gridControl1.ForceInitialize()
            gvMaster.SetMasterRowExpanded(0, True)
            Dim gridRelations As GridView = CType(gvMaster.GetDetailView(0, 0), GridView)
            gridRelations.SetMasterRowExpanded(0, True)
            gridRelations.SetMasterRowExpanded(1, True)
        End Sub

        Private Sub gvMaster_MasterRowEmpty(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles gvMaster.MasterRowEmpty
            e.IsEmpty = False
        End Sub

        Private Sub gvMaster_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles gvMaster.MasterRowGetRelationCount
            e.RelationCount = 1
        End Sub

        Private Sub gvMaster_MasterRowGetRelationName(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs) Handles gvMaster.MasterRowGetRelationName
            e.RelationName = "Relations"
        End Sub

        Private Sub gvMaster_MasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles gvMaster.MasterRowGetChildList
            Dim relations As New List(Of RelationName)()
            For Each dataRelation As DataRelation In dataSet1_Renamed.MasterTable.ChildRelations
                relations.Add(New RelationName(dataRelation.ChildTable.TableName))
            Next dataRelation
            e.ChildList = relations
        End Sub

        Private Sub gvRelations_MasterRowEmpty(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles gvRelations.MasterRowEmpty
            e.IsEmpty = False
        End Sub

        Private Sub gvRelations_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles gvRelations.MasterRowGetRelationCount
            e.RelationCount = 1
        End Sub

        Private Function GetRelationName(ByVal gridRelations As GridView, ByVal row As Integer) As String
            Dim relation As RelationName = CType(gridRelations.GetRow(row), RelationName)
            If relation Is Nothing Then
                Return String.Empty
            End If
            Dim childTableName As String = relation.Relation
            Dim childTable As DataTable = dataSet1_Renamed.Tables(childTableName)
            Return childTable.ParentRelations(0).RelationName
        End Function
        Private Sub gvRelations_MasterRowGetRelationName(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs) Handles gvRelations.MasterRowGetRelationName
            e.RelationName = GetRelationName(DirectCast(sender, GridView), e.RowHandle)
        End Sub

        Private Sub gvRelations_MasterRowGetChildList(ByVal sender As Object, ByVal e As MasterRowGetChildListEventArgs) Handles gvRelations.MasterRowGetChildList
            Dim fakeMasterView As GridView = DirectCast(sender, GridView)

            Dim realMasterView As GridView = CType(fakeMasterView.ParentView, GridView)
            Dim realMasterRow As Integer = fakeMasterView.SourceRowHandle
            Dim realListSourceRow As Integer = realMasterView.GetDataSourceRowIndex(realMasterRow)
            Dim realRelationIndex As Integer = fakeMasterView.GetDataSourceRowIndex(e.RowHandle) ' real relation indexes correspond to fake row indexes
            e.ChildList = GetRelationList(realMasterView, realListSourceRow, realRelationIndex)
        End Sub

        Private Function GetRelationList(ByVal view As GridView, ByVal listSourceRow As Integer, ByVal relationIndex As Integer) As IList
            Return view.DataController.Helper.RelationList.GetDetailList(listSourceRow, relationIndex)
        End Function
    End Class

    Friend Class RelationName
        Public Sub New(ByVal relation As String)
            _Relation = relation
        End Sub

        Private _Relation As String
        Public ReadOnly Property Relation() As String
            Get
                Return _Relation
            End Get
        End Property
    End Class
End Namespace