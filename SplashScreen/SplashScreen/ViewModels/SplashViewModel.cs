// -----------------------------------------------
//     Author: Ramon Bollen
//      File: SplashScreen.SplashViewModel.cs
// Created on: 20220623
// -----------------------------------------------

using System;

namespace SplashScreen.ViewModels;

public class SplashViewModel
{
    public SplashViewModel()
    {
        Version? currentVersion = GetType().Assembly.GetName().Version;

        if (!(currentVersion is { } version)) return;

        int versionFieldCount = 3;

        if (version.Build == 0) versionFieldCount = 2;

        Version     = version.ToString(versionFieldCount);
        BuildNumber = version.Revision.ToString();
    }

    public bool IsXmas => DateTime.Now.DayOfYear > 342;

    public string CurrentYear => DateTime.Now.Year.ToString();

    public string Version { get; } = string.Empty;

    public string BuildNumber { get; } = string.Empty;
}