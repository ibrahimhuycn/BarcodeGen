<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrBarCode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrPatientDetails = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DateTime = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PatientData = New DevExpress.XtraReports.Parameters.Parameter()
        Me.BarcodeData = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 0!
        Me.Detail.MultiColumn.ColumnSpacing = 127.0!
        Me.Detail.MultiColumn.ColumnWidth = 762.0!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.Scripts.OnBeforePrint = "Detail_BeforePrint"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.BorderColor = System.Drawing.Color.Transparent
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.StylePriority.UseBorderColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.BorderColor = System.Drawing.Color.Transparent
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode, Me.XrPatientDetails, Me.XrLabel1, Me.XrLabel2})
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 244.5807!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.StylePriority.UseBorderColor = False
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrBarCode
        '
        Me.XrBarCode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrBarCode.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrBarCode.BorderColor = System.Drawing.Color.Transparent
        Me.XrBarCode.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrBarCode.Dpi = 254.0!
        Me.XrBarCode.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?BarcodeData")})
        Me.XrBarCode.LocationFloat = New DevExpress.Utils.PointFloat(46.87498!, 18.00001!)
        Me.XrBarCode.Module = 2.54!
        Me.XrBarCode.Name = "XrBarCode"
        Me.XrBarCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254.0!)
        Me.XrBarCode.ShowText = False
        Me.XrBarCode.SizeF = New System.Drawing.SizeF(646.8383!, 98.8483!)
        Me.XrBarCode.StylePriority.UseBorderColor = False
        Me.XrBarCode.StylePriority.UseBorderDashStyle = False
        Me.XrBarCode.StylePriority.UseTextAlignment = False
        Code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode.Symbology = Code128Generator1
        Me.XrBarCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrPatientDetails
        '
        Me.XrPatientDetails.BorderColor = System.Drawing.Color.Transparent
        Me.XrPatientDetails.Dpi = 254.0!
        Me.XrPatientDetails.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?BarcodeData")})
        Me.XrPatientDetails.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.XrPatientDetails.LocationFloat = New DevExpress.Utils.PointFloat(108.4792!, 117.2483!)
        Me.XrPatientDetails.Name = "XrPatientDetails"
        Me.XrPatientDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPatientDetails.SizeF = New System.Drawing.SizeF(500.38!, 40.11081!)
        Me.XrPatientDetails.StylePriority.UseBorderColor = False
        Me.XrPatientDetails.StylePriority.UseFont = False
        Me.XrPatientDetails.Text = "BarcodeData"
        Me.XrPatientDetails.TextTrimming = System.Drawing.StringTrimming.None
        '
        'XrLabel1
        '
        Me.XrLabel1.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?PatientData")})
        Me.XrLabel1.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(108.5849!, 157.3592!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(500.3799!, 40.11079!)
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "PatientData"
        Me.XrLabel1.TextTrimming = System.Drawing.StringTrimming.None
        '
        'XrLabel2
        '
        Me.XrLabel2.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?DateTime")})
        Me.XrLabel2.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(108.5849!, 197.4699!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(500.3799!, 40.11081!)
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.TextFormatString = "{0:yyyy/MM/dd HH:mm:ss}"
        Me.XrLabel2.TextTrimming = System.Drawing.StringTrimming.None
        '
        'DateTime
        '
        Me.DateTime.Description = "Sytem date and time when barcode is generated"
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Type = GetType(Date)
        Me.DateTime.Visible = False
        '
        'PatientData
        '
        Me.PatientData.Name = "PatientData"
        Me.PatientData.Visible = False
        '
        'BarcodeData
        '
        Me.BarcodeData.Description = "Labels barcode text, Patient Info and DateTime"
        Me.BarcodeData.Name = "BarcodeData"
        Me.BarcodeData.Visible = False
        '
        'XtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Cambria", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Margins = New System.Drawing.Printing.Margins(0, 10, 0, 245)
        Me.PageHeight = 299
        Me.PageWidth = 751
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.BarcodeData, Me.PatientData, Me.DateTime})
        Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 16
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ScriptsSource = resources.GetString("$this.ScriptsSource")
        Me.SnapGridSize = 25.0!
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents BarcodeData As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PatientData As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DateTime As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrBarCode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrPatientDetails As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
