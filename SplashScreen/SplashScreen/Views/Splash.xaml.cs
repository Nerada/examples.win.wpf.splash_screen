// -----------------------------------------------
//     Author: Ramon Bollen
//      File: SplashScreen.Splash.xaml.cs
// Created on: 20201209
// -----------------------------------------------

using SplashScreen.ViewModels;

namespace SplashScreen.Views
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash
    {
        public Splash()
        {
            InitializeComponent();

            Loaded += (_, __) => SplashLoaded();
        }

        private void SplashLoaded()
        {
            DataContext = new SplashViewModel();
        }
    }
}