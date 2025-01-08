<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xCitatelia
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork2 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObciansky = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriezvisko = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumnarodenia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnVymazatRiadokCitatelia = New System.Windows.Forms.Button()
        Me.btnNovyRiadokCitatelia = New System.Windows.Forms.Button()
        Me.btnUpravitCitatela = New System.Windows.Forms.Button()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UnitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.btnVymazatRiadokCitatelia)
        Me.LayoutControl1.Controls.Add(Me.btnNovyRiadokCitatelia)
        Me.LayoutControl1.Controls.Add(Me.btnUpravitCitatela)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3162, 173, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1333, 632)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection2
        Me.GridControl1.Location = New System.Drawing.Point(12, 76)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1309, 544)
        Me.GridControl1.TabIndex = 30
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'XpCollection2
        '
        Me.XpCollection2.DisplayableProperties = "Key;Obciansky;Meno;Priezvisko;Datumnarodenia"
        Me.XpCollection2.ObjectType = GetType(Kniznica2.Citatelia)
        Me.XpCollection2.Session = Me.UnitOfWork2
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey, Me.colObciansky, Me.colMeno, Me.colPriezvisko, Me.colDatumnarodenia})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMeno, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colKey
        '
        Me.colKey.FieldName = "Key"
        Me.colKey.Name = "colKey"
        '
        'colObciansky
        '
        Me.colObciansky.FieldName = "Obciansky"
        Me.colObciansky.Name = "colObciansky"
        Me.colObciansky.Visible = True
        Me.colObciansky.VisibleIndex = 3
        '
        'colMeno
        '
        Me.colMeno.FieldName = "Meno"
        Me.colMeno.Name = "colMeno"
        Me.colMeno.Visible = True
        Me.colMeno.VisibleIndex = 1
        '
        'colPriezvisko
        '
        Me.colPriezvisko.FieldName = "Priezvisko"
        Me.colPriezvisko.Name = "colPriezvisko"
        Me.colPriezvisko.Visible = True
        Me.colPriezvisko.VisibleIndex = 0
        '
        'colDatumnarodenia
        '
        Me.colDatumnarodenia.FieldName = "Datumnarodenia"
        Me.colDatumnarodenia.Name = "colDatumnarodenia"
        Me.colDatumnarodenia.Visible = True
        Me.colDatumnarodenia.VisibleIndex = 2
        '
        'btnVymazatRiadokCitatelia
        '
        Me.btnVymazatRiadokCitatelia.BackColor = System.Drawing.Color.RosyBrown
        Me.btnVymazatRiadokCitatelia.Location = New System.Drawing.Point(885, 12)
        Me.btnVymazatRiadokCitatelia.Name = "btnVymazatRiadokCitatelia"
        Me.btnVymazatRiadokCitatelia.Size = New System.Drawing.Size(436, 60)
        Me.btnVymazatRiadokCitatelia.TabIndex = 29
        Me.btnVymazatRiadokCitatelia.Text = "Vymazat"
        Me.btnVymazatRiadokCitatelia.UseVisualStyleBackColor = False
        '
        'btnNovyRiadokCitatelia
        '
        Me.btnNovyRiadokCitatelia.BackColor = System.Drawing.SystemColors.Info
        Me.btnNovyRiadokCitatelia.Location = New System.Drawing.Point(12, 12)
        Me.btnNovyRiadokCitatelia.Name = "btnNovyRiadokCitatelia"
        Me.btnNovyRiadokCitatelia.Size = New System.Drawing.Size(433, 60)
        Me.btnNovyRiadokCitatelia.TabIndex = 28
        Me.btnNovyRiadokCitatelia.Text = "Novy "
        Me.btnNovyRiadokCitatelia.UseVisualStyleBackColor = False
        '
        'btnUpravitCitatela
        '
        Me.btnUpravitCitatela.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpravitCitatela.Location = New System.Drawing.Point(449, 12)
        Me.btnUpravitCitatela.Name = "btnUpravitCitatela"
        Me.btnUpravitCitatela.Size = New System.Drawing.Size(432, 60)
        Me.btnUpravitCitatela.TabIndex = 27
        Me.btnUpravitCitatela.Text = "Upravit"
        Me.btnUpravitCitatela.UseVisualStyleBackColor = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1333, 632)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnUpravitCitatela
        Me.LayoutControlItem4.Location = New System.Drawing.Point(437, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(436, 64)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnNovyRiadokCitatelia
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(437, 64)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnVymazatRiadokCitatelia
        Me.LayoutControlItem2.Location = New System.Drawing.Point(873, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(440, 64)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 64)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1313, 548)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "Key;Obciansky;Meno;Priezvisko;Datumnarodenia"
        Me.XpCollection1.ObjectType = GetType(Kniznica2.Citatelia)
        Me.XpCollection1.Session = Me.UnitOfWork1
        '
        'xCitatelia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 632)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xCitatelia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "xCitatelia"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnVymazatRiadokCitatelia As Button
    Friend WithEvents btnNovyRiadokCitatelia As Button
    Friend WithEvents btnUpravitCitatela As Button
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork1 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XpCollection2 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork2 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObciansky As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriezvisko As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumnarodenia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
