namespace BarcodeGen;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

  private void InitializeComponent()
  {
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
    TabNavigationPageAbout = new DevExpress.XtraBars.Navigation.TabNavigationPage();
    LabelControl1 = new DevExpress.XtraEditors.LabelControl();
    TabNavigationPrinterSettings = new DevExpress.XtraBars.Navigation.TabNavigationPage();
    txtSelectPrinter = new Label();
    comboInstalledPrinters = new DevExpress.XtraEditors.ComboBoxEdit();
    TabNavigationGenerateBarcode = new DevExpress.XtraBars.Navigation.TabNavigationPage();
    GroupControlReportPreivew = new DevExpress.XtraEditors.GroupControl();
    BarcodePreview = new DevExpress.XtraPrinting.Preview.DocumentViewer();
    lblInstructions = new Label();
    txtUserInput = new DevExpress.XtraEditors.TextEdit();
    btnGeneratePrintBarcode = new DevExpress.XtraEditors.SimpleButton();
    lblBarcode = new Label();
    txtPateintInfo = new DevExpress.XtraEditors.TextEdit();
    lblPatientInfo = new Label();
    TabPaneGenerateBarcode = new DevExpress.XtraBars.Navigation.TabPane();
    TabNavigationPageAbout.SuspendLayout();
    TabNavigationPrinterSettings.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)comboInstalledPrinters.Properties).BeginInit();
    TabNavigationGenerateBarcode.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)GroupControlReportPreivew).BeginInit();
    GroupControlReportPreivew.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)txtUserInput.Properties).BeginInit();
    ((System.ComponentModel.ISupportInitialize)txtPateintInfo.Properties).BeginInit();
    ((System.ComponentModel.ISupportInitialize)TabPaneGenerateBarcode).BeginInit();
    TabPaneGenerateBarcode.SuspendLayout();
    SuspendLayout();
    // 
    // TabNavigationPageAbout
    // 
    TabNavigationPageAbout.Caption = "About";
    TabNavigationPageAbout.Controls.Add(LabelControl1);
    TabNavigationPageAbout.Margin = new Padding(4, 3, 4, 3);
    TabNavigationPageAbout.Name = "TabNavigationPageAbout";
    TabNavigationPageAbout.Size = new Size(822, 231);
    // 
    // LabelControl1
    // 
    LabelControl1.Appearance.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
    LabelControl1.Appearance.Options.UseFont = true;
    LabelControl1.Location = new Point(4, 3);
    LabelControl1.Margin = new Padding(4, 3, 4, 3);
    LabelControl1.Name = "LabelControl1";
    LabelControl1.Size = new Size(282, 135);
    LabelControl1.TabIndex = 0;
    LabelControl1.Text = "As-salamu ‘alaikum wa rahmatullahi wa barakatuh,\r\n\r\nBarcode Gen v 1.1.0\r\nLast Updated on: 15/09/2026\r\n\r\nIf you have any suggesstion please let me know.\r\n\r\nIBRAHIM HUSSAIN   :)\r\nibrahim.hucyn@live.com";
    // 
    // TabNavigationPrinterSettings
    // 
    TabNavigationPrinterSettings.Caption = "Printer Settings";
    TabNavigationPrinterSettings.Controls.Add(txtSelectPrinter);
    TabNavigationPrinterSettings.Controls.Add(comboInstalledPrinters);
    TabNavigationPrinterSettings.Margin = new Padding(4, 3, 4, 3);
    TabNavigationPrinterSettings.Name = "TabNavigationPrinterSettings";
    TabNavigationPrinterSettings.Size = new Size(822, 231);
    // 
    // txtSelectPrinter
    // 
    txtSelectPrinter.AutoSize = true;
    txtSelectPrinter.Location = new Point(10, 14);
    txtSelectPrinter.Margin = new Padding(4, 0, 4, 0);
    txtSelectPrinter.Name = "txtSelectPrinter";
    txtSelectPrinter.Size = new Size(76, 15);
    txtSelectPrinter.TabIndex = 10;
    txtSelectPrinter.Text = "Select Printer";
    // 
    // comboInstalledPrinters
    // 
    comboInstalledPrinters.Location = new Point(14, 32);
    comboInstalledPrinters.Margin = new Padding(4, 3, 4, 3);
    comboInstalledPrinters.Name = "comboInstalledPrinters";
    comboInstalledPrinters.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
    comboInstalledPrinters.Properties.Sorted = true;
    comboInstalledPrinters.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
    comboInstalledPrinters.Size = new Size(300, 20);
    comboInstalledPrinters.TabIndex = 9;
    comboInstalledPrinters.EditValueChanged += comboInstalledPrinters_EditValueChanged;
    // 
    // TabNavigationGenerateBarcode
    // 
    TabNavigationGenerateBarcode.Caption = "Generate Barcodes";
    TabNavigationGenerateBarcode.Controls.Add(GroupControlReportPreivew);
    TabNavigationGenerateBarcode.Controls.Add(lblInstructions);
    TabNavigationGenerateBarcode.Controls.Add(txtUserInput);
    TabNavigationGenerateBarcode.Controls.Add(btnGeneratePrintBarcode);
    TabNavigationGenerateBarcode.Controls.Add(lblBarcode);
    TabNavigationGenerateBarcode.Controls.Add(txtPateintInfo);
    TabNavigationGenerateBarcode.Controls.Add(lblPatientInfo);
    TabNavigationGenerateBarcode.Margin = new Padding(4, 3, 4, 3);
    TabNavigationGenerateBarcode.Name = "TabNavigationGenerateBarcode";
    TabNavigationGenerateBarcode.Size = new Size(822, 229);
    // 
    // GroupControlReportPreivew
    // 
    GroupControlReportPreivew.Controls.Add(BarcodePreview);
    GroupControlReportPreivew.Dock = DockStyle.Right;
    GroupControlReportPreivew.Location = new Point(375, 0);
    GroupControlReportPreivew.Margin = new Padding(4, 3, 4, 3);
    GroupControlReportPreivew.Name = "GroupControlReportPreivew";
    GroupControlReportPreivew.Size = new Size(447, 229);
    GroupControlReportPreivew.TabIndex = 12;
    GroupControlReportPreivew.Text = "Barcode Preview";
    // 
    // BarcodePreview
    // 
    BarcodePreview.Appearance.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
    BarcodePreview.Appearance.Options.UseFont = true;
    BarcodePreview.AutoZoom = true;
    BarcodePreview.Dock = DockStyle.Fill;
    BarcodePreview.IsMetric = false;
    BarcodePreview.Location = new Point(2, 23);
    BarcodePreview.Margin = new Padding(4, 3, 4, 3);
    BarcodePreview.Name = "BarcodePreview";
    BarcodePreview.ShowPageMargins = false;
    BarcodePreview.Size = new Size(443, 204);
    BarcodePreview.Status = "Barcode preview.";
    BarcodePreview.TabIndex = 1;
    BarcodePreview.TooltipFont = new Font("Cambria", 8.25F);
    // 
    // lblInstructions
    // 
    lblInstructions.AutoEllipsis = true;
    lblInstructions.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
    lblInstructions.Location = new Point(8, 6);
    lblInstructions.Margin = new Padding(4, 0, 4, 0);
    lblInstructions.Name = "lblInstructions";
    lblInstructions.Size = new Size(292, 37);
    lblInstructions.TabIndex = 7;
    lblInstructions.Text = "Enter Patient Information if required and the barcode to be printed.";
    // 
    // txtUserInput
    // 
    txtUserInput.EnterMoveNextControl = true;
    txtUserInput.Location = new Point(86, 81);
    txtUserInput.Margin = new Padding(4, 3, 4, 3);
    txtUserInput.Name = "txtUserInput";
    txtUserInput.Size = new Size(261, 20);
    txtUserInput.TabIndex = 2;
    // 
    // btnGeneratePrintBarcode
    // 
    btnGeneratePrintBarcode.Location = new Point(230, 111);
    btnGeneratePrintBarcode.Margin = new Padding(4, 3, 4, 3);
    btnGeneratePrintBarcode.Name = "btnGeneratePrintBarcode";
    btnGeneratePrintBarcode.Size = new Size(118, 27);
    btnGeneratePrintBarcode.TabIndex = 3;
    btnGeneratePrintBarcode.Text = "Generate Barcode";
    btnGeneratePrintBarcode.Click += btnGeneratePrintBarcode_Click;
    // 
    // lblBarcode
    // 
    lblBarcode.AutoSize = true;
    lblBarcode.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
    lblBarcode.Location = new Point(8, 84);
    lblBarcode.Margin = new Padding(4, 0, 4, 0);
    lblBarcode.Name = "lblBarcode";
    lblBarcode.Size = new Size(44, 12);
    lblBarcode.TabIndex = 4;
    lblBarcode.Text = "Barcode";
    // 
    // txtPateintInfo
    // 
    txtPateintInfo.EnterMoveNextControl = true;
    txtPateintInfo.Location = new Point(86, 52);
    txtPateintInfo.Margin = new Padding(4, 3, 4, 3);
    txtPateintInfo.Name = "txtPateintInfo";
    txtPateintInfo.Size = new Size(261, 20);
    txtPateintInfo.TabIndex = 1;
    // 
    // lblPatientInfo
    // 
    lblPatientInfo.AutoSize = true;
    lblPatientInfo.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
    lblPatientInfo.Location = new Point(8, 54);
    lblPatientInfo.Margin = new Padding(4, 0, 4, 0);
    lblPatientInfo.Name = "lblPatientInfo";
    lblPatientInfo.Size = new Size(59, 12);
    lblPatientInfo.TabIndex = 6;
    lblPatientInfo.Text = "Patient Info";
    // 
    // TabPaneGenerateBarcode
    // 
    TabPaneGenerateBarcode.Controls.Add(TabNavigationGenerateBarcode);
    TabPaneGenerateBarcode.Controls.Add(TabNavigationPrinterSettings);
    TabPaneGenerateBarcode.Controls.Add(TabNavigationPageAbout);
    TabPaneGenerateBarcode.Dock = DockStyle.Fill;
    TabPaneGenerateBarcode.Location = new Point(0, 0);
    TabPaneGenerateBarcode.Margin = new Padding(4, 3, 4, 3);
    TabPaneGenerateBarcode.Name = "TabPaneGenerateBarcode";
    TabPaneGenerateBarcode.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { TabNavigationGenerateBarcode, TabNavigationPrinterSettings, TabNavigationPageAbout });
    TabPaneGenerateBarcode.RegularSize = new Size(822, 262);
    TabPaneGenerateBarcode.SelectedPage = TabNavigationGenerateBarcode;
    TabPaneGenerateBarcode.Size = new Size(822, 262);
    TabPaneGenerateBarcode.TabIndex = 10;
    TabPaneGenerateBarcode.Text = "DevExpress Report";
    // 
    // MainForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(822, 262);
    Controls.Add(TabPaneGenerateBarcode);
    FormBorderStyle = FormBorderStyle.FixedSingle;
    Icon = (Icon)resources.GetObject("$this.Icon");
    Margin = new Padding(4, 3, 4, 3);
    MaximizeBox = false;
    Name = "MainForm";
    Text = "Barcode Gen";
    Load += MainForm_Load;
    TabNavigationPageAbout.ResumeLayout(false);
    TabNavigationPageAbout.PerformLayout();
    TabNavigationPrinterSettings.ResumeLayout(false);
    TabNavigationPrinterSettings.PerformLayout();
    ((System.ComponentModel.ISupportInitialize)comboInstalledPrinters.Properties).EndInit();
    TabNavigationGenerateBarcode.ResumeLayout(false);
    TabNavigationGenerateBarcode.PerformLayout();
    ((System.ComponentModel.ISupportInitialize)GroupControlReportPreivew).EndInit();
    GroupControlReportPreivew.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)txtUserInput.Properties).EndInit();
    ((System.ComponentModel.ISupportInitialize)txtPateintInfo.Properties).EndInit();
    ((System.ComponentModel.ISupportInitialize)TabPaneGenerateBarcode).EndInit();
    TabPaneGenerateBarcode.ResumeLayout(false);
    ResumeLayout(false);
  }

  private DevExpress.XtraBars.Navigation.TabNavigationPage TabNavigationPageAbout;
    private DevExpress.XtraEditors.LabelControl LabelControl1;
    private DevExpress.XtraBars.Navigation.TabNavigationPage TabNavigationPrinterSettings;
    private Label txtSelectPrinter;
    private DevExpress.XtraEditors.ComboBoxEdit comboInstalledPrinters;
    private DevExpress.XtraBars.Navigation.TabNavigationPage TabNavigationGenerateBarcode;
    private DevExpress.XtraEditors.GroupControl GroupControlReportPreivew;
    private Label lblInstructions;
    private DevExpress.XtraEditors.TextEdit txtUserInput;
    private DevExpress.XtraEditors.SimpleButton btnGeneratePrintBarcode;
    private Label lblBarcode;
    private DevExpress.XtraEditors.TextEdit txtPateintInfo;
    private Label lblPatientInfo;
    private DevExpress.XtraBars.Navigation.TabPane TabPaneGenerateBarcode;
    private DevExpress.XtraPrinting.Preview.DocumentViewer BarcodePreview;
}
