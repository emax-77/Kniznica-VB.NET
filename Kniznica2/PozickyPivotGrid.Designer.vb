<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PozickyPivotGrid
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
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding7 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding8 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UnitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.fieldDatumpozicania = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDatumvratenia = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ChartControl1)
        Me.LayoutControl1.Controls.Add(Me.PivotGridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1223, 597)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ChartControl1
        '
        Me.ChartControl1.DataSource = Me.PivotGridControl1
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
        Me.ChartControl1.Location = New System.Drawing.Point(12, 300)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ChartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Me.ChartControl1.SeriesTemplate.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.Size = New System.Drawing.Size(1199, 285)
        Me.ChartControl1.TabIndex = 5
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.XpCollection1
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldDatumpozicania, Me.fieldDatumvratenia, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField1, Me.PivotGridField5, Me.PivotGridField6})
        Me.PivotGridControl1.Location = New System.Drawing.Point(12, 12)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(1199, 284)
        Me.PivotGridControl1.TabIndex = 4
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "Key;Kniha;Citatel;Datumpozicania;Datumvratenia"
        Me.XpCollection1.ObjectType = GetType(Kniznica2.Pozicka)
        Me.XpCollection1.Session = Me.UnitOfWork1
        '
        'fieldDatumpozicania
        '
        Me.fieldDatumpozicania.AreaIndex = 0
        Me.fieldDatumpozicania.Caption = "Datumpozicania"
        DataSourceColumnBinding1.ColumnName = "Datumpozicania"
        DataSourceColumnBinding1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
        Me.fieldDatumpozicania.DataBinding = DataSourceColumnBinding1
        Me.fieldDatumpozicania.Name = "fieldDatumpozicania"
        '
        'fieldDatumvratenia
        '
        Me.fieldDatumvratenia.AreaIndex = 1
        Me.fieldDatumvratenia.Caption = "Datumvratenia"
        DataSourceColumnBinding2.ColumnName = "Datumvratenia"
        DataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
        Me.fieldDatumvratenia.DataBinding = DataSourceColumnBinding2
        Me.fieldDatumvratenia.Name = "fieldDatumvratenia"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField2.AreaIndex = 0
        DataSourceColumnBinding3.ColumnName = "Kniha.Nazov"
        Me.PivotGridField2.DataBinding = DataSourceColumnBinding3
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField3.AreaIndex = 1
        DataSourceColumnBinding4.ColumnName = "Citatel.Priezvisko"
        Me.PivotGridField3.DataBinding = DataSourceColumnBinding4
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField4.AreaIndex = 2
        DataSourceColumnBinding5.ColumnName = "Citatel.Meno"
        Me.PivotGridField4.DataBinding = DataSourceColumnBinding5
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField1.AreaIndex = 3
        DataSourceColumnBinding6.ColumnName = "Kniha.Autor"
        Me.PivotGridField1.DataBinding = DataSourceColumnBinding6
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField5.AreaIndex = 4
        DataSourceColumnBinding7.ColumnName = "Kniha.Pocet"
        Me.PivotGridField5.DataBinding = DataSourceColumnBinding7
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField6.AreaIndex = 5
        DataSourceColumnBinding8.ColumnName = "Kniha.PocetPozicanych"
        Me.PivotGridField6.DataBinding = DataSourceColumnBinding8
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1223, 597)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PivotGridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1203, 288)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ChartControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 288)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1203, 289)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'PozickyPivotGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 597)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "PozickyPivotGrid"
        Me.Text = "PozickyPivotGrid"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork1 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents fieldDatumpozicania As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDatumvratenia As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
