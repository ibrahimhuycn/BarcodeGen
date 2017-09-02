Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class frmBarcodeGen
    Dim USER_INPUT_BARCODE_DATA As String
    Dim PATIENT_DATA As String
    Dim DATE_TIME As Date
    Dim SELECTED_BARCODE_PRINTER As String

    Private Sub btnGeneratePrintBarcode_Click(sender As Object, e As EventArgs) Handles btnGeneratePrintBarcode.Click
        USER_INPUT_BARCODE_DATA = Nothing
        PATIENT_DATA = Nothing
        DATE_TIME = Nothing
        'VERIFING THAT THE TEXTBOX IS NOT EMPTY BEFORE PROCEEDING TO GENERATE BARCODE
        If Not txtUserInput.Text = "" Then
            Try

                USER_INPUT_BARCODE_DATA = txtUserInput.Text
                PATIENT_DATA = txtPateintInfo.Text
                DATE_TIME = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")

                GenerateAndPrintBarcode()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("User input is required to generate barcode!")
        End If

    End Sub
    Private Sub GenerateAndPrintBarcode()
        Dim XBarcode As XtraReport = New XtraReport()
        With XBarcode
            .Parameters("PatientData").Value = PATIENT_DATA
            .Parameters("BarcodeData").Value = USER_INPUT_BARCODE_DATA
            .Parameters("DateTime").Value = DATE_TIME
        End With

        BarcodePreview.DocumentSource = XBarcode
        BarcodePreview.PageBorderVisibility = False
        BarcodePreview.Refresh()


        XBarcode.PrinterName = PrinterSettings.InstalledPrinters.Item(1)

        Dim AutoPrint As New ReportPrintTool(XBarcode)
        AutoPrint.Print(comboInstalledPrinters.SelectedItem)

    End Sub

    Private Sub PopulateInstalledPrintersCombo()
        ' Add list of installed printers found to the combo box.
        ' The INSTALLED_PRINTERS string will be used to provide the display string.
        Dim i As Integer
        Dim INSTALLED_PRINTERS As String
        Dim IS_BARCODE_PRINTER_INSTALLED As Boolean = False

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            INSTALLED_PRINTERS = PrinterSettings.InstalledPrinters.Item(i)
            If INSTALLED_PRINTERS = "BarcodePrinter" Then
                IS_BARCODE_PRINTER_INSTALLED = True
            End If
            comboInstalledPrinters.Properties.Items.Add(INSTALLED_PRINTERS)
        Next

        If IS_BARCODE_PRINTER_INSTALLED = True Then
            comboInstalledPrinters.SelectedItem = "BarcodePrinter"
            SELECTED_BARCODE_PRINTER = "BarcodePrinter"
        End If
    End Sub

    Private Sub frmBarcodeGen_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulateInstalledPrintersCombo()    'POPULATE COMBO WITH A LIST OF INSTALLED PRINTERS

    End Sub

    Private Sub CheckBoxAutoPrint_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxAutoPrint.CheckStateChanged
        If CheckBoxAutoPrint.Checked Then
            btnGeneratePrintBarcode.Text = "Generate | Print"
        Else
            btnGeneratePrintBarcode.Text = "Generate Barcode"
        End If
    End Sub

    Private Sub comboInstalledPrinters_EditValueChanged(sender As Object, e As EventArgs) Handles comboInstalledPrinters.EditValueChanged
        SELECTED_BARCODE_PRINTER = comboInstalledPrinters.SelectedItem
    End Sub


End Class
