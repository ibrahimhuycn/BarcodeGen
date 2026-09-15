using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using System.Diagnostics;
using System.Drawing.Printing;

namespace BarcodeGen;

public partial class MainForm : Form
{
    private string? _barcodeData;
    private string? _patientData;
    private DateTime _dateTime;
    private string? _selectedBarcodePrinter;

    public MainForm()
    {
        InitializeComponent();
        OutputMachineName();
    }

    private void OutputMachineName()
    {
        Debug.WriteLine($"MachineName: {Environment.MachineName}");
    }

    private void PopulateInstalledPrintersCombo()
    {
        // Add list of installed printers found to the combo box.
        var isBarcodePrinterInstalled = false;

        foreach (string installedPrinter in PrinterSettings.InstalledPrinters)
        {
            if (installedPrinter == "BarcodePrinter")
            {
                isBarcodePrinterInstalled = true;
            }

            comboInstalledPrinters.Properties.Items.Add(installedPrinter);
        }

        if (isBarcodePrinterInstalled)
        {
            comboInstalledPrinters.SelectedItem = "BarcodePrinter";
            _selectedBarcodePrinter = "BarcodePrinter";
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        PopulateInstalledPrintersCombo();    // POPULATE COMBO WITH A LIST OF INSTALLED PRINTERS
    }

    private void btnGeneratePrintBarcode_Click(object sender, EventArgs e)
    {
        _barcodeData = null;
        _patientData = null;
        _dateTime = default;

        // VERIFING THAT THE TEXTBOX IS NOT EMPTY BEFORE PROCEEDING TO GENERATE BARCODE
        if (!string.IsNullOrEmpty(txtUserInput.Text))
        {
            try
            {
                _barcodeData = txtUserInput.Text;
                _patientData = txtPateintInfo.Text;
                _dateTime = DateTime.Now;

                GenerateAndPrintBarcode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        else
        {
            MessageBox.Show("User input is required to generate barcode!");
        }

        ActiveControl = txtPateintInfo;
    }

    private void GenerateAndPrintBarcode()
    {
        var barcodeReport = new BarcodeReport();

        barcodeReport.Parameters["PatientData"].Value = _patientData;
        barcodeReport.Parameters["BarcodeData"].Value = _barcodeData;
        barcodeReport.Parameters["DateTime"].Value = _dateTime;

        BarcodePreview.DocumentSource = barcodeReport;
        BarcodePreview.PageBorderVisibility = DevExpress.DocumentView.PageBorderVisibility.None;
        BarcodePreview.Refresh();

        barcodeReport.PrinterName = PrinterSettings.InstalledPrinters[0];
        barcodeReport.ShowPrintMarginsWarning = false;

        var autoPrint = new ReportPrintTool(barcodeReport);
        var printerName = comboInstalledPrinters.SelectedItem?.ToString();

        try
        {
            autoPrint.Print(printerName);
        }
        catch (Exception)
        {
        }
    }

    private void comboInstalledPrinters_EditValueChanged(object sender, EventArgs e)
    {
        _selectedBarcodePrinter = comboInstalledPrinters.SelectedItem?.ToString();
    }
}
