using Android.App;
using Android.Runtime;

namespace Module7SignupProfile;

/// <summary>
/// The Android application class.  It overrides <see cref="MauiApplication"/>
/// and returns the shared MAUI app instance from <see cref="MauiProgram.CreateMauiApp()"/>.
/// </summary>
[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
