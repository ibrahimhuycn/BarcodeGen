Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms


Public Class frmBarcodeGen
    Dim USER_INPUT As String
    Dim BARCODE_LABEL_TEXT As String
    Dim SELECTED_BARCODE_PRINTER As String
    Dim USER_PROFILE As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

    Private Sub btnGeneratePrintBarcode_Click(sender As Object, e As EventArgs) Handles btnGeneratePrintBarcode.Click
        'VERIFING THAT THE TEXTBOX IS NOT EMPTY BEFORE PROCEEDING TO GENERATE BARCODE



        If Not txtUserInput.Text = "" Then


            'GENERATING A BARCODE ON THE BARCODE CONTROL BY ASSINING THE USER INPUT VALUE TO THE TEXT PROPERTY OF THE BARCODE CONTROL
            Try
                txtUserInput.Text = txtUserInput.Text.ToUpper
                USER_INPUT = txtUserInput.Text
                BarcodeControl.Text = USER_INPUT

                BARCODE_LABEL_TEXT = USER_INPUT & vbCrLf & txtPateintInfo.Text & vbCrLf & Date.Now.ToString("yyyy/MM/dd HH:mm:ss")
                GenerateAndExportBarcode()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("User input is required to generate barcode!")
        End If

    End Sub
    Private Sub GenerateAndExportBarcode()
        Dim barcodeimage As Bitmap = New Bitmap(BarcodeControl.Width, BarcodeControl.Height)
        Dim ImagePath As String = String.Format("{0}\Pictures\Barcodes\{1}.PNG", USER_PROFILE, USER_INPUT)

        'TODO: CHECK FOR CHARACTERS THAT WOULD BE CONSIDERED AS INVALID AS A FILE NAME IN WINDOWS... LIKE "/"

        Dim ImageURL As New Uri(ImagePath)
        'CHECK FOR THE PRESENCE OF IMAGESAVEDIR, CREAT IT
        VerifySaveDir()

        BarcodeControl.DrawToBitmap(barcodeimage, BarcodeControl.ClientRectangle)
        barcodeimage.Save(ImagePath)

        Dim BarcodeParameters(1) As ReportParameter
        BarcodeParameters(0) = New ReportParameter("lblPatientInfo", BARCODE_LABEL_TEXT)
        BarcodeParameters(1) = New ReportParameter("ImageURL", ImageURL.AbsoluteUri)

        RptViewer.LocalReport.EnableExternalImages = True
        RptViewer.LocalReport.SetParameters(BarcodeParameters)
        RptViewer.RefreshReport()
    End Sub
    Private Sub VerifySaveDir()
        Dim SaveDir As String = USER_PROFILE & "\Pictures\Barcodes"

        If (Not IO.Directory.Exists(SaveDir)) Then
            IO.Directory.CreateDirectory(SaveDir)
        End If
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

        'IF IMAGE SAVE FOLDER IN NOT PRESENT, CREAT IT.
        VerifySaveDir()
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
