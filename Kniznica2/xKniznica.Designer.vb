﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xKniznica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xKniznica))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Tools"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 1
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Citatelia"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Knihy"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Pozicky"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1918, 46)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1027)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1918, 21)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 46)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 981)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1918, 46)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 981)
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "BarSubItem2"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "BarSubItem3"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "NavBarGroup1"
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup2
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup2})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 46)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 140
        Me.NavBarControl1.Size = New System.Drawing.Size(140, 981)
        Me.NavBarControl1.TabIndex = 11
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Kniznica"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "Citatelia"
        Me.NavBarItem1.ImageOptions.LargeImage = CType(resources.GetObject("NavBarItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NavBarItem1.ImageOptions.SmallImage = CType(resources.GetObject("NavBarItem1.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Knihy"
        Me.NavBarItem2.ImageOptions.LargeImage = CType(resources.GetObject("NavBarItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NavBarItem2.ImageOptions.SmallImage = CType(resources.GetObject("NavBarItem2.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "Pozicky"
        Me.NavBarItem3.ImageOptions.LargeImage = CType(resources.GetObject("NavBarItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NavBarItem3.ImageOptions.SmallImage = CType(resources.GetObject("NavBarItem3.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBarItem3.Name = "NavBarItem3"
        '
        'xKniznica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1918, 1048)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.LargeImage = CType(resources.GetObject("xKniznica.IconOptions.LargeImage"), System.Drawing.Image)
        Me.IsMdiContainer = True
        Me.Name = "xKniznica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "xKniznica"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
End Class
