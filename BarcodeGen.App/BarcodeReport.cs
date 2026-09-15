using System.IO;
using System.Reflection;
using DevExpress.XtraReports.UI;

namespace BarcodeGen
{
    public partial class BarcodeReport : XtraReport
    {
        private const string LayoutFileName = "BarcodeReport.repx";

        public BarcodeReport()
        {
            // The layout lives in BarcodeReport.vsrepx so it can be edited with the visual
            // Report Designer. The build converts it to BarcodeReport.repx - the standard
            // format LoadLayoutFromXml accepts - and deploys it next to the application.
            LoadLayoutFromXml(GetLayoutStream());
        }

        private static Stream GetLayoutStream()
        {
            // Prefer the layout deployed next to the application (designer edits apply immediately).
            var deployed = Path.Combine(AppContext.BaseDirectory, LayoutFileName);
            if (File.Exists(deployed))
            {
                return File.OpenRead(deployed);
            }

            // Fall back to the copy embedded in the assembly.
            var assembly = Assembly.GetExecutingAssembly();
            var name = Array.Find(
                assembly.GetManifestResourceNames(),
                n => n.EndsWith(LayoutFileName, StringComparison.OrdinalIgnoreCase));

            if (name == null)
            {
                throw new InvalidOperationException(
                    $"Report layout '{LayoutFileName}' was not found next to the application or embedded in the assembly.");
            }

            return assembly.GetManifestResourceStream(name)
                ?? throw new InvalidOperationException($"Cannot open embedded resource '{name}'.");
        }
    }
}
