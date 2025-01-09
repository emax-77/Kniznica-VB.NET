<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovaKniha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovaKniha))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.tedNazovKnihy = New DevExpress.XtraEditors.TextEdit()
        Me.tedAutor = New DevExpress.XtraEditors.TextEdit()
        Me.btnUlozit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnZrusit = New DevExpress.XtraEditors.SimpleButton()
        Me.tedIdKnihy = New DevExpress.XtraEditors.TextEdit()
        Me.spePocetKusov = New DevExpress.XtraEditors.SpinEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.tedNazovKnihy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tedAutor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tedIdKnihy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spePocetKusov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.tedNazovKnihy)
        Me.LayoutControl1.Controls.Add(Me.tedAutor)
        Me.LayoutControl1.Controls.Add(Me.btnUlozit)
        Me.LayoutControl1.Controls.Add(Me.btnZrusit)
        Me.LayoutControl1.Controls.Add(Me.tedIdKnihy)
        Me.LayoutControl1.Controls.Add(Me.spePocetKusov)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2941, 526, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(952, 110)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'tedNazovKnihy
        '
        Me.tedNazovKnihy.Location = New System.Drawing.Point(83, 36)
        Me.tedNazovKnihy.Name = "tedNazovKnihy"
        Me.tedNazovKnihy.Size = New System.Drawing.Size(391, 20)
        Me.tedNazovKnihy.StyleController = Me.LayoutControl1
        Me.tedNazovKnihy.TabIndex = 5
        '
        'tedAutor
        '
        Me.tedAutor.Location = New System.Drawing.Point(549, 36)
        Me.tedAutor.Name = "tedAutor"
        Me.tedAutor.Size = New System.Drawing.Size(391, 20)
        Me.tedAutor.StyleController = Me.LayoutControl1
        Me.tedAutor.TabIndex = 6
        '
        'btnUlozit
        '
        Me.btnUlozit.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnUlozit.Appearance.Options.UseForeColor = True
        Me.btnUlozit.ImageOptions.Image = CType(resources.GetObject("btnUlozit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUlozit.Location = New System.Drawing.Point(12, 60)
        Me.btnUlozit.Name = "btnUlozit"
        Me.btnUlozit.Size = New System.Drawing.Size(462, 38)
        Me.btnUlozit.StyleController = Me.LayoutControl1
        Me.btnUlozit.TabIndex = 8
        Me.btnUlozit.Text = "Ulozit"
        '
        'btnZrusit
        '
        Me.btnZrusit.ImageOptions.Image = CType(resources.GetObject("btnZrusit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnZrusit.Location = New System.Drawing.Point(478, 60)
        Me.btnZrusit.Name = "btnZrusit"
        Me.btnZrusit.Size = New System.Drawing.Size(462, 38)
        Me.btnZrusit.StyleController = Me.LayoutControl1
        Me.btnZrusit.TabIndex = 9
        Me.btnZrusit.Text = "Zrusit"
        '
        'tedIdKnihy
        '
        Me.tedIdKnihy.Enabled = False
        Me.tedIdKnihy.Location = New System.Drawing.Point(83, 12)
        Me.tedIdKnihy.Name = "tedIdKnihy"
        Me.tedIdKnihy.Size = New System.Drawing.Size(141, 20)
        Me.tedIdKnihy.StyleController = Me.LayoutControl1
        Me.tedIdKnihy.TabIndex = 13
        '
        'spePocetKusov
        '
        Me.spePocetKusov.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spePocetKusov.Location = New System.Drawing.Point(299, 12)
        Me.spePocetKusov.Name = "spePocetKusov"
        Me.spePocetKusov.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spePocetKusov.Size = New System.Drawing.Size(175, 20)
        Me.spePocetKusov.StyleController = Me.LayoutControl1
        Me.spePocetKusov.TabIndex = 14
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(952, 110)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.tedNazovKnihy
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(466, 24)
        Me.LayoutControlItem2.Text = "Nazov Knihy"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.tedAutor
        Me.LayoutControlItem3.Location = New System.Drawing.Point(466, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(466, 24)
        Me.LayoutControlItem3.Text = "Autor"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.tedIdKnihy
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(216, 24)
        Me.LayoutControlItem1.Text = "ID knihy"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.spePocetKusov
        Me.LayoutControlItem4.Location = New System.Drawing.Point(216, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem4.Text = "Pocet kusov"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnZrusit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(466, 48)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(73, 40)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(466, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(466, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(466, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnUlozit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(72, 40)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(466, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 122)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(932, 167)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(0, 123)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(932, 166)
        '
        'xNovaKniha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 110)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xNovaKniha"
        Me.Text = "xNovaKniha"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.tedNazovKnihy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tedAutor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tedIdKnihy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spePocetKusov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents tedNazovKnihy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tedAutor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnUlozit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tedIdKnihy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents spePocetKusov As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents btnZrusit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
