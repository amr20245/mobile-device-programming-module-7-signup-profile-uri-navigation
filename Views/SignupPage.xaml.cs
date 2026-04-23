using System.Text;
using Microsoft.Maui.Controls;

namespace Module7SignupProfile.Views;

/// <summary>
/// Sign‑up page collects user information and performs basic validation.
/// On successful submission it navigates to the profile page using URI‑based
/// navigation and passes the username and email as query parameters.
/// </summary>
public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        // Hide previous error message
        ErrorLabel.IsVisible = false;

        // Retrieve and trim input values
        var username = UsernameEntry.Text?.Trim() ?? string.Empty;
        var email = EmailEntry.Text?.Trim() ?? string.Empty;
        var password = PasswordEntry.Text ?? string.Empty;
        var confirmPassword = ConfirmPasswordEntry.Text ?? string.Empty;

        // Collect validation errors
        var errors = new StringBuilder();
        if (string.IsNullOrWhiteSpace(username))
            errors.AppendLine("Username is required.");
        if (string.IsNullOrWhiteSpace(email))
            errors.AppendLine("Email is required.");
        if (string.IsNullOrWhiteSpace(password))
            errors.AppendLine("Password is required.");
        if (string.IsNullOrWhiteSpace(confirmPassword))
            errors.AppendLine("Confirm Password is required.");
        if (!string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(confirmPassword) && password != confirmPassword)
            errors.AppendLine("Password and Confirm Password must match.");

        // If there are errors, show them and abort
        if (errors.Length > 0)
        {
            ErrorLabel.Text = errors.ToString().TrimEnd();
            ErrorLabel.IsVisible = true;
            return;
        }

        // Build the URI with escaped query parameters
        var route = $"{nameof(ProfilePage)}?Username={Uri.EscapeDataString(username)}&Email={Uri.EscapeDataString(email)}";
        await Shell.Current.GoToAsync(route);
    }
}
