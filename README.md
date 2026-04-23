# Module 7 Sign‑up and Profile Pages – URI‑Based Navigation

This repository contains a reference implementation for the **Mobile Device Programming** course assignment: **Module 7 – Creating User Sign‑up and Profile Pages using URI‑Based Navigation**.  The project is written using **.NET MAUI**, **C#** and **XAML**, and demonstrates a polished, instructor‑quality solution for building a simple sign‑up form, performing input validation, and navigating to a profile page via URI‑based navigation using `Shell.Current.GoToAsync()`.

## Assignment Highlights

- **Signup Page** – collects a username, email, password and confirm password.  All fields are required.  The page displays clear validation messages if any field is empty or if the password and confirm password fields do not match.
- **Profile Page** – displays a successful signup confirmation message along with the username and email passed from the signup page.  Passwords are never shown.  A sign‑out button navigates back to the signup page.
- **URI‑Based Navigation** – the signup page uses `Shell.Current.GoToAsync()` to navigate to the profile page and passes query parameters in the URI.  The profile page uses `[QueryProperty]` attributes to retrieve the parameters.
- **Shell Setup** – routes are registered in `AppShell.cs` so that pages can be reached by name.  The application starts on the signup page.
- **Platform Support** – the project targets Windows and Android, and is structured using the single‑project approach introduced in .NET MAUI.  Platform‑specific startup files live under the `Platforms/Android` and `Platforms/Windows` folders.

The goal of this sample is to provide an instructor‑grade reference implementation rather than a bare‑bones student solution.  The layout is clean and readable, the validation messages are explicit, and the navigation flow is robust.
