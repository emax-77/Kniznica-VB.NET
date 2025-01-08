<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PozickaVratenie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PozickaVratenie))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SearchLookUpEdit2 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.XpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork2 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPocet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPozicana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriezvisko = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnPozicat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnZrusit = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SearchLookUpEdit3 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SearchLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.UnitOfWork3 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.XpCollection3 = New DevExpress.Xpo.XPCollection(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEdit3)
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEdit2)
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEdit1)
        Me.LayoutControl1.Controls.Add(Me.btnPozicat)
        Me.LayoutControl1.Controls.Add(Me.btnZrusit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2780, 213, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(972, 85)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SearchLookUpEdit2
        '
        Me.SearchLookUpEdit2.Location = New System.Drawing.Point(529, 12)
        Me.SearchLookUpEdit2.Name = "SearchLookUpEdit2"
        Me.SearchLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit2.Properties.DataSource = Me.XpCollection2
        Me.SearchLookUpEdit2.Properties.DisplayMember = "Nazov"
        Me.SearchLookUpEdit2.Properties.PopupView = Me.SearchLookUpEdit2View
        Me.SearchLookUpEdit2.Size = New System.Drawing.Size(414, 20)
        Me.SearchLookUpEdit2.StyleController = Me.LayoutControl1
        Me.SearchLookUpEdit2.TabIndex = 5
        '
        'XpCollection2
        '
        Me.XpCollection2.DisplayableProperties = "Key;Id;Pocet;Nazov;Autor;Pozicana"
        Me.XpCollection2.ObjectType = GetType(Kniznica2.Knihy)
        Me.XpCollection2.Session = Me.UnitOfWork2
        Me.XpCollection2.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[Nazov]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey1, Me.colNazov, Me.colAutor, Me.colPocet, Me.colPozicana})
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colKey1
        '
        Me.colKey1.FieldName = "Key"
        Me.colKey1.Name = "colKey1"
        '
        'colNazov
        '
        Me.colNazov.FieldName = "Nazov"
        Me.colNazov.Name = "colNazov"
        Me.colNazov.Visible = True
        Me.colNazov.VisibleIndex = 0
        Me.colNazov.Width = 240
        '
        'colAutor
        '
        Me.colAutor.FieldName = "Autor"
        Me.colAutor.Name = "colAutor"
        Me.colAutor.Visible = True
        Me.colAutor.VisibleIndex = 1
        Me.colAutor.Width = 250
        '
        'colPocet
        '
        Me.colPocet.FieldName = "Pocet"
        Me.colPocet.Name = "colPocet"
        Me.colPocet.Visible = True
        Me.colPocet.VisibleIndex = 2
        Me.colPocet.Width = 113
        '
        'colPozicana
        '
        Me.colPozicana.FieldName = "Pozicana"
        Me.colPozicana.Name = "colPozicana"
        Me.colPozicana.Visible = True
        Me.colPozicana.VisibleIndex = 3
        Me.colPozicana.Width = 82
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(62, 12)
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.DataSource = Me.XpCollection1
        Me.SearchLookUpEdit1.Properties.DisplayMember = "Priezvisko"
        Me.SearchLookUpEdit1.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(413, 20)
        Me.SearchLookUpEdit1.StyleController = Me.LayoutControl1
        Me.SearchLookUpEdit1.TabIndex = 4
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "Key;Obciansky;Meno;Priezvisko;Datumnarodenia"
        Me.XpCollection1.ObjectType = GetType(Kniznica2.Citatelia)
        Me.XpCollection1.Session = Me.UnitOfWork1
        Me.XpCollection1.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[Priezvisko]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey, Me.colPriezvisko, Me.colMeno})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colKey
        '
        Me.colKey.FieldName = "Key"
        Me.colKey.Name = "colKey"
        '
        'colPriezvisko
        '
        Me.colPriezvisko.FieldName = "Priezvisko"
        Me.colPriezvisko.Name = "colPriezvisko"
        Me.colPriezvisko.Visible = True
        Me.colPriezvisko.VisibleIndex = 0
        '
        'colMeno
        '
        Me.colMeno.FieldName = "Meno"
        Me.colMeno.Name = "colMeno"
        Me.colMeno.Visible = True
        Me.colMeno.VisibleIndex = 1
        '
        'btnPozicat
        '
        Me.btnPozicat.ImageOptions.Image = CType(resources.GetObject("btnPozicat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPozicat.Location = New System.Drawing.Point(12, 36)
        Me.btnPozicat.Name = "btnPozicat"
        Me.btnPozicat.Size = New System.Drawing.Size(463, 36)
        Me.btnPozicat.StyleController = Me.LayoutControl1
        Me.btnPozicat.TabIndex = 6
        Me.btnPozicat.Text = "Potvrdit"
        '
        'btnZrusit
        '
        Me.btnZrusit.ImageOptions.Image = CType(resources.GetObject("btnZrusit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnZrusit.Location = New System.Drawing.Point(479, 36)
        Me.btnZrusit.Name = "btnZrusit"
        Me.btnZrusit.Size = New System.Drawing.Size(464, 36)
        Me.btnZrusit.StyleController = Me.LayoutControl1
        Me.btnZrusit.TabIndex = 7
        Me.btnZrusit.Text = "Zrusit"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.SplitterItem2, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(955, 118)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SearchLookUpEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(467, 24)
        Me.LayoutControlItem1.Text = "Citatel :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(38, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchLookUpEdit2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(467, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(468, 24)
        Me.LayoutControlItem2.Text = "Kniha :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(38, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnPozicat
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(84, 40)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(467, 40)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'SplitterItem2
        '
        Me.SplitterItem2.AllowHotTrack = True
        Me.SplitterItem2.Location = New System.Drawing.Point(0, 64)
        Me.SplitterItem2.Name = "SplitterItem2"
        Me.SplitterItem2.Size = New System.Drawing.Size(935, 10)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnZrusit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(467, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(73, 40)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(468, 40)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'SearchLookUpEdit3
        '
        Me.SearchLookUpEdit3.Location = New System.Drawing.Point(12, 86)
        Me.SearchLookUpEdit3.Name = "SearchLookUpEdit3"
        Me.SearchLookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit3.Properties.DataSource = Me.XpCollection3
        Me.SearchLookUpEdit3.Properties.PopupView = Me.SearchLookUpEdit3View
        Me.SearchLookUpEdit3.Size = New System.Drawing.Size(931, 20)
        Me.SearchLookUpEdit3.StyleController = Me.LayoutControl1
        Me.SearchLookUpEdit3.TabIndex = 8
        Me.SearchLookUpEdit3.Visible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SearchLookUpEdit3
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(935, 24)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'SearchLookUpEdit3View
        '
        Me.SearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit3View.Name = "SearchLookUpEdit3View"
        Me.SearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'XpCollection3
        '
        Me.XpCollection3.DisplayableProperties = "Key;Kniha;Citatel;Datumpozicania;Datumvratenia"
        Me.XpCollection3.ObjectType = GetType(Kniznica2.Pozicky)
        Me.XpCollection3.Session = Me.UnitOfWork3
        '
        'PozickaVratenie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 85)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "PozickaVratenie"
        Me.Text = "PozickaVratenie"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchLookUpEdit2 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork1 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents btnPozicat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnZrusit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCollection2 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork2 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents colKey1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAutor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPocet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPozicana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriezvisko As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents SearchLookUpEdit3 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents XpCollection3 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork3 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents SearchLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
