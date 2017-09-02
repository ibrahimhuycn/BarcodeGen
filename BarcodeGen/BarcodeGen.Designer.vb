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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBarcodeGen))
        Me.TabNavigationPageAbout = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TabNavigationPrinterSettings = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSelectPrinter = New System.Windows.Forms.Label()
        Me.comboInstalledPrinters = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CheckBoxAutoPrint = New System.Windows.Forms.CheckBox()
        Me.TabNavigationGenerateBarcode = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GroupControlReportPreivew = New DevExpress.XtraEditors.GroupControl()
        Me.BarcodePreview = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtUserInput = New DevExpress.XtraEditors.TextEdit()
        Me.btnGeneratePrintBarcode = New DevExpress.XtraEditors.SimpleButton()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.txtPateintInfo = New DevExpress.XtraEditors.TextEdit()
        Me.lblPatientInfo = New System.Windows.Forms.Label()
        Me.TabPaneGenerateBarcode = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPageAbout.SuspendLayout()
        Me.TabNavigationPrinterSettings.SuspendLayout()
        CType(Me.comboInstalledPrinters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationGenerateBarcode.SuspendLayout()
        CType(Me.GroupControlReportPreivew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlReportPreivew.SuspendLayout()
        CType(Me.txtUserInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPateintInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPaneGenerateBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPaneGenerateBarcode.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabNavigationPageAbout
        '
        Me.TabNavigationPageAbout.Caption = "About"
        Me.TabNavigationPageAbout.Controls.Add(Me.LabelControl1)
        Me.TabNavigationPageAbout.Name = "TabNavigationPageAbout"
        Me.TabNavigationPageAbout.Size = New System.Drawing.Size(676, 166)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(282, 135)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "As-salamu ‘alaikum wa rahmatullahi wa barakatuh," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barcode Gen v 1.0.0.6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Last U" &
    "pdated on: 2/09/2017" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you have any suggesstion please let me know." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IBRAH" &
    "IM HUSSAIN   :)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ibrahim.hucyn@live.com"
        '
        'TabNavigationPrinterSettings
        '
        Me.TabNavigationPrinterSettings.Caption = "Printer Settings"
        Me.TabNavigationPrinterSettings.Controls.Add(Me.LabelControl2)
        Me.TabNavigationPrinterSettings.Controls.Add(Me.txtSelectPrinter)
        Me.TabNavigationPrinterSettings.Controls.Add(Me.comboInstalledPrinters)
        Me.TabNavigationPrinterSettings.Controls.Add(Me.CheckBoxAutoPrint)
        Me.TabNavigationPrinterSettings.Name = "TabNavigationPrinterSettings"
        Me.TabNavigationPrinterSettings.Size = New System.Drawing.Size(676, 166)
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(7, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(256, 30)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Please note that auto print feature has not been " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "implemeted yet."
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
        'TabNavigationGenerateBarcode
        '
        Me.TabNavigationGenerateBarcode.Caption = "Generate Barcodes"
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.GroupControlReportPreivew)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.lblInstructions)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.txtUserInput)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.btnGeneratePrintBarcode)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.lblBarcode)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.txtPateintInfo)
        Me.TabNavigationGenerateBarcode.Controls.Add(Me.lblPatientInfo)
        Me.TabNavigationGenerateBarcode.Name = "TabNavigationGenerateBarcode"
        Me.TabNavigationGenerateBarcode.Size = New System.Drawing.Size(687, 182)
        '
        'GroupControlReportPreivew
        '
        Me.GroupControlReportPreivew.Controls.Add(Me.BarcodePreview)
        Me.GroupControlReportPreivew.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControlReportPreivew.Location = New System.Drawing.Point(304, 0)
        Me.GroupControlReportPreivew.Name = "GroupControlReportPreivew"
        Me.GroupControlReportPreivew.Size = New System.Drawing.Size(383, 182)
        Me.GroupControlReportPreivew.TabIndex = 12
        Me.GroupControlReportPreivew.Text = "Barcode Preview"
        '
        'BarcodePreview
        '
        Me.BarcodePreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarcodePreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarcodePreview.IsMetric = False
        Me.BarcodePreview.Location = New System.Drawing.Point(2, 20)
        Me.BarcodePreview.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.BarcodePreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.BarcodePreview.Name = "BarcodePreview"
        Me.BarcodePreview.ShowPageMargins = False
        Me.BarcodePreview.Size = New System.Drawing.Size(379, 160)
        Me.BarcodePreview.Status = "Barcode preview."
        Me.BarcodePreview.TabIndex = 1
        Me.BarcodePreview.TooltipFont = New System.Drawing.Font("Cambria", 8.25!)
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
        'txtPateintInfo
        '
        Me.txtPateintInfo.Location = New System.Drawing.Point(74, 45)
        Me.txtPateintInfo.Name = "txtPateintInfo"
        Me.txtPateintInfo.Size = New System.Drawing.Size(224, 20)
        Me.txtPateintInfo.TabIndex = 1
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
        'TabPaneGenerateBarcode
        '
        Me.TabPaneGenerateBarcode.Controls.Add(Me.TabNavigationGenerateBarcode)
        Me.TabPaneGenerateBarcode.Controls.Add(Me.TabNavigationPrinterSettings)
        Me.TabPaneGenerateBarcode.Controls.Add(Me.TabNavigationPageAbout)
        Me.TabPaneGenerateBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPaneGenerateBarcode.Location = New System.Drawing.Point(0, 0)
        Me.TabPaneGenerateBarcode.Name = "TabPaneGenerateBarcode"
        Me.TabPaneGenerateBarcode.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationGenerateBarcode, Me.TabNavigationPrinterSettings, Me.TabNavigationPageAbout})
        Me.TabPaneGenerateBarcode.RegularSize = New System.Drawing.Size(705, 227)
        Me.TabPaneGenerateBarcode.SelectedPage = Me.TabNavigationGenerateBarcode
        Me.TabPaneGenerateBarcode.Size = New System.Drawing.Size(705, 227)
        Me.TabPaneGenerateBarcode.TabIndex = 10
        Me.TabPaneGenerateBarcode.Text = "DevExpress Report"
        '
        'frmBarcodeGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 227)
        Me.Controls.Add(Me.TabPaneGenerateBarcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBarcodeGen"
        Me.Text = "Barcode Gen"
        Me.TabNavigationPageAbout.ResumeLayout(False)
        Me.TabNavigationPageAbout.PerformLayout()
        Me.TabNavigationPrinterSettings.ResumeLayout(False)
        Me.TabNavigationPrinterSettings.PerformLayout()
        CType(Me.comboInstalledPrinters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationGenerateBarcode.ResumeLayout(False)
        Me.TabNavigationGenerateBarcode.PerformLayout()
        CType(Me.GroupControlReportPreivew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlReportPreivew.ResumeLayout(False)
        CType(Me.txtUserInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPateintInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPaneGenerateBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPaneGenerateBarcode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabNavigationPageAbout As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabNavigationPrinterSettings As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSelectPrinter As Label
    Friend WithEvents comboInstalledPrinters As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckBoxAutoPrint As CheckBox
    Friend WithEvents TabNavigationGenerateBarcode As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupControlReportPreivew As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtUserInput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGeneratePrintBarcode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblBarcode As Label
    Friend WithEvents txtPateintInfo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPatientInfo As Label
    Friend WithEvents TabPaneGenerateBarcode As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents BarcodePreview As DevExpress.XtraPrinting.Preview.DocumentViewer
End Class
