<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObciansky = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriezvisko = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumnarodenia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork2 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPozicana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnUlozitCitatelia = New System.Windows.Forms.Button()
        Me.btnNovyRiadokCitatelia = New System.Windows.Forms.Button()
        Me.btnUlozitKnihy = New System.Windows.Forms.Button()
        Me.btnNovyRiadokKnihy = New System.Windows.Forms.Button()
        Me.btnVymazatRiadokCitatelia = New System.Windows.Forms.Button()
        Me.btnVymazatRiadokKnihy = New System.Windows.Forms.Button()
        Me.btnPozicatKnihu = New System.Windows.Forms.Button()
        Me.btnVratitKnihu = New System.Windows.Forms.Button()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection3 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork3 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKey2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumpozicania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumvratenia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbxPozicaneKnihy = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Location = New System.Drawing.Point(12, 43)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(584, 321)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "Key;Obciansky;Meno;Priezvisko;Datumnarodenia"
        Me.XpCollection1.ObjectType = GetType(Kniznica2.Citatelia)
        Me.XpCollection1.Session = Me.UnitOfWork1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey, Me.colObciansky, Me.colMeno, Me.colPriezvisko, Me.colDatumnarodenia})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colKey
        '
        Me.colKey.FieldName = "Key"
        Me.colKey.Name = "colKey"
        Me.colKey.Visible = True
        Me.colKey.VisibleIndex = 4
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
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.XpCollection2
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl2.Location = New System.Drawing.Point(631, 43)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(584, 321)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'XpCollection2
        '
        Me.XpCollection2.DisplayableProperties = "Key;Id;Nazov;Autor;Pozicana"
        Me.XpCollection2.ObjectType = GetType(Kniznica2.Knihy)
        Me.XpCollection2.Session = Me.UnitOfWork2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKey1, Me.colId, Me.colNazov, Me.colAutor, Me.colPozicana})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colKey1
        '
        Me.colKey1.FieldName = "Key"
        Me.colKey1.Name = "colKey1"
        Me.colKey1.Visible = True
        Me.colKey1.VisibleIndex = 4
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colNazov
        '
        Me.colNazov.FieldName = "Nazov"
        Me.colNazov.Name = "colNazov"
        Me.colNazov.Visible = True
        Me.colNazov.VisibleIndex = 1
        '
        'colAutor
        '
        Me.colAutor.FieldName = "Autor"
        Me.colAutor.Name = "colAutor"
        Me.colAutor.Visible = True
        Me.colAutor.VisibleIndex = 2
        '
        'colPozicana
        '
        Me.colPozicana.FieldName = "Pozicana"
        Me.colPozicana.Name = "colPozicana"
        Me.colPozicana.Visible = True
        Me.colPozicana.VisibleIndex = 3
        '
        'btnUlozitCitatelia
        '
        Me.btnUlozitCitatelia.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUlozitCitatelia.Location = New System.Drawing.Point(97, 43)
        Me.btnUlozitCitatelia.Name = "btnUlozitCitatelia"
        Me.btnUlozitCitatelia.Size = New System.Drawing.Size(104, 33)
        Me.btnUlozitCitatelia.TabIndex = 8
        Me.btnUlozitCitatelia.Text = "Ulozit"
        Me.btnUlozitCitatelia.UseVisualStyleBackColor = False
        '
        'btnNovyRiadokCitatelia
        '
        Me.btnNovyRiadokCitatelia.BackColor = System.Drawing.SystemColors.Info
        Me.btnNovyRiadokCitatelia.Location = New System.Drawing.Point(10, 43)
        Me.btnNovyRiadokCitatelia.Name = "btnNovyRiadokCitatelia"
        Me.btnNovyRiadokCitatelia.Size = New System.Drawing.Size(91, 32)
        Me.btnNovyRiadokCitatelia.TabIndex = 9
        Me.btnNovyRiadokCitatelia.Text = "Novy "
        Me.btnNovyRiadokCitatelia.UseVisualStyleBackColor = False
        '
        'btnUlozitKnihy
        '
        Me.btnUlozitKnihy.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUlozitKnihy.Location = New System.Drawing.Point(706, 43)
        Me.btnUlozitKnihy.Name = "btnUlozitKnihy"
        Me.btnUlozitKnihy.Size = New System.Drawing.Size(79, 33)
        Me.btnUlozitKnihy.TabIndex = 10
        Me.btnUlozitKnihy.Text = "Ulozit"
        Me.btnUlozitKnihy.UseVisualStyleBackColor = False
        '
        'btnNovyRiadokKnihy
        '
        Me.btnNovyRiadokKnihy.BackColor = System.Drawing.SystemColors.Info
        Me.btnNovyRiadokKnihy.Location = New System.Drawing.Point(629, 43)
        Me.btnNovyRiadokKnihy.Name = "btnNovyRiadokKnihy"
        Me.btnNovyRiadokKnihy.Size = New System.Drawing.Size(79, 33)
        Me.btnNovyRiadokKnihy.TabIndex = 11
        Me.btnNovyRiadokKnihy.Text = "Novy"
        Me.btnNovyRiadokKnihy.UseVisualStyleBackColor = False
        '
        'btnVymazatRiadokCitatelia
        '
        Me.btnVymazatRiadokCitatelia.BackColor = System.Drawing.Color.RosyBrown
        Me.btnVymazatRiadokCitatelia.Location = New System.Drawing.Point(187, 43)
        Me.btnVymazatRiadokCitatelia.Name = "btnVymazatRiadokCitatelia"
        Me.btnVymazatRiadokCitatelia.Size = New System.Drawing.Size(103, 33)
        Me.btnVymazatRiadokCitatelia.TabIndex = 12
        Me.btnVymazatRiadokCitatelia.Text = "Vymazat"
        Me.btnVymazatRiadokCitatelia.UseVisualStyleBackColor = False
        '
        'btnVymazatRiadokKnihy
        '
        Me.btnVymazatRiadokKnihy.BackColor = System.Drawing.Color.RosyBrown
        Me.btnVymazatRiadokKnihy.Location = New System.Drawing.Point(782, 43)
        Me.btnVymazatRiadokKnihy.Name = "btnVymazatRiadokKnihy"
        Me.btnVymazatRiadokKnihy.Size = New System.Drawing.Size(74, 33)
        Me.btnVymazatRiadokKnihy.TabIndex = 13
        Me.btnVymazatRiadokKnihy.Text = "Vymazat"
        Me.btnVymazatRiadokKnihy.UseVisualStyleBackColor = False
        '
        'btnPozicatKnihu
        '
        Me.btnPozicatKnihu.BackColor = System.Drawing.Color.LightGreen
        Me.btnPozicatKnihu.Location = New System.Drawing.Point(852, 43)
        Me.btnPozicatKnihu.Name = "btnPozicatKnihu"
        Me.btnPozicatKnihu.Size = New System.Drawing.Size(90, 33)
        Me.btnPozicatKnihu.TabIndex = 14
        Me.btnPozicatKnihu.Text = "Pozicat knihu"
        Me.btnPozicatKnihu.UseVisualStyleBackColor = False
        '
        'btnVratitKnihu
        '
        Me.btnVratitKnihu.BackColor = System.Drawing.Color.Orange
        Me.btnVratitKnihu.Location = New System.Drawing.Point(938, 43)
        Me.btnVratitKnihu.Name = "btnVratitKnihu"
        Me.btnVratitKnihu.Size = New System.Drawing.Size(90, 33)
        Me.btnVratitKnihu.TabIndex = 15
        Me.btnVratitKnihu.Text = "Vratit knihu"
        Me.btnVratitKnihu.UseVisualStyleBackColor = False
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.XpCollection3
        GridLevelNode2.RelationName = "Level1"
        Me.GridControl3.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridControl3.Location = New System.Drawing.Point(632, 436)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(583, 282)
        Me.GridControl3.TabIndex = 16
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
        Me.colKey2.Visible = True
        Me.colKey2.VisibleIndex = 4
        '
        'colDatumpozicania
        '
        Me.colDatumpozicania.FieldName = "Datumpozicania"
        Me.colDatumpozicania.Name = "colDatumpozicania"
        Me.colDatumpozicania.Visible = True
        Me.colDatumpozicania.VisibleIndex = 2
        '
        'colDatumvratenia
        '
        Me.colDatumvratenia.FieldName = "Datumvratenia"
        Me.colDatumvratenia.Name = "colDatumvratenia"
        Me.colDatumvratenia.Visible = True
        Me.colDatumvratenia.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "Citatel.Priezvisko"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "Kniha.Nazov"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'lbxPozicaneKnihy
        '
        Me.lbxPozicaneKnihy.FormattingEnabled = True
        Me.lbxPozicaneKnihy.Location = New System.Drawing.Point(12, 436)
        Me.lbxPozicaneKnihy.Name = "lbxPozicaneKnihy"
        Me.lbxPozicaneKnihy.Size = New System.Drawing.Size(255, 121)
        Me.lbxPozicaneKnihy.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Citatel ma pozicane :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Citatelia :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(647, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Knihy :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(647, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Pozicky :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 761)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxPozicaneKnihy)
        Me.Controls.Add(Me.GridControl3)
        Me.Controls.Add(Me.btnVratitKnihu)
        Me.Controls.Add(Me.btnPozicatKnihu)
        Me.Controls.Add(Me.btnVymazatRiadokKnihy)
        Me.Controls.Add(Me.btnVymazatRiadokCitatelia)
        Me.Controls.Add(Me.btnNovyRiadokKnihy)
        Me.Controls.Add(Me.btnUlozitKnihy)
        Me.Controls.Add(Me.btnNovyRiadokCitatelia)
        Me.Controls.Add(Me.btnUlozitCitatelia)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObciansky As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriezvisko As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumnarodenia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork1 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents btnUlozitCitatelia As Button
    Friend WithEvents XpCollection2 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork2 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents colKey1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAutor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPozicana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNovyRiadokCitatelia As Button
    Friend WithEvents btnUlozitKnihy As Button
    Friend WithEvents btnNovyRiadokKnihy As Button
    Friend WithEvents btnVymazatRiadokCitatelia As Button
    Friend WithEvents btnVymazatRiadokKnihy As Button
    Friend WithEvents btnPozicatKnihu As Button
    Friend WithEvents btnVratitKnihu As Button
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XpCollection3 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork3 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents colKey2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumpozicania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumvratenia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbxPozicaneKnihy As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
