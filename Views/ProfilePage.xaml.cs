using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;

namespace Module7SignupProfile.Views;

/// <summary>
/// Profile page displays the username and email passed from the sign‑up
/// page via query parameters.  It also provides a sign‑out button that
/// navigates back to the sign‑up page.
/// </summary>
[QueryProperty(nameof(Username), "Username")]
[QueryProperty(nameof(Email), "Email")]
public partial class ProfilePage : ContentPage, INotifyPropertyChanged
{
    private string username = string.Empty;
    private string email = string.Empty;

    public ProfilePage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    /// <summary>
    /// Gets or sets the username.  The [QueryProperty] attribute binds this
    /// property to the "Username" query parameter.  When the property is set
    /// it raises PropertyChanged so that bindings update.
    /// </summary>
    public string Username
    {
        get => username;
        set
        {
            if (username != value)
            {
                username = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }
    }

    /// <summary>
    /// Gets or sets the email.  The [QueryProperty] attribute binds this
    /// property to the "Email" query parameter.  When the property is set
    /// it raises PropertyChanged so that bindings update.
    /// </summary>
    public string Email
    {
        get => email;
        set
        {
            if (email != value)
            {
                email = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }
    }

    /// <summary>
    /// Handles the Sign Out button click.  Navigates back to the sign‑up
    /// page using an absolute route.  The double slash resets the
    /// navigation stack so that the profile page is removed from history.
    /// </summary>
    private async void OnSignOutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignupPage");
    }

    public new event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
