Namespace DetailsUnderEachOther
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Dim gridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
            Dim gridLevelNode3 As New DevExpress.XtraGrid.GridLevelNode()
            Me.gvRelations = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet1_Renamed = New DetailsUnderEachOther.DataSet1()
            Me.gvMaster = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID_B = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMasterID_B = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColB1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColB2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID_A = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMasterID_A = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColA = New DevExpress.XtraGrid.Columns.GridColumn()
            DirectCast(Me.gvRelations, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataSet1_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gvRelations
            ' 
            Me.gvRelations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1})
            Me.gvRelations.GridControl = Me.gridControl1
            Me.gvRelations.Name = "gvRelations"
            Me.gvRelations.OptionsDetail.ShowDetailTabs = False
            Me.gvRelations.OptionsView.ShowColumnHeaders = False
            Me.gvRelations.OptionsView.ShowGroupPanel = False
            Me.gvRelations.OptionsView.ShowIndicator = False
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "Relation"
            Me.gridColumn1.FieldName = "Relation"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dataSet1BindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = ""
            gridLevelNode1.LevelTemplate = Me.gvRelations
            gridLevelNode2.LevelTemplate = Me.gridView2
            gridLevelNode2.RelationName = "MasterTable_DetailA"
            gridLevelNode3.LevelTemplate = Me.gridView3
            gridLevelNode3.RelationName = "MasterTable_DetailB"
            gridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode2, gridLevelNode3})
            gridLevelNode1.RelationName = "Relations"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gvMaster
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(599, 416)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvMaster, Me.gridView3, Me.gridView2, Me.gvRelations})
            ' 
            ' dataSet1BindingSource
            ' 
            Me.dataSet1BindingSource.DataMember = "MasterTable"
            Me.dataSet1BindingSource.DataSource = Me.dataSet1_Renamed
            ' 
            ' dataSet1
            ' 
            Me.dataSet1_Renamed.DataSetName = "DataSet1"
            Me.dataSet1_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gvMaster
            ' 
            Me.gvMaster.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colItemName})
            Me.gvMaster.GridControl = Me.gridControl1
            Me.gvMaster.Name = "gvMaster"
            Me.gvMaster.OptionsDetail.ShowDetailTabs = False
            Me.gvMaster.OptionsView.ShowGroupPanel = False
            ' 
            ' colID
            ' 
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colItemName
            ' 
            Me.colItemName.Caption = "ItemName"
            Me.colItemName.FieldName = "ItemName"
            Me.colItemName.Name = "colItemName"
            Me.colItemName.Visible = True
            Me.colItemName.VisibleIndex = 1
            ' 
            ' gridView3
            ' 
            Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID_B, Me.colMasterID_B, Me.colColB1, Me.colColB2})
            Me.gridView3.GridControl = Me.gridControl1
            Me.gridView3.Name = "gridView3"
            Me.gridView3.OptionsView.ShowGroupPanel = False
            ' 
            ' colID_B
            ' 
            Me.colID_B.Caption = "ID"
            Me.colID_B.FieldName = "ID"
            Me.colID_B.Name = "colID_B"
            Me.colID_B.Visible = True
            Me.colID_B.VisibleIndex = 0
            ' 
            ' colMasterID_B
            ' 
            Me.colMasterID_B.Caption = "MasterID"
            Me.colMasterID_B.FieldName = "MasterID"
            Me.colMasterID_B.Name = "colMasterID_B"
            Me.colMasterID_B.Visible = True
            Me.colMasterID_B.VisibleIndex = 1
            ' 
            ' colColB1
            ' 
            Me.colColB1.Caption = "ColB1"
            Me.colColB1.FieldName = "ColB1"
            Me.colColB1.Name = "colColB1"
            Me.colColB1.Visible = True
            Me.colColB1.VisibleIndex = 2
            ' 
            ' colColB2
            ' 
            Me.colColB2.Caption = "ColB2"
            Me.colColB2.FieldName = "ColB2"
            Me.colColB2.Name = "colColB2"
            Me.colColB2.Visible = True
            Me.colColB2.VisibleIndex = 3
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID_A, Me.colMasterID_A, Me.colColA})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.ShowGroupPanel = False
            ' 
            ' colID_A
            ' 
            Me.colID_A.Caption = "ID"
            Me.colID_A.FieldName = "ID"
            Me.colID_A.Name = "colID_A"
            Me.colID_A.Visible = True
            Me.colID_A.VisibleIndex = 0
            ' 
            ' colMasterID_A
            ' 
            Me.colMasterID_A.Caption = "MasterID"
            Me.colMasterID_A.FieldName = "MasterID"
            Me.colMasterID_A.Name = "colMasterID_A"
            Me.colMasterID_A.Visible = True
            Me.colMasterID_A.VisibleIndex = 1
            ' 
            ' colColA
            ' 
            Me.colColA.Caption = "ColA"
            Me.colColA.FieldName = "ColA"
            Me.colColA.Name = "colColA"
            Me.colColA.Visible = True
            Me.colColA.VisibleIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(599, 416)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gvRelations, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataSet1_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gvMaster, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Friend gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gvMaster As DevExpress.XtraGrid.Views.Grid.GridView
        Private dataSet1BindingSource As System.Windows.Forms.BindingSource

        Private dataSet1_Renamed As DataSet1
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colID_A As DevExpress.XtraGrid.Columns.GridColumn
        Private colMasterID_A As DevExpress.XtraGrid.Columns.GridColumn
        Private colColA As DevExpress.XtraGrid.Columns.GridColumn
        Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colID_B As DevExpress.XtraGrid.Columns.GridColumn
        Private colMasterID_B As DevExpress.XtraGrid.Columns.GridColumn
        Private colColB1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colColB2 As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents gvRelations As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colItemName As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

