﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xPozicky
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnVymazatPoziku = New System.Windows.Forms.Button()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection3 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork3 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumpozicania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumvratenia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnVymazatPoziku)
        Me.LayoutControl1.Controls.Add(Me.GridControl3)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3190, 236, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1188, 538)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnVymazatPoziku
        '
        Me.btnVymazatPoziku.BackColor = System.Drawing.Color.RosyBrown
        Me.btnVymazatPoziku.Location = New System.Drawing.Point(12, 12)
        Me.btnVymazatPoziku.Name = "btnVymazatPoziku"
        Me.btnVymazatPoziku.Size = New System.Drawing.Size(1164, 54)
        Me.btnVymazatPoziku.TabIndex = 30
        Me.btnVymazatPoziku.Text = "Vymazat pozicku"
        Me.btnVymazatPoziku.UseVisualStyleBackColor = False
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.XpCollection3
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl3.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl3.Location = New System.Drawing.Point(12, 70)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1164, 456)
        Me.GridControl3.TabIndex = 29
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'XpCollection3
        '
        Me.XpCollection3.DisplayableProperties = "Key;Kniha;Citatel;Datumpozicania;Datumvratenia"
        Me.XpCollection3.ObjectType = GetType(Kniznica2.Pozicky)
        Me.XpCollection3.Session = Me.UnitOfWork3
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey2, Me.colDatumpozicania, Me.colDatumvratenia, Me.GridColumn1, Me.GridColumn2})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKey2, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colKey2
        '
        Me.colKey2.FieldName = "Key"
        Me.colKey2.Name = "colKey2"
        '
        'colDatumpozicania
        '
        Me.colDatumpozicania.Caption = "Datum pozicania"
        Me.colDatumpozicania.FieldName = "Datumpozicania"
        Me.colDatumpozicania.Name = "colDatumpozicania"
        Me.colDatumpozicania.Visible = True
        Me.colDatumpozicania.VisibleIndex = 2
        Me.colDatumpozicania.Width = 139
        '
        'colDatumvratenia
        '
        Me.colDatumvratenia.Caption = "Datum vratenia"
        Me.colDatumvratenia.FieldName = "Datumvratenia"
        Me.colDatumvratenia.Name = "colDatumvratenia"
        Me.colDatumvratenia.Visible = True
        Me.colDatumvratenia.VisibleIndex = 3
        Me.colDatumvratenia.Width = 143
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Priezvisko"
        Me.GridColumn1.FieldName = "Citatel.Priezvisko"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 149
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nazov knihy"
        Me.GridColumn2.FieldName = "Kniha.Nazov"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 254
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1188, 538)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnVymazatPoziku
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1168, 58)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl3
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1168, 460)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'xPozicky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 538)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xPozicky"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "xPozicky"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnVymazatPoziku As Button
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKey2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumpozicania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumvratenia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCollection3 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork3 As DevExpress.Xpo.UnitOfWork
End Class