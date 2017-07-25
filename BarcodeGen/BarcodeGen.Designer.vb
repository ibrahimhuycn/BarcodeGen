<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarcodeGen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.BarcodeControl = New DevExpress.XtraEditors.BarCodeControl()
        Me.txtUserInput = New DevExpress.XtraEditors.TextEdit()
        Me.btnPrintBarcode = New DevExpress.XtraEditors.SimpleButton()
        Me.RptViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.lblPatientInfo = New System.Windows.Forms.Label()
        Me.txtPateintInfo = New DevExpress.XtraEditors.TextEdit()
        Me.lblInstructions = New System.Windows.Forms.Label()
        CType(Me.txtUserInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPateintInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarcodeControl
        '
        Me.BarcodeControl.AutoModule = True
        Me.BarcodeControl.BackColor = System.Drawing.Color.White
        Me.BarcodeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BarcodeControl.Location = New System.Drawing.Point(35, 174)
        Me.BarcodeControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.BarcodeControl.Name = "BarcodeControl"
        Me.BarcodeControl.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.BarcodeControl.Size = New System.Drawing.Size(168, 66)
        Me.BarcodeControl.Symbology = Code128Generator1
        Me.BarcodeControl.TabIndex = 0
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(70, 74)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(183, 20)
        Me.txtUserInput.TabIndex = 2
        '
        'btnPrintBarcode
        '
        Me.btnPrintBarcode.Location = New System.Drawing.Point(152, 100)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(101, 23)
        Me.btnPrintBarcode.TabIndex = 3
        Me.btnPrintBarcode.Text = "Generate Barcode"
        '
        'RptViewer
        '
        Me.RptViewer.Dock = System.Windows.Forms.DockStyle.Right
        Me.RptViewer.LocalReport.ReportEmbeddedResource = "BarcodeGen.Barcode.rdlc"
        Me.RptViewer.Location = New System.Drawing.Point(259, 0)
        Me.RptViewer.Name = "RptViewer"
        Me.RptViewer.Size = New System.Drawing.Size(357, 171)
        Me.RptViewer.TabIndex = 3
        Me.RptViewer.TabStop = False
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Location = New System.Drawing.Point(3, 77)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(47, 13)
        Me.lblBarcode.TabIndex = 4
        Me.lblBarcode.Text = "Barcode"
        '
        'lblPatientInfo
        '
        Me.lblPatientInfo.AutoSize = True
        Me.lblPatientInfo.Location = New System.Drawing.Point(3, 51)
        Me.lblPatientInfo.Name = "lblPatientInfo"
        Me.lblPatientInfo.Size = New System.Drawing.Size(61, 13)
        Me.lblPatientInfo.TabIndex = 6
        Me.lblPatientInfo.Text = "Patient Info"
        '
        'txtPateintInfo
        '
        Me.txtPateintInfo.Location = New System.Drawing.Point(70, 49)
        Me.txtPateintInfo.Name = "txtPateintInfo"
        Me.txtPateintInfo.Size = New System.Drawing.Size(183, 20)
        Me.txtPateintInfo.TabIndex = 1
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoEllipsis = True
        Me.lblInstructions.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(3, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(250, 32)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Enter Patient Information if required and the barcode to be printed."
        '
        'frmBarcodeGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 171)
        Me.Controls.Add(Me.BarcodeControl)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblPatientInfo)
        Me.Controls.Add(Me.txtPateintInfo)
        Me.Controls.Add(Me.lblBarcode)
        Me.Controls.Add(Me.RptViewer)
        Me.Controls.Add(Me.btnPrintBarcode)
        Me.Controls.Add(Me.txtUserInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmBarcodeGen"
        Me.Text = "Barcode Gen"
        CType(Me.txtUserInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPateintInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarcodeControl As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents txtUserInput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPrintBarcode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lblBarcode As Label
    Friend WithEvents lblPatientInfo As Label
    Friend WithEvents txtPateintInfo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblInstructions As Label
End Class
