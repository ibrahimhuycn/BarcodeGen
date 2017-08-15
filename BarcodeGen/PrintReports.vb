Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Imports System.ComponentModel
Module PrintReports
    Private CURRENT_PAGE_INDEX As Integer
    Private PRINT_STREAMS As IList(Of Stream)
    Private PRINT_DOC As PrintDocument

    ''' <summary>
    ''' Print rdlc report with custom page width and height
    ''' </summary>
    ''' <param name="report"></param>
    ''' <param name="page_width">the width of the papger, in hunderdths of an inch</param>
    ''' <param name="page_height">the height of the papger, in hunderdths of an inch</param>
    ''' <param name="islandscap"></param>
    ''' <param name="printer_name">Ignore this parameter to use default printer</param>
    ''' <remarks></remarks>
    <System.Obsolete("Use Newprint_microsoft_report instead.")>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Sub print_microsoft_report(ByRef report As LocalReport, ByVal page_width As Integer, ByVal page_height As Integer, Optional ByVal islandscap As Boolean = False, Optional ByVal printer_name As String = Nothing)
        Newprint_microsoft_report(report, page_width, page_height, islandscap, printer_name)
    End Sub
    ''' <summary>
    ''' Print rdlc report with custom page width and height
    ''' </summary>
    ''' <param name="report"></param>
    ''' <param name="page_width">the width of the papger, in hunderdths of an inch</param>
    ''' <param name="page_height">the height of the papger, in hunderdths of an inch</param>
    ''' <param name="islandscap"></param>
    ''' <param name="printer_name">Ignore this parameter to use default printer</param>
    ''' <remarks></remarks>
    Public Sub Newprint_microsoft_report(ByRef report As LocalReport, ByVal page_width As Integer, ByVal page_height As Integer,
                                      Optional ByVal islandscap As Boolean = False,
                                      Optional ByVal printer_name As String = Nothing)
        PRINT_DOC = New PrintDocument()
        If printer_name <> Nothing Then PRINT_DOC.PrinterSettings.PrinterName = printer_name
        If Not PRINT_DOC.PrinterSettings.IsValid Then ' detecate is the printer is exist
            Throw New Exception("Cannot find the specified printer")
        Else
            Dim PAPER_SIZE As New PaperSize("Custom", page_width, page_height)
            PRINT_DOC.DefaultPageSettings.PaperSize = PAPER_SIZE
            PRINT_DOC.DefaultPageSettings.Landscape = islandscap
            Export(report)
            Print()
        End If
    End Sub


    ' Routine to provide to the report renderer, in order to
    ' save an image for each page of the report.
    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim STREAM As Stream = New MemoryStream()

        PRINT_STREAMS.Add(STREAM)
        Return STREAM
    End Function
    ' Export the given report as an EMF (Enhanced Metafile) file.
    Private Sub Export(ByVal report As LocalReport)
        Dim REPORT_WIDTH As Integer
        Dim REPORT_HEIGHT As Integer

        If PRINT_DOC.DefaultPageSettings.Landscape = True Then
            REPORT_WIDTH = PRINT_DOC.DefaultPageSettings.PaperSize.Height
            REPORT_HEIGHT = PRINT_DOC.DefaultPageSettings.PaperSize.Width
        Else
            REPORT_WIDTH = PRINT_DOC.DefaultPageSettings.PaperSize.Width
            REPORT_HEIGHT = PRINT_DOC.DefaultPageSettings.PaperSize.Height
        End If
        Dim deviceInfo As String = "<DeviceInfo>" &
            "<OutputFormat>EMF</OutputFormat>" &
            "<PageWidth>" & REPORT_WIDTH / 100 & "in</PageWidth>" &
            "<PageHeight>" & REPORT_HEIGHT / 100 & "in</PageHeight>" &
            "<MarginTop>0.0in</MarginTop>" &
            "<MarginLeft>0.0in</MarginLeft>" &
            "<MarginRight>0.0in</MarginRight>" &
            "<MarginBottom>0.0in</MarginBottom>" &
            "</DeviceInfo>"

        Dim WARNINGS As Warning()
        PRINT_STREAMS = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, WARNINGS)
        For Each stream As Stream In PRINT_STREAMS
            stream.Position = 0
        Next
    End Sub

    ' Handler for PrintPageEvents
    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(PRINT_STREAMS(CURRENT_PAGE_INDEX))

        ' Adjust rectangular area with printer margins.
        Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX),
                                          ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY),
                                          ev.PageBounds.Width,
                                          ev.PageBounds.Height)

        ' Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

        ' Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect)

        ' Prepare for the next page. Make sure we haven't hit the end.
        CURRENT_PAGE_INDEX += 1
        ev.HasMorePages = (CURRENT_PAGE_INDEX < PRINT_STREAMS.Count)
    End Sub
    Private Sub Print()
        If PRINT_STREAMS Is Nothing OrElse PRINT_STREAMS.Count = 0 Then
            Throw New Exception("Error: no stream to print.")
        End If
        AddHandler PRINT_DOC.PrintPage, AddressOf PrintPage
        CURRENT_PAGE_INDEX = 0
        PRINT_DOC.Print()
    End Sub
End Module