using Microsoft.UI.Xaml;

namespace Module7SignupProfile.WinUI;

/// <summary>
/// Provides application‑specific behavior to supplement the default
/// Windows App class.  This class is compiled only for the Windows
/// target framework and creates the shared MAUI app instance.
/// </summary>
public partial class App : MauiWinUIApplication
{
    public App()
    {
        this.InitializeComponent();
    }

    protected override MauiApp CreateMauiApp() => Module7SignupProfile.MauiProgram.CreateMauiApp();
}
