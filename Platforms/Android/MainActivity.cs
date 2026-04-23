using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Module7SignupProfile;

/// <summary>
/// The main activity is the entry point for the Android application.  It
/// inherits from <see cref="MauiAppCompatActivity"/> which wires up the
/// MAUI runtime on Android.  Most logic remains in shared code.
/// </summary>
[Activity(
    Theme = "@style/Maui.SplashTheme",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
public class MainActivity : MauiAppCompatActivity
{
}
