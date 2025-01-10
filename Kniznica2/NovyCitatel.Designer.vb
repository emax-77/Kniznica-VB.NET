<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovyCitatel
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
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovyCitatel))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.tedMeno = New DevExpress.XtraEditors.TextEdit()
        Me.tedPriezvysko = New DevExpress.XtraEditors.TextEdit()
        Me.dedDatumNarodenia = New DevExpress.XtraEditors.DateEdit()
        Me.tedObciansky = New DevExpress.XtraEditors.TextEdit()
        Me.btnUlozit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnZrusit = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.tedMeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tedPriezvysko.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedDatumNarodenia.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedDatumNarodenia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tedObciansky.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.tedMeno)
        Me.LayoutControl1.Controls.Add(Me.tedPriezvysko)
        Me.LayoutControl1.Controls.Add(Me.dedDatumNarodenia)
        Me.LayoutControl1.Controls.Add(Me.tedObciansky)
        Me.LayoutControl1.Controls.Add(Me.btnUlozit)
        Me.LayoutControl1.Controls.Add(Me.btnZrusit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3118, 46, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(934, 109)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'tedMeno
        '
        Me.tedMeno.Location = New System.Drawing.Point(114, 12)
        Me.tedMeno.Name = "tedMeno"
        Me.tedMeno.Size = New System.Drawing.Size(352, 20)
        Me.tedMeno.StyleController = Me.LayoutControl1
        Me.tedMeno.TabIndex = 4
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals
        ConditionValidationRule1.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.tedMeno, ConditionValidationRule1)
        '
        'tedPriezvysko
        '
        Me.tedPriezvysko.Location = New System.Drawing.Point(114, 36)
        Me.tedPriezvysko.Name = "tedPriezvysko"
        Me.tedPriezvysko.Size = New System.Drawing.Size(352, 20)
        Me.tedPriezvysko.StyleController = Me.LayoutControl1
        Me.tedPriezvysko.TabIndex = 5
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals
        ConditionValidationRule2.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.tedPriezvysko, ConditionValidationRule2)
        '
        'dedDatumNarodenia
        '
        Me.dedDatumNarodenia.EditValue = Nothing
        Me.dedDatumNarodenia.Location = New System.Drawing.Point(572, 12)
        Me.dedDatumNarodenia.Name = "dedDatumNarodenia"
        Me.dedDatumNarodenia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedDatumNarodenia.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedDatumNarodenia.Size = New System.Drawing.Size(350, 20)
        Me.dedDatumNarodenia.StyleController = Me.LayoutControl1
        Me.dedDatumNarodenia.TabIndex = 6
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.LessOrEqual
        ConditionValidationRule3.ErrorText = "This value is not valid"
        ConditionValidationRule3.Value1 = New Date(2025, 1, 10, 13, 34, 24, 0)
        Me.DxValidationProvider1.SetValidationRule(Me.dedDatumNarodenia, ConditionValidationRule3)
        '
        'tedObciansky
        '
        Me.tedObciansky.Location = New System.Drawing.Point(572, 36)
        Me.tedObciansky.Name = "tedObciansky"
        Me.tedObciansky.Size = New System.Drawing.Size(350, 20)
        Me.tedObciansky.StyleController = Me.LayoutControl1
        Me.tedObciansky.TabIndex = 7
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals
        ConditionValidationRule4.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.tedObciansky, ConditionValidationRule4)
        '
        'btnUlozit
        '
        Me.btnUlozit.ImageOptions.Image = CType(resources.GetObject("btnUlozit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUlozit.Location = New System.Drawing.Point(12, 60)
        Me.btnUlozit.Name = "btnUlozit"
        Me.btnUlozit.Size = New System.Drawing.Size(454, 36)
        Me.btnUlozit.StyleController = Me.LayoutControl1
        Me.btnUlozit.TabIndex = 8
        Me.btnUlozit.Text = "Ulozit"
        '
        'btnZrusit
        '
        Me.btnZrusit.ImageOptions.Image = CType(resources.GetObject("btnZrusit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnZrusit.Location = New System.Drawing.Point(470, 60)
        Me.btnZrusit.Name = "btnZrusit"
        Me.btnZrusit.Size = New System.Drawing.Size(452, 36)
        Me.btnZrusit.StyleController = Me.LayoutControl1
        Me.btnZrusit.TabIndex = 9
        Me.btnZrusit.Text = "Zrusit"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(934, 109)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.tedMeno
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(458, 24)
        Me.LayoutControlItem1.Text = "Meno"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.tedPriezvysko
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(458, 24)
        Me.LayoutControlItem2.Text = "Priezvisko"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnUlozit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(458, 41)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnZrusit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(458, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(456, 41)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dedDatumNarodenia
        Me.LayoutControlItem3.Location = New System.Drawing.Point(458, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(456, 24)
        Me.LayoutControlItem3.Text = "Datum narodenia"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.tedObciansky
        Me.LayoutControlItem4.Location = New System.Drawing.Point(458, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(456, 24)
        Me.LayoutControlItem4.Text = "Obciansky preukaz"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(90, 13)
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'NovyCitatel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 109)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "NovyCitatel"
        Me.Text = "xNovyCitatel"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.tedMeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tedPriezvysko.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedDatumNarodenia.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedDatumNarodenia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tedObciansky.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents tedMeno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tedPriezvysko As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dedDatumNarodenia As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tedObciansky As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnUlozit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnZrusit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
