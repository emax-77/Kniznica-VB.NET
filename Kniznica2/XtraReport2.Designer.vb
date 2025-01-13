<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport2
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.checkBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XpObjectSource1 = New DevExpress.Xpo.XPObjectSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpObjectSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
        Me.BottomMargin.Name = "BottomMargin"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
        Me.ReportHeader.HeightF = 60.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 28.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        '
        'pageInfo1
        '
        Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.pageInfo1.Name = "pageInfo1"
        Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.pageInfo1.SizeF = New System.Drawing.SizeF(325.0!, 23.0!)
        Me.pageInfo1.StyleName = "PageInfo"
        '
        'pageInfo2
        '
        Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 0!)
        Me.pageInfo2.Name = "pageInfo2"
        Me.pageInfo2.SizeF = New System.Drawing.SizeF(325.0!, 23.0!)
        Me.pageInfo2.StyleName = "PageInfo"
        Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.pageInfo2.TextFormatString = "Page {0} of {1}"
        '
        'label1
        '
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(650.0!, 24.19433!)
        Me.label1.StyleName = "Title"
        Me.label1.Text = "Report Title"
        '
        'table1
        '
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(650.0!, 28.0!)
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14, Me.tableCell15})
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 1.0R
        '
        'tableCell1
        '
        Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StyleName = "DetailCaption1"
        Me.tableCell1.StylePriority.UseBorders = False
        Me.tableCell1.Text = "Key"
        Me.tableCell1.Weight = 0.025705032348632813R
        '
        'tableCell2
        '
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StyleName = "DetailCaption1"
        Me.tableCell2.Text = "Kniha Key"
        Me.tableCell2.Weight = 0.051343782865084134R
        '
        'tableCell3
        '
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StyleName = "DetailCaption1"
        Me.tableCell3.StylePriority.UseTextAlignment = False
        Me.tableCell3.Text = "Kniha Id"
        Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell3.Weight = 0.04340798011192909R
        '
        'tableCell4
        '
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StyleName = "DetailCaption1"
        Me.tableCell4.StylePriority.UseTextAlignment = False
        Me.tableCell4.Text = "Kniha Pocet"
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell4.Weight = 0.058800248366135816R
        '
        'tableCell5
        '
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StyleName = "DetailCaption1"
        Me.tableCell5.Text = "Kniha Nazov"
        Me.tableCell5.Weight = 0.060664361807016225R
        '
        'tableCell6
        '
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StyleName = "DetailCaption1"
        Me.tableCell6.Text = "Kniha Autor"
        Me.tableCell6.Weight = 0.058320905245267431R
        '
        'tableCell7
        '
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StyleName = "DetailCaption1"
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.Text = "Kniha Pozicana"
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell7.Weight = 0.072324300912710332R
        '
        'tableCell8
        '
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StyleName = "DetailCaption1"
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.Text = "Kniha Pocet Pozicanych"
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell8.Weight = 0.10729590782752405R
        '
        'tableCell9
        '
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StyleName = "DetailCaption1"
        Me.tableCell9.Text = "Citatel Key"
        Me.tableCell9.Weight = 0.0536790524996244R
        '
        'tableCell10
        '
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StyleName = "DetailCaption1"
        Me.tableCell10.Text = "Citatel Obciansky"
        Me.tableCell10.Weight = 0.08072714585524339R
        '
        'tableCell11
        '
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.StyleName = "DetailCaption1"
        Me.tableCell11.Text = "Citatel Meno"
        Me.tableCell11.Weight = 0.060193211482121395R
        '
        'tableCell12
        '
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.StyleName = "DetailCaption1"
        Me.tableCell12.Text = "Citatel Priezvisko"
        Me.tableCell12.Weight = 0.079797146136944108R
        '
        'tableCell13
        '
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.StyleName = "DetailCaption1"
        Me.tableCell13.Text = "Citatel Datumnarodenia"
        Me.tableCell13.Weight = 0.10448948786808894R
        '
        'tableCell14
        '
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.StyleName = "DetailCaption1"
        Me.tableCell14.Text = "Datumpozicania"
        Me.tableCell14.Weight = 0.074651371882512016R
        '
        'tableCell15
        '
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.StyleName = "DetailCaption1"
        Me.tableCell15.Text = "Datumvratenia"
        Me.tableCell15.Weight = 0.068600164560171276R
        '
        'table2
        '
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.table2.Name = "table2"
        Me.table2.OddStyleName = "DetailData3_Odd"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell16, Me.tableCell17, Me.tableCell18, Me.tableCell19, Me.tableCell20, Me.tableCell21, Me.tableCell22, Me.tableCell23, Me.tableCell24, Me.tableCell25, Me.tableCell26, Me.tableCell27, Me.tableCell28, Me.tableCell29, Me.tableCell30})
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 11.5R
        '
        'tableCell16
        '
        Me.tableCell16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Key]")})
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.StyleName = "DetailData1"
        Me.tableCell16.StylePriority.UseBorders = False
        Me.tableCell16.Weight = 0.0257050294142503R
        '
        'tableCell17
        '
        Me.tableCell17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kniha.Key]")})
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.StyleName = "DetailData1"
        Me.tableCell17.Weight = 0.051343776996319111R
        '
        'tableCell18
        '
        Me.tableCell18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kniha.Id]")})
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.StyleName = "DetailData1"
        Me.tableCell18.StylePriority.UseTextAlignment = False
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell18.Weight = 0.043407977177546575R
        '
        'tableCell19
        '
        Me.tableCell19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kniha.Pocet]")})
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.StyleName = "DetailData1"
        Me.tableCell19.StylePriority.UseTextAlignment = False
        Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell19.Weight = 0.058800242497370793R
        '
        'tableCell20
        '
        Me.tableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kniha.Nazov]")})
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.StyleName = "DetailData1"
        Me.tableCell20.Weight = 0.0606643559382512R
        '
        'tableCell21
        '
        Me.tableCell21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kniha.Autor]")})
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.StyleName = "DetailData1"
        Me.tableCell21.Weight = 0.0583208993765024R
        '
        'tableCell22
        '
        Me.tableCell22.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox1})
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.StyleName = "DetailData1"
        Me.tableCell22.StylePriority.UseTextAlignment = False
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell22.Weight = 0.072324295043945316R
        '
        'tableCell23
        '
        Me.tableCell23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kniha.PocetPozicanych]")})
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.StyleName = "DetailData1"
        Me.tableCell23.StylePriority.UseTextAlignment = False
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell23.Weight = 0.10729589608999399R
        '
        'tableCell24
        '
        Me.tableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Citatel.Key]")})
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.StyleName = "DetailData1"
        Me.tableCell24.Weight = 0.053679046630859373R
        '
        'tableCell25
        '
        Me.tableCell25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Citatel.Obciansky]")})
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.StyleName = "DetailData1"
        Me.tableCell25.Weight = 0.080727139986478361R
        '
        'tableCell26
        '
        Me.tableCell26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Citatel.Meno]")})
        Me.tableCell26.Name = "tableCell26"
        Me.tableCell26.StyleName = "DetailData1"
        Me.tableCell26.Weight = 0.060193205613356372R
        '
        'tableCell27
        '
        Me.tableCell27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Citatel.Priezvisko]")})
        Me.tableCell27.Name = "tableCell27"
        Me.tableCell27.StyleName = "DetailData1"
        Me.tableCell27.Weight = 0.079797140268179093R
        '
        'tableCell28
        '
        Me.tableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Citatel.Datumnarodenia]")})
        Me.tableCell28.Name = "tableCell28"
        Me.tableCell28.StyleName = "DetailData1"
        Me.tableCell28.Weight = 0.10448947613055889R
        '
        'tableCell29
        '
        Me.tableCell29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Datumpozicania]")})
        Me.tableCell29.Name = "tableCell29"
        Me.tableCell29.StyleName = "DetailData1"
        Me.tableCell29.Weight = 0.074651366013747R
        '
        'tableCell30
        '
        Me.tableCell30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Datumvratenia]")})
        Me.tableCell30.Name = "tableCell30"
        Me.tableCell30.StyleName = "DetailData1"
        Me.tableCell30.Weight = 0.068600135216346156R
        '
        'checkBox1
        '
        Me.checkBox1.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.checkBox1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.checkBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Kniha.Pozicana]")})
        Me.checkBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
        Me.checkBox1.LocationFloat = New DevExpress.Utils.PointFloat(2.083333!, 0!)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.SizeF = New System.Drawing.SizeF(44.92746!, 25.0!)
        '
        'XpObjectSource1
        '
        Me.XpObjectSource1.EntityTypeString = "Kniznica2.Pozicka, Kniznica2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" &
    "ll"
        Me.XpObjectSource1.Name = "XpObjectSource1"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Title.Name = "Title"
        Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        '
        'DetailCaption1
        '
        Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.DetailCaption1.BorderColor = System.Drawing.Color.White
        Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.DetailCaption1.BorderWidth = 2.0!
        Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DetailCaption1.ForeColor = System.Drawing.Color.White
        Me.DetailCaption1.Name = "DetailCaption1"
        Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData1
        '
        Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.DetailData1.BorderWidth = 2.0!
        Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DetailData1.ForeColor = System.Drawing.Color.Black
        Me.DetailData1.Name = "DetailData1"
        Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3_Odd
        '
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1.0!
        Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        '
        'XtraReport2
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.XpObjectSource1})
        Me.DataSource = Me.XpObjectSource1
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.PageInfo})
        Me.Version = "21.2"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpObjectSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents checkBox1 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XpObjectSource1 As DevExpress.Xpo.XPObjectSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
End Class
