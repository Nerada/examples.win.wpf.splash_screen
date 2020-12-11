// -----------------------------------------------
//     Author: Ramon Bollen
//      File: SplashScreen.App.xaml.cs
// Created on: 20201209
// -----------------------------------------------

using System.Threading;
using System.Windows;
using SplashScreen.Views;

namespace SplashScreen
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var splash = new Splash();
            splash.Show();

            Thread.Sleep(10000);

            var mainWindow = new MainWindow();
            mainWindow.Show();

            splash.Close();
        }
    }
}