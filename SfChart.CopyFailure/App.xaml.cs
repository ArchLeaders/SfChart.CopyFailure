using Syncfusion.Licensing;
using System.Windows;

namespace SfChart.CopyFailure;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        SyncfusionLicenseProvider.RegisterLicense("MjUzMTcxM0AzMjMyMmUzMDJlMzBnalNCcE1BSmczMEs5cW13R3JpWlRXblhoaUtlNytianB5TGlMWVk2dDlvPQ==");
        SyncfusionLicenseProvider.RegisterLicense("NRAiBiAaIQQuGjN/V0R+XU9HcFRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TcEZjWH1aeHVSRWleUw==");
    }
}
