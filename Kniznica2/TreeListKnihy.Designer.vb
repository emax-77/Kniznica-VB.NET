<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TreeListKnihy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreeListKnihy))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.sbtnExportXML = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.XtraScrollableControl1)
        Me.LayoutControl1.Controls.Add(Me.TreeList1)
        Me.LayoutControl1.Controls.Add(Me.sbtnExportXML)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(837, 401)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(12, 352)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(813, 37)
        Me.XtraScrollableControl1.TabIndex = 6
        '
        'TreeList1
        '
        Me.TreeList1.Location = New System.Drawing.Point(12, 52)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.Size = New System.Drawing.Size(813, 296)
        Me.TreeList1.TabIndex = 4
        '
        'sbtnExportXML
        '
        Me.sbtnExportXML.ImageOptions.Image = CType(resources.GetObject("sbtnExportXML.ImageOptions.Image"), System.Drawing.Image)
        Me.sbtnExportXML.Location = New System.Drawing.Point(12, 12)
        Me.sbtnExportXML.Name = "sbtnExportXML"
        Me.sbtnExportXML.Size = New System.Drawing.Size(813, 36)
        Me.sbtnExportXML.StyleController = Me.LayoutControl1
        Me.sbtnExportXML.TabIndex = 7
        Me.sbtnExportXML.Text = "Export do XML"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(837, 401)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TreeList1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(817, 300)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.XtraScrollableControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 340)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(817, 41)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.sbtnExportXML
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(817, 40)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'TreeListKnihy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 401)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "TreeListKnihy"
        Me.Text = "TreeListKnihy"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbtnExportXML As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
