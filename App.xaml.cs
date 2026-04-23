using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Module7SignupProfile;

/// <summary>
/// The root application class.  Initializes the component tree and
/// sets the startup page to the <see cref="AppShell"/>.
/// </summary>
public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Use a Shell to orchestrate navigation.  Starting page is defined
        // in AppShell.xaml via ShellContent with route "SignupPage".
        MainPage = new AppShell();
    }
}
