Public Class frmBarcodeGen
    Dim USER_INPUT As String
    Private Sub btnPrintBarcode_Click(sender As Object, e As EventArgs) Handles btnPrintBarcode.Click

        'VERIFING THAT THE TEXTBOX IS NOT EMPTY BEFORE PROCEEDING TO GENERATE BARCODE
        If Not txtUserInput.Text = "" Then


            'GENERATING A BARCODE ON THE BARCODE CONTROL BY ASSINING THE USER INPUT VALUE TO THE TEXT PROPERTY OF THE BARCODE CONTROL
            Try
                USER_INPUT = txtUserInput.Text
                BarcodeControl.Text = USER_INPUT
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
        Dim UserProfile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim ImagePath As String = String.Format("{0}\Pictures\Barcodes\{1}.PNG", UserProfile, USER_INPUT)
        Dim ImageURL As New Uri(ImagePath)
        BarcodeControl.DrawToBitmap(barcodeimage, BarcodeControl.ClientRectangle)
        barcodeimage.Save(ImagePath)

        Dim BarcodeParameters(1) As Microsoft.Reporting.WinForms.ReportParameter
        BarcodeParameters(0) = New Microsoft.Reporting.WinForms.ReportParameter("lblPatientInfo", txtPateintInfo.Text)
        BarcodeParameters(1) = New Microsoft.Reporting.WinForms.ReportParameter("ImageURL", ImageURL.AbsoluteUri)

        RptViewer.LocalReport.EnableExternalImages = True
        RptViewer.LocalReport.SetParameters(BarcodeParameters)
        RptViewer.RefreshReport()

    End Sub
End Class
