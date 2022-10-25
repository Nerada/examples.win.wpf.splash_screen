// -----------------------------------------------
//     Author: Ramon Bollen
//      File: SplashScreen.App.xaml.cs
// Created on: 20220623
// -----------------------------------------------

using System.Threading;
using System.Windows;
using SplashScreen.Helpers;
using SplashScreen.Views;

namespace SplashScreen;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private void OnStartup(object sender, StartupEventArgs e)
    {
        using AnonymousDisposable _ = SplashHelper.ShowSplashScreen();

        Thread.Sleep(10000);

        MainWindow mainWindow = new();
        mainWindow.Show();
    }
}

public static class SplashHelper
{
    public static AnonymousDisposable ShowSplashScreen()
    {
        Splash splash = new();
        splash.Show();

        return new AnonymousDisposable(splash.Close);
    }
}