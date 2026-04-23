using Microsoft.Maui.Controls;

namespace Module7SignupProfile;

/// <summary>
/// Defines the routes used for URI‑based navigation and wires up the shell.
/// </summary>
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register the ProfilePage route so it can be reached via GoToAsync
        Routing.RegisterRoute(nameof(Views.ProfilePage), typeof(Views.ProfilePage));
    }
}
