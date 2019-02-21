Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UserDesigner

Public Class rptSNs
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents EfDataSource1 As DevExpress.DataAccess.EntityFramework.EFDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaption3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaptionBackground3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents RESVFORORD As Parameter
    Friend WithEvents ITEMNUM As Parameter
    Friend WithEvents SERIALNUMF As Parameter
    Friend WithEvents LOCATION As Parameter
    Friend WithEvents PO_TRANDATE_FILTER As Parameter
    Friend WithEvents PO_TRANSDATE As Parameter
    Friend WithEvents C100FREQUENCY As Parameter
    Friend WithEvents C030ALTSN As Parameter
    Friend WithEvents C110VOLTAGE As Parameter
    Friend WithEvents C200CTRLPANEL As Parameter
    Friend WithEvents C250STONEGUAR As Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EfConnectionParameters1 As DevExpress.DataAccess.EntityFramework.EFConnectionParameters = New DevExpress.DataAccess.EntityFramework.EFConnectionParameters()
        Dim StaticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
        Dim StaticListLookUpSettings2 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSNs))
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.EfDataSource1 = New DevExpress.DataAccess.EntityFramework.EFDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.RESVFORORD = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ITEMNUM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SERIALNUMF = New DevExpress.XtraReports.Parameters.Parameter()
        Me.LOCATION = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PO_TRANDATE_FILTER = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PO_TRANSDATE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.C100FREQUENCY = New DevExpress.XtraReports.Parameters.Parameter()
        Me.C030ALTSN = New DevExpress.XtraReports.Parameters.Parameter()
        Me.C110VOLTAGE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.C200CTRLPANEL = New DevExpress.XtraReports.Parameters.Parameter()
        Me.C250STONEGUAR = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.EfDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 23.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.BottomMarginBand1.HeightF = 43.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.999998!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(513.0!, 23.0!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        Me.XrPageInfo1.TextFormatString = "{0:MM/dd/yy hh:mm tt}"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(566.9999!, 5.999998!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(511.9999!, 23.0!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrPageInfo2.TextFormatString = "Page {0} of {1}"
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.ReportHeaderBand1.HeightF = 60.0!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.999998!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1050.384!, 54.0!)
        Me.XrLabel1.StyleName = "Title"
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Simply Reliable Power Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Genset Availibility by Item Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Product Line = GE" &
    "NSET"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.GroupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeaderBand1.HeightF = 48.0!
        Me.GroupHeaderBand1.Level = 2
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        Me.GroupHeaderBand1.RepeatEveryPage = True
        '
        'XrPanel1
        '
        Me.XrPanel1.BorderWidth = 2.0!
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel40, Me.XrLabel32, Me.XrLabel31, Me.XrLabel30, Me.XrLabel29, Me.XrLabel28, Me.XrLabel27, Me.XrLabel26, Me.XrLabel25, Me.XrLabel22, Me.XrLabel18, Me.XrLabel16, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(1079.0!, 48.0!)
        Me.XrPanel1.StyleName = "DetailCaptionBackground3"
        Me.XrPanel1.StylePriority.UseBorderWidth = False
        '
        'XrLabel40
        '
        Me.XrLabel40.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel40.BorderColor = System.Drawing.Color.Black
        Me.XrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel40.BorderWidth = 1.0!
        Me.XrLabel40.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(1000.228!, 19.99999!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(50.15604!, 28.0!)
        Me.XrLabel40.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel40.StyleName = "DetailCaption3"
        Me.XrLabel40.StylePriority.UseBackColor = False
        Me.XrLabel40.StylePriority.UseBorderColor = False
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseBorderWidth = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseForeColor = False
        Me.XrLabel40.StylePriority.UsePadding = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Cust." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PO Dt."
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel32
        '
        Me.XrLabel32.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel32.BorderColor = System.Drawing.Color.Black
        Me.XrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel32.BorderWidth = 1.0!
        Me.XrLabel32.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(922.5038!, 19.99999!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(75.72418!, 28.0!)
        Me.XrLabel32.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel32.StyleName = "DetailCaption3"
        Me.XrLabel32.StylePriority.UseBackColor = False
        Me.XrLabel32.StylePriority.UseBorderColor = False
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseBorderWidth = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseForeColor = False
        Me.XrLabel32.StylePriority.UsePadding = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Cust." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PO #"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel31.BorderColor = System.Drawing.Color.Black
        Me.XrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel31.BorderWidth = 1.0!
        Me.XrLabel31.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(863.8372!, 19.99999!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(56.66644!, 28.0!)
        Me.XrLabel31.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel31.StyleName = "DetailCaption3"
        Me.XrLabel31.StylePriority.UseBackColor = False
        Me.XrLabel31.StylePriority.UseBorderColor = False
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseBorderWidth = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseForeColor = False
        Me.XrLabel31.StylePriority.UsePadding = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Cust." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Code"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel30
        '
        Me.XrLabel30.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel30.BorderColor = System.Drawing.Color.Black
        Me.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel30.BorderWidth = 1.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(805.1708!, 19.99999!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(56.66644!, 28.0!)
        Me.XrLabel30.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel30.StyleName = "DetailCaption3"
        Me.XrLabel30.StylePriority.UseBackColor = False
        Me.XrLabel30.StylePriority.UseBorderColor = False
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseBorderWidth = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseForeColor = False
        Me.XrLabel30.StylePriority.UsePadding = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S/O #"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel29
        '
        Me.XrLabel29.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel29.BorderColor = System.Drawing.Color.Black
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel29.BorderWidth = 1.0!
        Me.XrLabel29.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel29.InteractiveSorting.TargetBand = Me.DetailBand1
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(746.5043!, 19.99999!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(56.66644!, 28.0!)
        Me.XrLabel29.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel29.StyleName = "DetailCaption3"
        Me.XrLabel29.StylePriority.UseBackColor = False
        Me.XrLabel29.StylePriority.UseBorderColor = False
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseBorderWidth = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseForeColor = False
        Me.XrLabel29.StylePriority.UsePadding = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Location"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'DetailBand1
        '
        Me.DetailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel2})
        Me.DetailBand1.HeightF = 28.42801!
        Me.DetailBand1.Name = "DetailBand1"
        Me.DetailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ITEMNUM", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("C160ENCLTYPE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("st", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending), New DevExpress.XtraReports.UI.GroupField("DATESORT", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
        '
        'XrPanel2
        '
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel46, Me.XrLabel45, Me.XrLabel44, Me.XrLabel43, Me.XrLabel42, Me.XrLabel41, Me.XrLabel11, Me.XrLabel38, Me.XrLabel37, Me.XrLabel36, Me.XrLabel35, Me.XrLabel34, Me.XrLabel33, Me.XrLabel24, Me.XrLabel23, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel17, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel4, Me.XrLabel2, Me.XrLabel3})
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.OddStyleName = "DetailData3_Odd"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(1079.0!, 26.34468!)
        '
        'XrLabel46
        '
        Me.XrLabel46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C600DESPATCH]")})
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(583.5259!, 13.62495!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(278.3113!, 13.62495!)
        Me.XrLabel46.StyleName = "DetailData3"
        Me.XrLabel46.Text = "XrLabel46"
        '
        'XrLabel45
        '
        Me.XrLabel45.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LISTPRICE]")})
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(179.0!, 0!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(61.41669!, 13.62495!)
        Me.XrLabel45.StyleName = "DetailData3"
        Me.XrLabel45.Text = "XrLabel45"
        Me.XrLabel45.TextFormatString = "{0:n2}"
        '
        'XrLabel44
        '
        Me.XrLabel44.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C250STONEGUAR]")})
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(179.0!, 13.62495!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(61.41669!, 13.62495!)
        Me.XrLabel44.StyleName = "DetailData3"
        Me.XrLabel44.Text = "XrLabel44"
        '
        'XrLabel43
        '
        Me.XrLabel43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SO_PONUMBER]")})
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(922.5037!, 0!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(75.7243!, 13.62495!)
        Me.XrLabel43.StyleName = "DetailData3"
        Me.XrLabel43.Text = "XrLabel43"
        '
        'XrLabel42
        '
        Me.XrLabel42.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SO_ORDDATE]")})
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(1000.228!, 0!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(50.15607!, 13.62495!)
        Me.XrLabel42.StyleName = "DetailData3"
        Me.XrLabel42.Text = "XrLabel42"
        Me.XrLabel42.TextFormatString = "{0:MM/dd/yy}"
        '
        'XrLabel41
        '
        Me.XrLabel41.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ARRIVALDATE]")})
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(694.3483!, 0!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(50.15607!, 13.62495!)
        Me.XrLabel41.StyleName = "DetailData3"
        Me.XrLabel41.Text = "XrLabel41"
        Me.XrLabel41.TextFormatString = "{0:MM/dd/yy}"
        '
        'XrLabel11
        '
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C100FREQUENCY]")})
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(242.4167!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(30.16673!, 13.62495!)
        Me.XrLabel11.StyleName = "DetailData3"
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel38
        '
        Me.XrLabel38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SO_CUSTOMER]")})
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(863.8377!, 0!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(56.66638!, 13.62495!)
        Me.XrLabel38.StyleName = "DetailData3"
        Me.XrLabel38.Text = "XrLabel38"
        '
        'XrLabel37
        '
        Me.XrLabel37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SO_ORDNUMBER]")})
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(805.1712!, 0!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(56.66644!, 13.62495!)
        Me.XrLabel37.StyleName = "DetailData3"
        Me.XrLabel37.Text = "XrLabel37"
        '
        'XrLabel36
        '
        Me.XrLabel36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LOCATION]")})
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(746.5048!, 0!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(56.66644!, 13.62495!)
        Me.XrLabel36.StyleName = "DetailData3"
        Me.XrLabel36.Text = "XrLabel36"
        '
        'XrLabel35
        '
        Me.XrLabel35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C410ETAPORT]")})
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(642.1927!, 0!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(50.15607!, 13.62495!)
        Me.XrLabel35.StyleName = "DetailData3"
        Me.XrLabel35.Text = "XrLabel35"
        Me.XrLabel35.TextFormatString = "{0:yy/MM/dd}"
        '
        'XrLabel34
        '
        Me.XrLabel34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C240SILENCER]")})
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(531.3702!, 13.62494!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(50.15607!, 11.74994!)
        Me.XrLabel34.StyleName = "DetailData3"
        Me.XrLabel34.Text = "XrLabel34"
        '
        'XrLabel33
        '
        Me.XrLabel33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PO_INVDATE]")})
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(531.3702!, 0!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(50.15607!, 13.62495!)
        Me.XrLabel33.StyleName = "DetailData3"
        Me.XrLabel33.Text = "XrLabel33"
        Me.XrLabel33.TextFormatString = "{0:MM/dd/yy}"
        '
        'XrLabel24
        '
        Me.XrLabel24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C210LIFTPOINT]")})
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(479.2142!, 13.62494!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(50.15598!, 11.74994!)
        Me.XrLabel24.StyleName = "DetailData3"
        Me.XrLabel24.Text = "XrLabel24"
        '
        'XrLabel23
        '
        Me.XrLabel23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C170PRODPROMI]")})
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(479.2142!, 0!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(50.15604!, 13.62495!)
        Me.XrLabel23.StyleName = "DetailData3"
        Me.XrLabel23.Text = "XrLabel23"
        '
        'XrLabel21
        '
        Me.XrLabel21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C160ENCLTYPE]")})
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(349.3335!, 13.62494!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(75.72418!, 11.74994!)
        Me.XrLabel21.StyleName = "DetailData3"
        Me.XrLabel21.Text = "XrLabel21"
        '
        'XrLabel20
        '
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C230BATTERY]")})
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(427.0581!, 13.62494!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(50.15625!, 11.74994!)
        Me.XrLabel20.StyleName = "DetailData3"
        Me.XrLabel20.Text = "XrLabel20"
        '
        'XrLabel19
        '
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PO_TRANSDATE]")})
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(427.0577!, 0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(50.15628!, 13.62495!)
        Me.XrLabel19.StyleName = "DetailData3"
        Me.XrLabel19.Text = "XrLabel19"
        Me.XrLabel19.TextFormatString = "{0:MM/dd/yy}"
        '
        'XrLabel17
        '
        Me.XrLabel17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PO_PONUMBER]")})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(349.3335!, 0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(75.72418!, 13.62495!)
        Me.XrLabel17.StyleName = "DetailData3"
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel15
        '
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ST]")})
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(326.5418!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(20.79169!, 13.62495!)
        Me.XrLabel15.StyleName = "DetailData3"
        Me.XrLabel15.Text = "XrLabel15"
        '
        'XrLabel14
        '
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C200CTRLPANEL]")})
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(274.5835!, 13.62495!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(49.95831!, 11.74994!)
        Me.XrLabel14.StyleName = "DetailData3"
        Me.XrLabel14.Text = "XrLabel14"
        '
        'XrLabel13
        '
        Me.XrLabel13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C110VOLTAGE]")})
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(274.5835!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(49.95834!, 13.62495!)
        Me.XrLabel13.StyleName = "DetailData3"
        Me.XrLabel13.Text = "XrLabel13"
        '
        'XrLabel12
        '
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C030ALTSN]")})
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(242.4167!, 13.62495!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(30.16672!, 11.74994!)
        Me.XrLabel12.StyleName = "DetailData3"
        Me.XrLabel12.Text = "XrLabel12"
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C010FGWSN]")})
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 13.62495!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(78.12501!, 11.74994!)
        Me.XrLabel4.StyleName = "DetailData3"
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SERIALNUMF]")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(80.12501!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(96.87502!, 13.62495!)
        Me.XrLabel2.StyleName = "DetailData3"
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ITEMNUM]")})
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(78.12501!, 13.62495!)
        Me.XrLabel3.StyleName = "DetailData3"
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel28
        '
        Me.XrLabel28.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel28.BorderColor = System.Drawing.Color.Black
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel28.BorderWidth = 1.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(694.3484!, 19.99999!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(50.15604!, 28.0!)
        Me.XrLabel28.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel28.StyleName = "DetailCaption3"
        Me.XrLabel28.StylePriority.UseBackColor = False
        Me.XrLabel28.StylePriority.UseBorderColor = False
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseBorderWidth = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseForeColor = False
        Me.XrLabel28.StylePriority.UsePadding = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "Arrival" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wareh"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel27.BorderColor = System.Drawing.Color.Black
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel27.BorderWidth = 1.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(642.1922!, 19.99999!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(50.15604!, 28.0!)
        Me.XrLabel27.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel27.StyleName = "DetailCaption3"
        Me.XrLabel27.StylePriority.UseBackColor = False
        Me.XrLabel27.StylePriority.UseBorderColor = False
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseBorderWidth = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseForeColor = False
        Me.XrLabel27.StylePriority.UsePadding = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "ETA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Port"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel26
        '
        Me.XrLabel26.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel26.BorderColor = System.Drawing.Color.Black
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel26.BorderWidth = 1.0!
        Me.XrLabel26.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(583.5258!, 19.99999!)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(56.66644!, 28.0!)
        Me.XrLabel26.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel26.StyleName = "DetailCaption3"
        Me.XrLabel26.StylePriority.UseBackColor = False
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseBorderWidth = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseForeColor = False
        Me.XrLabel26.StylePriority.UsePadding = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "FGW NI " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dsp Note"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel25.BorderColor = System.Drawing.Color.Black
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel25.BorderWidth = 1.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(531.3699!, 19.99999!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(50.15604!, 28.0!)
        Me.XrLabel25.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel25.StyleName = "DetailCaption3"
        Me.XrLabel25.StylePriority.UseBackColor = False
        Me.XrLabel25.StylePriority.UseBorderColor = False
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseBorderWidth = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseForeColor = False
        Me.XrLabel25.StylePriority.UsePadding = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "D. Lrn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Silc"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel22.BorderColor = System.Drawing.Color.Black
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel22.BorderWidth = 1.0!
        Me.XrLabel22.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(479.2137!, 19.99999!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(50.15604!, 28.0!)
        Me.XrLabel22.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel22.StyleName = "DetailCaption3"
        Me.XrLabel22.StylePriority.UseBackColor = False
        Me.XrLabel22.StylePriority.UseBorderColor = False
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseBorderWidth = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseForeColor = False
        Me.XrLabel22.StylePriority.UsePadding = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "P. Prom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LiftPt"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel18.BorderColor = System.Drawing.Color.Black
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel18.BorderWidth = 1.0!
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(427.0577!, 19.99999!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(50.15604!, 28.0!)
        Me.XrLabel18.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel18.StyleName = "DetailCaption3"
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseBorderWidth = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UsePadding = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "PO Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Batt"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel16.BorderColor = System.Drawing.Color.Black
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel16.BorderWidth = 1.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(349.3335!, 20.0!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(75.72418!, 28.0!)
        Me.XrLabel16.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel16.StyleName = "DetailCaption3"
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseBorderWidth = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UsePadding = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "PO #" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Encl"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel10.BorderColor = System.Drawing.Color.Black
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel10.BorderWidth = 1.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(326.5418!, 20.0!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(20.79169!, 28.0!)
        Me.XrLabel10.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel10.StyleName = "DetailCaption3"
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ST"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.BorderColor = System.Drawing.Color.Black
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel9.BorderWidth = 1.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(274.5834!, 20.0!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(49.95837!, 28.0!)
        Me.XrLabel9.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel9.StyleName = "DetailCaption3"
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Voltage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C.Pan"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderColor = System.Drawing.Color.Black
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel8.BorderWidth = 1.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel8.InteractiveSorting.TargetBand = Me.DetailBand1
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(242.4167!, 20.0!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(30.16669!, 28.0!)
        Me.XrLabel8.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel8.StyleName = "DetailCaption3"
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Freq" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alt"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderColor = System.Drawing.Color.Black
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.BorderWidth = 1.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel5.InteractiveSorting.TargetBand = Me.DetailBand1
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.0!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(78.12501!, 28.0!)
        Me.XrLabel5.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel5.StyleName = "DetailCaption3"
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Item" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lane GSN" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Black
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel6.InteractiveSorting.TargetBand = Me.DetailBand1
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(80.12501!, 20.0!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(96.87502!, 28.0!)
        Me.XrLabel6.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel6.StyleName = "DetailCaption3"
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Serial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderColor = System.Drawing.Color.Black
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel7.BorderWidth = 1.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(179.0!, 20.0!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(61.4167!, 28.0!)
        Me.XrLabel7.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrLabel7.StyleName = "DetailCaption3"
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "List Price" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stone G"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel39})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("RESVFORORD_DESC", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 23.0!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrLabel39
        '
        Me.XrLabel39.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RESVFORORD_DESC]")})
        Me.XrLabel39.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(979.0001!, 5.125045!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(99.99994!, 13.62495!)
        Me.XrLabel39.StyleName = "DetailData3"
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "XrLabel39"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupHeader2
        '
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CATSORT", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("WATSORT", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CATEGORY", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 23.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'EfDataSource1
        '
        EfConnectionParameters1.ConnectionString = ""
        EfConnectionParameters1.ConnectionStringName = "CRMXConnectionString"
        EfConnectionParameters1.Source = GetType(IC_Inquiry.CRMXEntities)
        Me.EfDataSource1.ConnectionParameters = EfConnectionParameters1
        Me.EfDataSource1.Name = "EfDataSource1"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Title.Name = "Title"
        '
        'DetailCaption3
        '
        Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailCaption3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.DetailCaption3.Name = "DetailCaption3"
        Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'DetailData3
        '
        Me.DetailData3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailData3.ForeColor = System.Drawing.Color.Black
        Me.DetailData3.Name = "DetailData3"
        Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3_Odd
        '
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1.0!
        Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailCaptionBackground3
        '
        Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.DetailCaptionBackground3.BorderWidth = 2.0!
        Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'RESVFORORD
        '
        Me.RESVFORORD.Description = "Res. For OE"
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(CType(0, Short), "Free"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(CType(1, Short), "Resv"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(CType(-1, Short), "ALL"))
        Me.RESVFORORD.LookUpSettings = StaticListLookUpSettings1
        Me.RESVFORORD.Name = "RESVFORORD"
        Me.RESVFORORD.Type = GetType(Short)
        Me.RESVFORORD.ValueInfo = "-1"
        '
        'ITEMNUM
        '
        Me.ITEMNUM.Description = "Item"
        Me.ITEMNUM.Name = "ITEMNUM"
        '
        'SERIALNUMF
        '
        Me.SERIALNUMF.Description = "Serial"
        Me.SERIALNUMF.Name = "SERIALNUMF"
        '
        'LOCATION
        '
        Me.LOCATION.Description = "Location"
        Me.LOCATION.Name = "LOCATION"
        '
        'PO_TRANDATE_FILTER
        '
        Me.PO_TRANDATE_FILTER.Description = "PO Date Filter"
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("ALL", "All"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(">=", ">="))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("=", "="))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("<=", "<="))
        Me.PO_TRANDATE_FILTER.LookUpSettings = StaticListLookUpSettings2
        Me.PO_TRANDATE_FILTER.Name = "PO_TRANDATE_FILTER"
        Me.PO_TRANDATE_FILTER.ValueInfo = "ALL"
        '
        'PO_TRANSDATE
        '
        Me.PO_TRANSDATE.Description = "PO Date"
        Me.PO_TRANSDATE.Name = "PO_TRANSDATE"
        Me.PO_TRANSDATE.Type = GetType(Date)
        Me.PO_TRANSDATE.ValueInfo = "2018-02-02"
        '
        'C100FREQUENCY
        '
        Me.C100FREQUENCY.Description = "Freq"
        Me.C100FREQUENCY.Name = "C100FREQUENCY"
        '
        'C030ALTSN
        '
        Me.C030ALTSN.Description = "Alt"
        Me.C030ALTSN.Name = "C030ALTSN"
        '
        'C110VOLTAGE
        '
        Me.C110VOLTAGE.Description = "Voltage"
        Me.C110VOLTAGE.Name = "C110VOLTAGE"
        '
        'C200CTRLPANEL
        '
        Me.C200CTRLPANEL.Description = "C. Panel"
        Me.C200CTRLPANEL.Name = "C200CTRLPANEL"
        '
        'C250STONEGUAR
        '
        Me.C250STONEGUAR.Description = "Stone G"
        Me.C250STONEGUAR.Name = "C250STONEGUAR"
        '
        'rptSNs
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMarginBand1, Me.BottomMarginBand1, Me.ReportHeaderBand1, Me.GroupHeaderBand1, Me.DetailBand1, Me.GroupHeader1, Me.GroupHeader2})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.EfDataSource1})
        Me.DataSource = Me.EfDataSource1
        Me.Margins = New System.Drawing.Printing.Margins(11, 10, 23, 43)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.RESVFORORD, Me.ITEMNUM, Me.SERIALNUMF, Me.LOCATION, Me.PO_TRANDATE_FILTER, Me.PO_TRANSDATE, Me.C100FREQUENCY, Me.C030ALTSN, Me.C110VOLTAGE, Me.C200CTRLPANEL, Me.C250STONEGUAR})
        Me.RequestParameters = False
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Scripts.OnBeforePrint = "rptSNs_BeforePrint"
        Me.Scripts.OnParametersRequestBeforeShow = "rptSNs_ParametersRequestBeforeShow"
        Me.ScriptsSource = resources.GetString("$this.ScriptsSource")
        Me.SnapGridSize = 5.0!
        Me.SnapGridStepCount = 5
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
        Me.Version = "17.2"
        CType(Me.EfDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub



#End Region

    Private Sub rptSNs_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim RPT As rptSNs = CType(sender, rptSNs)



        Dim FILTER As String = ""

        If RPT.Parameters.Item("RESVFORORD").Value > -1 Then

            FILTER += "[RESVFORORD] = ?RESVFORORD"
        End If


        For Each param As Parameter In RPT.Parameters
            If param.LookUpSettings Is Nothing AndAlso param.Type.Name = "String" AndAlso param.Value <> String.Empty Then
                If FILTER.Length > 0 Then
                    FILTER += " AND "
                End If

                FILTER += String.Format(" Contains([{0}], ?{1})", param.Name.ToString, param.Name.ToString)
            End If
        Next



        'If RPT.Parameters.Item("ITEMNUM").Value <> String.Empty Then
        '    If FILTER.Length > 0 Then
        '        FILTER += " AND "
        '    End If
        '    FILTER += " Contains([ITEMNUM], ?ITEMNUM)"
        'End If

        If RPT.Parameters.Item("PO_TRANDATE_FILTER").Value <> "ALL" Then
            If FILTER.Length > 0 Then
                FILTER += " AND "
            End If
            FILTER += " [PO_TRANSDATE] " & RPT.Parameters.Item("PO_TRANDATE_FILTER").Value & " ?PO_TRANSDATE"
        End If





        FilterString = FILTER

    End Sub

    Private Sub rptSNs_ParametersRequestBeforeShow(sender As Object, e As ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow



    End Sub


End Class