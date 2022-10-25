// -----------------------------------------------
//     Author: Ramon Bollen
//      File: SplashScreen.AnonymousDisposable.cs
// Created on: 20221025
// -----------------------------------------------

using System;

namespace SplashScreen.Helpers;

public readonly ref struct AnonymousDisposable
{
    private readonly Action? _dispose;

    public AnonymousDisposable(Action dispose)
    {
        _dispose = dispose;
    }

    public void Dispose() => _dispose?.Invoke();
}