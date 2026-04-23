using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace Module7SignupProfile;

/// <summary>
/// Configures and builds the MAUI application.  This class is the entry
/// point used by platform‑specific launchers to construct the shared app
/// instance.
/// </summary>
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        // Register the application class
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                // If you add custom fonts to Resources/Fonts, register them here.
                // Example:
                // fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                // fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
