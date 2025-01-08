<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xKnihy
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnPozicatKnihu = New System.Windows.Forms.Button()
        Me.btnVratitKnihu = New System.Windows.Forms.Button()
        Me.btnVymazatRiadokKnihy = New System.Windows.Forms.Button()
        Me.btnNovaKniha = New System.Windows.Forms.Button()
        Me.btnUpravitKnihu = New System.Windows.Forms.Button()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork2 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPozicana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPocet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnPozicatKnihu)
        Me.LayoutControl1.Controls.Add(Me.btnVratitKnihu)
        Me.LayoutControl1.Controls.Add(Me.btnVymazatRiadokKnihy)
        Me.LayoutControl1.Controls.Add(Me.btnNovaKniha)
        Me.LayoutControl1.Controls.Add(Me.btnUpravitKnihu)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3014, 575, 715, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1039, 429)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnPozicatKnihu
        '
        Me.btnPozicatKnihu.BackColor = System.Drawing.Color.LightGreen
        Me.btnPozicatKnihu.Location = New System.Drawing.Point(624, 12)
        Me.btnPozicatKnihu.Name = "btnPozicatKnihu"
        Me.btnPozicatKnihu.Size = New System.Drawing.Size(199, 45)
        Me.btnPozicatKnihu.TabIndex = 33
        Me.btnPozicatKnihu.Text = "Pozicat knihu"
        Me.btnPozicatKnihu.UseVisualStyleBackColor = False
        '
        'btnVratitKnihu
        '
        Me.btnVratitKnihu.BackColor = System.Drawing.Color.Orange
        Me.btnVratitKnihu.Location = New System.Drawing.Point(827, 12)
        Me.btnVratitKnihu.Name = "btnVratitKnihu"
        Me.btnVratitKnihu.Size = New System.Drawing.Size(200, 45)
        Me.btnVratitKnihu.TabIndex = 34
        Me.btnVratitKnihu.Text = "Vratit knihu"
        Me.btnVratitKnihu.UseVisualStyleBackColor = False
        '
        'btnVymazatRiadokKnihy
        '
        Me.btnVymazatRiadokKnihy.BackColor = System.Drawing.Color.RosyBrown
        Me.btnVymazatRiadokKnihy.Location = New System.Drawing.Point(420, 12)
        Me.btnVymazatRiadokKnihy.Name = "btnVymazatRiadokKnihy"
        Me.btnVymazatRiadokKnihy.Size = New System.Drawing.Size(200, 45)
        Me.btnVymazatRiadokKnihy.TabIndex = 32
        Me.btnVymazatRiadokKnihy.Text = "Vymazat"
        Me.btnVymazatRiadokKnihy.UseVisualStyleBackColor = False
        '
        'btnNovaKniha
        '
        Me.btnNovaKniha.BackColor = System.Drawing.SystemColors.Info
        Me.btnNovaKniha.Location = New System.Drawing.Point(12, 12)
        Me.btnNovaKniha.Name = "btnNovaKniha"
        Me.btnNovaKniha.Size = New System.Drawing.Size(200, 45)
        Me.btnNovaKniha.TabIndex = 31
        Me.btnNovaKniha.Text = "Nova Kniha"
        Me.btnNovaKniha.UseVisualStyleBackColor = False
        '
        'btnUpravitKnihu
        '
        Me.btnUpravitKnihu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpravitKnihu.Location = New System.Drawing.Point(216, 12)
        Me.btnUpravitKnihu.Name = "btnUpravitKnihu"
        Me.btnUpravitKnihu.Size = New System.Drawing.Size(200, 45)
        Me.btnUpravitKnihu.TabIndex = 30
        Me.btnUpravitKnihu.Text = "Upravit"
        Me.btnUpravitKnihu.UseVisualStyleBackColor = False
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.XpCollection2
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.GridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GridControl2.Location = New System.Drawing.Point(12, 61)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1015, 356)
        Me.GridControl2.TabIndex = 25
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'XpCollection2
        '
        Me.XpCollection2.DisplayableProperties = "Key;Id;Pocet;Nazov;Autor;Pozicana"
        Me.XpCollection2.ObjectType = GetType(Kniznica2.Knihy)
        Me.XpCollection2.Session = Me.UnitOfWork2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey1, Me.colId, Me.colNazov, Me.colAutor, Me.colPozicana, Me.colPocet})
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
        'colNazov
        '
        Me.colNazov.FieldName = "Nazov"
        Me.colNazov.Name = "colNazov"
        Me.colNazov.Visible = True
        Me.colNazov.VisibleIndex = 2
        Me.colNazov.Width = 217
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
        Me.colPocet.FieldName = "Pocet"
        Me.colPocet.Name = "colPocet"
        Me.colPocet.Visible = True
        Me.colPocet.VisibleIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1039, 429)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnPozicatKnihu
        Me.LayoutControlItem2.Location = New System.Drawing.Point(612, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(203, 49)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnVratitKnihu
        Me.LayoutControlItem3.Location = New System.Drawing.Point(815, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(204, 49)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl2
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1019, 360)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnNovaKniha
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(204, 49)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnUpravitKnihu
        Me.LayoutControlItem6.Location = New System.Drawing.Point(204, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(204, 49)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnVymazatRiadokKnihy
        Me.LayoutControlItem4.Location = New System.Drawing.Point(408, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(204, 49)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'xKnihy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 429)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xKnihy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "xKnihy"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKey1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAutor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPozicana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnPozicatKnihu As Button
    Friend WithEvents btnVratitKnihu As Button
    Friend WithEvents btnVymazatRiadokKnihy As Button
    Friend WithEvents btnNovaKniha As Button
    Friend WithEvents btnUpravitKnihu As Button
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCollection2 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork2 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents colPocet As DevExpress.XtraGrid.Columns.GridColumn
End Class
