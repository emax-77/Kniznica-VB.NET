<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Knihy
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Knihy))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection3 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork3 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumpozicania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumvratenia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork2 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nazov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPozicana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPocet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.sbtnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.UnitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton4)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton5)
        Me.LayoutControl1.Controls.Add(Me.sbtnExportExcel)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3014, 575, 715, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1116, 546)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection3
        Me.GridControl1.Location = New System.Drawing.Point(12, 363)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1092, 171)
        Me.GridControl1.TabIndex = 40
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'XpCollection3
        '
        Me.XpCollection3.DisplayableProperties = "Key;Kniha;Citatel;Datumpozicania;Datumvratenia"
        Me.XpCollection3.ObjectType = GetType(Kniznica2.Pozicka)
        Me.XpCollection3.Session = Me.UnitOfWork3
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey, Me.colDatumpozicania, Me.colDatumvratenia, Me.GridColumn2, Me.GridColumn3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colKey
        '
        Me.colKey.FieldName = "Key"
        Me.colKey.Name = "colKey"
        '
        'colDatumpozicania
        '
        Me.colDatumpozicania.FieldName = "Datumpozicania"
        Me.colDatumpozicania.Name = "colDatumpozicania"
        '
        'colDatumvratenia
        '
        Me.colDatumvratenia.FieldName = "Datumvratenia"
        Me.colDatumvratenia.Name = "colDatumvratenia"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Kniha"
        Me.GridColumn2.FieldName = "Kniha.Nazov"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Priezvisko"
        Me.GridColumn3.FieldName = "Citatel.Priezvisko"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.XpCollection2
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.GridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GridControl2.Location = New System.Drawing.Point(12, 52)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1092, 307)
        Me.GridControl2.TabIndex = 25
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'XpCollection2
        '
        Me.XpCollection2.DisplayableProperties = "Key;Id;Pocet;Nazov;Autor;Pozicana"
        Me.XpCollection2.ObjectType = GetType(Kniznica2.Kniha)
        Me.XpCollection2.Session = Me.UnitOfWork2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey1, Me.colId, Me.Nazov, Me.colAutor, Me.colPozicana, Me.colPocet, Me.GridColumn1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colKey1
        '
        Me.colKey1.FieldName = "Key"
        Me.colKey1.Name = "colKey1"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 46
        '
        'Nazov
        '
        Me.Nazov.FieldName = "Nazov"
        Me.Nazov.Name = "Nazov"
        Me.Nazov.Visible = True
        Me.Nazov.VisibleIndex = 2
        Me.Nazov.Width = 217
        '
        'colAutor
        '
        Me.colAutor.FieldName = "Autor"
        Me.colAutor.Name = "colAutor"
        Me.colAutor.Visible = True
        Me.colAutor.VisibleIndex = 3
        Me.colAutor.Width = 242
        '
        'colPozicana
        '
        Me.colPozicana.FieldName = "Pozicana"
        Me.colPozicana.Name = "colPozicana"
        Me.colPozicana.OptionsColumn.AllowEdit = False
        Me.colPozicana.Visible = True
        Me.colPozicana.VisibleIndex = 1
        Me.colPozicana.Width = 54
        '
        'colPocet
        '
        Me.colPocet.Caption = "Mnozstvo"
        Me.colPocet.FieldName = "Pocet"
        Me.colPocet.Name = "colPocet"
        Me.colPocet.Visible = True
        Me.colPocet.VisibleIndex = 4
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Pozicanych"
        Me.GridColumn1.FieldName = "PocetPozicanych"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(179, 36)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 35
        Me.SimpleButton1.Text = "Nova Kniha"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(195, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(179, 36)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 36
        Me.SimpleButton2.Text = "Upravit"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(378, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(178, 36)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 37
        Me.SimpleButton3.Text = "Vymazat"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(560, 12)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(179, 36)
        Me.SimpleButton4.StyleController = Me.LayoutControl1
        Me.SimpleButton4.TabIndex = 38
        Me.SimpleButton4.Text = "Pozicat knihu"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(743, 12)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(178, 36)
        Me.SimpleButton5.StyleController = Me.LayoutControl1
        Me.SimpleButton5.TabIndex = 39
        Me.SimpleButton5.Text = "Vratit knihu"
        '
        'sbtnExportExcel
        '
        Me.sbtnExportExcel.ImageOptions.Image = CType(resources.GetObject("sbtnExportExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.sbtnExportExcel.Location = New System.Drawing.Point(925, 12)
        Me.sbtnExportExcel.Name = "sbtnExportExcel"
        Me.sbtnExportExcel.Size = New System.Drawing.Size(179, 36)
        Me.sbtnExportExcel.StyleController = Me.LayoutControl1
        Me.sbtnExportExcel.TabIndex = 43
        Me.sbtnExportExcel.Text = "Export do Excelu"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem2, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1116, 546)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl2
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1096, 311)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(183, 40)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SimpleButton2
        Me.LayoutControlItem8.Location = New System.Drawing.Point(183, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(183, 40)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton3
        Me.LayoutControlItem9.Location = New System.Drawing.Point(366, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(182, 40)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton4
        Me.LayoutControlItem10.Location = New System.Drawing.Point(548, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(183, 40)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton5
        Me.LayoutControlItem11.Location = New System.Drawing.Point(731, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(182, 40)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 351)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1096, 175)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sbtnExportExcel
        Me.LayoutControlItem5.Location = New System.Drawing.Point(913, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(183, 40)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Nothing
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "Key;Kniha;Citatel;Datumpozicania;Datumvratenia"
        Me.XpCollection1.ObjectType = GetType(Kniznica2.Pozicka)
        Me.XpCollection1.Session = Me.UnitOfWork1
        '
        'Knihy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 546)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "Knihy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Knihy"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKey1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nazov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAutor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPozicana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colPocet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents XpCollection2 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork2 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork1 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XpCollection3 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork3 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumpozicania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumvratenia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbtnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
