<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBarcodeGen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Code128Generator2 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBarcodeGen))
        Me.BarcodeControl = New DevExpress.XtraEditors.BarCodeControl()
        Me.txtUserInput = New DevExpress.XtraEditors.TextEdit()
        Me.btnGeneratePrintBarcode = New DevExpress.XtraEditors.SimpleButton()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.lblPatientInfo = New System.Windows.Forms.Label()
        Me.txtPateintInfo = New DevExpress.XtraEditors.TextEdit()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.CheckBoxAutoPrint = New System.Windows.Forms.CheckBox()
        Me.comboInstalledPrinters = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TabPaneGenerateBarcode = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationGenerateBarcode = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TabNavigationPrinterSettings = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.txtSelectPrinter = New System.Windows.Forms.Label()
        Me.TabNavigationPageAbout = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControlReportPreivew = New DevExpress.XtraEditors.GroupControl()
        Me.RptViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.txtUserInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPateintInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboInstalledPrinters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPaneGenerateBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPaneGenerateBarcode.SuspendLayout()
        Me.TabNavigationGenerateBarcode.SuspendLayout()
        Me.TabNavigationPrinterSettings.SuspendLayout()
        Me.TabNavigationPageAbout.SuspendLayout()
        CType(Me.GroupControlReportPreivew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlReportPreivew.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarcodeControl
        '
        Me.BarcodeControl.BackColor = System.Drawing.Color.White
        Me.BarcodeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BarcodeControl.Location = New System.Drawing.Point(23, 268)
        Me.BarcodeControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.BarcodeControl.Margin = New System.Windows.Forms.Padding(0)
        Me.BarcodeControl.Module = 1.0R
        Me.BarcodeControl.Name = "BarcodeControl"
        Me.BarcodeControl.ShowText = False
        Me.BarcodeControl.ShowToolTips = False
        Me.BarcodeControl.Size = New System.Drawing.Size(151, 41)
        Code128Generator2.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetB
        Me.BarcodeControl.Symbology = Code128Generator2
        Me.BarcodeControl.TabIndex = 0
        Me.BarcodeControl.TabStop = False
        Me.BarcodeControl.Text = "VCT-2532/J"
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(74, 70)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(224, 20)
        Me.txtUserInput.TabIndex = 2
        '
        'btnGeneratePrintBarcode
        '
        Me.btnGeneratePrintBarcode.Location = New System.Drawing.Point(197, 96)
        Me.btnGeneratePrintBarcode.Name = "btnGeneratePrintBarcode"
        Me.btnGeneratePrintBarcode.Size = New System.Drawing.Size(101, 23)
        Me.btnGeneratePrintBarcode.TabIndex = 3
        Me.btnGeneratePrintBarcode.Text = "Generate Barcode"
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Location = New System.Drawing.Point(7, 73)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(47, 13)
        Me.lblBarcode.TabIndex = 4
        Me.lblBarcode.Text = "Barcode"
        '
        'lblPatientInfo
        '
        Me.lblPatientInfo.AutoSize = True
        Me.lblPatientInfo.Location = New System.Drawing.Point(7, 47)
        Me.lblPatientInfo.Name = "lblPatientInfo"
        Me.lblPatientInfo.Size = New System.Drawing.Size(61, 13)
        Me.lblPatientInfo.TabIndex = 6
        Me.lblPatientInfo.Text = "Patient Info"
        '
        'txtPateintInfo
        '
        Me.txtPateintInfo.Location = New System.Drawing.Point(74, 45)
        Me.txtPateintInfo.Name = "txtPateintInfo"
        Me.txtPateintInfo.Size = New System.Drawing.Size(224, 20)
        Me.txtPateintInfo.TabIndex = 1
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoEllipsis = True
        Me.lblInstructions.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(7, 5)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(250, 32)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Enter Patient Information if required and the barcode to be printed."
        '
        'CheckBoxAutoPrint
        '
        Me.CheckBoxAutoPrint.AutoSize = True
        Me.CheckBoxAutoPrint.Location = New System.Drawing.Point(7, 46)
        Me.CheckBoxAutoPrint.Name = "CheckBoxAutoPrint"
        Me.CheckBoxAutoPrint.Size = New System.Drawing.Size(71, 17)
        Me.CheckBoxAutoPrint.TabIndex = 8
        Me.CheckBoxAutoPrint.Text = "Auto print"
        Me.CheckBoxAutoPrint.UseVisualStyleBackColor = True
        '
        'comboInstalledPrinters
        '
        Me.comboInstalledPrinters.Location = New System.Drawing.Point(7, 20)
        Me.comboInstalledPrinters.Name = "comboInstalledPrinters"
        Me.comboInstalledPrinters.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboInstalledPrinters.Properties.Sorted = True
        Me.comboInstalledPrinters.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.comboInstalledPrinters.Size = New System.Drawing.Size(257, 20)
        Me.comboInstalledPrinters.TabIndex = 9
        '
        'TabPaneGenerateBarcode
        '
        Me.TabPaneGenerateBarcode.Controls.Add(Me.TabNavigationGenerateBarcode)
        Me.TabPaneGenerateBarcode.Controls.Add(Me.TabNavigationPrinterSettings)
        Me.TabPaneGenerateBarcode.Controls.Add(Me.TabNavigationPageAbout)
        Me.TabPaneGenerateBarcode.Location = New System.Drawing.Point(1, 0)
        Me.TabPaneGenerateBarcode.Name = "TabPaneGenerateBarcode"
        Me.TabPaneGenerateBarcode.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationGenerateBarcode, Me.TabNavigationPrinterSettings, Me.TabNavigationPageAbout})
        Me.TabPaneGenerateBarcode.RegularSize = New System.Drawing.Size(335, 222)
        Me.TabPaneGenerateBarcode.SelectedPage = Me.TabNavigationGenerateBarcode
        Me.TabPaneGenerateBarcode.Size = New System.Drawing.Size(335, 222)
        Me.TabPaneGenerateBarcode.TabIndex = 10
        Me.TabPaneGenerateBarcode.Text = "TabPane1"
        '
        'TabNavigationGenerateBarcode
        '
        Me.TabNavigationGenerateBarcode.Caption = "Generate Barcodes"
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.lblInstructions)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.txtUserInput)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.btnGeneratePrintBarcode)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.lblBarcode)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.txtPateintInfo)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.lblPatientInfo)
        Me.TabNavigationGenerateBarcode.Name = "TabNavigationGenerateBarcode"
        Me.TabNavigationGenerateBarcode.Size = New System.Drawing.Size(317, 177)
        '
        'TabNavigationPrinterSettings
        '
        Me.TabNavigationPrinterSettings.Caption = "Printer Settings"
        Me.TabNavigationPrinterSettings.Controls.Add(Me.txtSelectPrinter)
        Me.TabNavigationPrinterSettings.Controls.Add(Me.comboInstalledPrinters)
        Me.TabNavigationPrinterSettings.Controls.Add(Me.CheckBoxAutoPrint)
        Me.TabNavigationPrinterSettings.Name = "TabNavigationPrinterSettings"
        Me.TabNavigationPrinterSettings.Size = New System.Drawing.Size(317, 177)
        '
        'txtSelectPrinter
        '
        Me.txtSelectPrinter.AutoSize = True
        Me.txtSelectPrinter.Location = New System.Drawing.Point(4, 4)
        Me.txtSelectPrinter.Name = "txtSelectPrinter"
        Me.txtSelectPrinter.Size = New System.Drawing.Size(70, 13)
        Me.txtSelectPrinter.TabIndex = 10
        Me.txtSelectPrinter.Text = "Select Printer"
        '
        'TabNavigationPageAbout
        '
        Me.TabNavigationPageAbout.Caption = "About"
        Me.TabNavigationPageAbout.Controls.Add(Me.LabelControl1)
        Me.TabNavigationPageAbout.Name = "TabNavigationPageAbout"
        Me.TabNavigationPageAbout.Size = New System.Drawing.Size(317, 177)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(289, 165)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = resources.GetString("LabelControl1.Text")
        '
        'GroupControlReportPreivew
        '
        Me.GroupControlReportPreivew.Controls.Add(Me.RptViewer)
        Me.GroupControlReportPreivew.Location = New System.Drawing.Point(342, 4)
        Me.GroupControlReportPreivew.Name = "GroupControlReportPreivew"
        Me.GroupControlReportPreivew.Size = New System.Drawing.Size(315, 218)
        Me.GroupControlReportPreivew.TabIndex = 11
        Me.GroupControlReportPreivew.Text = "Barcode Preview"
        '
        'RptViewer
        '
        Me.RptViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptViewer.DocumentMapWidth = 69
        Me.RptViewer.LocalReport.ReportEmbeddedResource = "BarcodeGen.Barcode.rdlc"
        Me.RptViewer.Location = New System.Drawing.Point(2, 20)
        Me.RptViewer.Name = "RptViewer"
        Me.RptViewer.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.RptViewer.ShowBackButton = False
        Me.RptViewer.ShowExportButton = False
        Me.RptViewer.ShowFindControls = False
        Me.RptViewer.ShowPageNavigationControls = False
        Me.RptViewer.ShowRefreshButton = False
        Me.RptViewer.ShowStopButton = False
        Me.RptViewer.ShowZoomControl = False
        Me.RptViewer.Size = New System.Drawing.Size(311, 196)
        Me.RptViewer.TabIndex = 4
        Me.RptViewer.TabStop = False
        '
        'frmBarcodeGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 223)
        Me.Controls.Add(Me.GroupControlReportPreivew)
        Me.Controls.Add(Me.TabPaneGenerateBarcode)
        Me.Controls.Add(Me.BarcodeControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmBarcodeGen"
        Me.Text = "Barcode Gen"
        CType(Me.txtUserInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPateintInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboInstalledPrinters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPaneGenerateBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPaneGenerateBarcode.ResumeLayout(False)
        Me.TabNavigationGenerateBarcode.ResumeLayout(False)
        Me.TabNavigationGenerateBarcode.PerformLayout()
        Me.TabNavigationPrinterSettings.ResumeLayout(False)
        Me.TabNavigationPrinterSettings.PerformLayout()
        Me.TabNavigationPageAbout.ResumeLayout(False)
        Me.TabNavigationPageAbout.PerformLayout()
        CType(Me.GroupControlReportPreivew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlReportPreivew.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarcodeControl As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents txtUserInput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGeneratePrintBarcode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblBarcode As Label
    Friend WithEvents lblPatientInfo As Label
    Friend WithEvents txtPateintInfo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblInstructions As Label
    Friend WithEvents CheckBoxAutoPrint As CheckBox
    Friend WithEvents comboInstalledPrinters As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TabPaneGenerateBarcode As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationGenerateBarcode As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPrinterSettings As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents txtSelectPrinter As Label
    Friend WithEvents GroupControlReportPreivew As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabNavigationPageAbout As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
