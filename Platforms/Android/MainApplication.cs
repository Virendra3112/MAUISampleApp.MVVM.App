﻿using Android.App;
using Android.Runtime;

namespace MAUISampleApp.MVVM;

[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    public override void OnCreate()
    {
        base.OnCreate();
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
