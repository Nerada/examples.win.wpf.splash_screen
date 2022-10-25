// -----------------------------------------------
//     Author: Ramon Bollen
//      File: SplashScreen.Splash.xaml.cs
// Created on: 20220623
// -----------------------------------------------

using SplashScreen.ViewModels;

namespace SplashScreen.Views;

/// <summary>
///     Interaction logic for Splash.xaml
/// </summary>
public partial class Splash
{
    public Splash()
    {
        InitializeComponent();

        Loaded += (_, _) => SplashLoaded();
    }

    private void SplashLoaded() => DataContext = new SplashViewModel();
}