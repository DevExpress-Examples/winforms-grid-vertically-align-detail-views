Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections

Namespace DetailsUnderEachOther

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillDataSet()
            DemoExpand()
        End Sub

        Private Sub FillDataSet()
            Dim masterRow As DataSet1.MasterTableRow = dataSet1.MasterTable.AddMasterTableRow(1, "Item 1")
            dataSet1.DetailA.AddDetailARow(1, masterRow, "detail A / 1")
            dataSet1.DetailB.AddDetailBRow(1, masterRow, "1", "B2 / 1")
            dataSet1.DetailB.AddDetailBRow(2, masterRow, "2", "B2 / 1")
            masterRow = dataSet1.MasterTable.AddMasterTableRow(2, "Item 2")
            dataSet1.DetailA.AddDetailARow(2, masterRow, "detail A / 2")
            dataSet1.DetailB.AddDetailBRow(3, masterRow, "3", "B2 / 2")
        End Sub

        Private Sub DemoExpand()
            gridControl1.ForceInitialize()
            gvMaster.SetMasterRowExpanded(0, True)
            Dim gridRelations As GridView = CType(gvMaster.GetDetailView(0, 0), GridView)
            gridRelations.SetMasterRowExpanded(0, True)
            gridRelations.SetMasterRowExpanded(1, True)
        End Sub

        Private Sub gvMaster_MasterRowEmpty(ByVal sender As Object, ByVal e As MasterRowEmptyEventArgs)
            e.IsEmpty = False
        End Sub

        Private Sub gvMaster_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As MasterRowGetRelationCountEventArgs)
            e.RelationCount = 1
        End Sub

        Private Sub gvMaster_MasterRowGetRelationName(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs)
            e.RelationName = "Relations"
        End Sub

        Private Sub gvMaster_MasterRowGetChildList(ByVal sender As Object, ByVal e As MasterRowGetChildListEventArgs)
            Dim relations As List(Of RelationName) = New List(Of RelationName)()
            For Each dataRelation As DataRelation In dataSet1.MasterTable.ChildRelations
                relations.Add(New RelationName(dataRelation.ChildTable.TableName))
            Next

            e.ChildList = relations
        End Sub

        Private Sub gvRelations_MasterRowEmpty(ByVal sender As Object, ByVal e As MasterRowEmptyEventArgs)
            e.IsEmpty = False
        End Sub

        Private Sub gvRelations_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As MasterRowGetRelationCountEventArgs)
            e.RelationCount = 1
        End Sub

        Private Function GetRelationName(ByVal gridRelations As GridView, ByVal row As Integer) As String
            Dim relation As RelationName = CType(gridRelations.GetRow(row), RelationName)
            If relation Is Nothing Then Return String.Empty
            Dim childTableName As String = relation.Relation
            Dim childTable As DataTable = dataSet1.Tables(childTableName)
            Return childTable.ParentRelations(0).RelationName
        End Function

        Private Sub gvRelations_MasterRowGetRelationName(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs)
            e.RelationName = GetRelationName(CType(sender, GridView), e.RowHandle)
        End Sub

        Private Sub gvRelations_MasterRowGetChildList(ByVal sender As Object, ByVal e As MasterRowGetChildListEventArgs)
            Dim fakeMasterView As GridView = CType(sender, GridView)
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

        Public ReadOnly Property Relation As String
            Get
                Return _Relation
            End Get
        End Property
    End Class
End Namespace
