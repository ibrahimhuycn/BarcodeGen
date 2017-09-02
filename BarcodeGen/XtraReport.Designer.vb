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
        Me.XrBarcodePanel = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DateTime = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PatientData = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrPatientDetails = New DevExpress.XtraReports.UI.XRLabel()
        Me.BarcodeData = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrBarCode = New DevExpress.XtraReports.UI.XRBarCode()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 0!
        Me.Detail.MultiColumn.ColumnSpacing = 50.0!
        Me.Detail.MultiColumn.ColumnWidth = 300.0!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.Scripts.OnBeforePrint = "Detail_BeforePrint"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.BorderColor = System.Drawing.Color.Transparent
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBorderColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.BorderColor = System.Drawing.Color.Transparent
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarcodePanel})
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.StylePriority.UseBorderColor = False
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrBarcodePanel
        '
        Me.XrBarcodePanel.BorderColor = System.Drawing.Color.Transparent
        Me.XrBarcodePanel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrBarcodePanel.CanGrow = False
        Me.XrBarcodePanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1, Me.XrPatientDetails, Me.XrBarCode})
        Me.XrBarcodePanel.Dpi = 100.0!
        Me.XrBarcodePanel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrBarcodePanel.Name = "XrBarcodePanel"
        Me.XrBarcodePanel.SizeF = New System.Drawing.SizeF(300.0!, 100.0!)
        Me.XrBarcodePanel.StylePriority.UseBorderColor = False
        '
        'XrLabel2
        '
        Me.XrLabel2.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.DateTime, "Text", "{0:yyyy/MM/dd HH:mm:ss}")})
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(50.99999!, 80.49997!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(197.0!, 15.79166!)
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.TextTrimming = System.Drawing.StringTrimming.None
        '
        'DateTime
        '
        Me.DateTime.Description = "Sytem date and time when barcode is generated"
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Type = GetType(Date)
        Me.DateTime.Visible = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.PatientData, "Text", "")})
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(50.99999!, 64.70833!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(197.0!, 15.79166!)
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "PatientData"
        Me.XrLabel1.TextTrimming = System.Drawing.StringTrimming.None
        '
        'PatientData
        '
        Me.PatientData.Name = "PatientData"
        Me.PatientData.Visible = False
        '
        'XrPatientDetails
        '
        Me.XrPatientDetails.BorderColor = System.Drawing.Color.Transparent
        Me.XrPatientDetails.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.BarcodeData, "Text", "")})
        Me.XrPatientDetails.Dpi = 100.0!
        Me.XrPatientDetails.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.XrPatientDetails.LocationFloat = New DevExpress.Utils.PointFloat(50.95834!, 48.91666!)
        Me.XrPatientDetails.Name = "XrPatientDetails"
        Me.XrPatientDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPatientDetails.SizeF = New System.Drawing.SizeF(197.0!, 15.79166!)
        Me.XrPatientDetails.StylePriority.UseBorderColor = False
        Me.XrPatientDetails.StylePriority.UseFont = False
        Me.XrPatientDetails.Text = "BarcodeData"
        Me.XrPatientDetails.TextTrimming = System.Drawing.StringTrimming.None
        '
        'BarcodeData
        '
        Me.BarcodeData.Description = "Labels barcode text, Patient Info and DateTime"
        Me.BarcodeData.Name = "BarcodeData"
        Me.BarcodeData.Visible = False
        '
        'XrBarCode
        '
        Me.XrBarCode.BorderColor = System.Drawing.Color.Transparent
        Me.XrBarCode.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrBarCode.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.BarcodeData, "Text", "")})
        Me.XrBarCode.Dpi = 100.0!
        Me.XrBarCode.LocationFloat = New DevExpress.Utils.PointFloat(50.95834!, 3.0!)
        Me.XrBarCode.Module = 1.0!
        Me.XrBarCode.Name = "XrBarCode"
        Me.XrBarCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode.ShowText = False
        Me.XrBarCode.SizeF = New System.Drawing.SizeF(197.0!, 45.91666!)
        Me.XrBarCode.StylePriority.UseBorderColor = False
        Me.XrBarCode.StylePriority.UseBorderDashStyle = False
        Code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode.Symbology = Code128Generator1
        '
        'XtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Font = New System.Drawing.Font("Cambria", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 100)
        Me.PageHeight = 100
        Me.PageWidth = 300
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.BarcodeData, Me.PatientData, Me.DateTime})
        Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 16
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ScriptsSource = resources.GetString("$this.ScriptsSource")
        Me.Version = "16.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrBarcodePanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrPatientDetails As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents BarcodeData As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PatientData As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DateTime As DevExpress.XtraReports.Parameters.Parameter
End Class
