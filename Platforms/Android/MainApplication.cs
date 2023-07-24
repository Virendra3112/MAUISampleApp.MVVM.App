using Android.App;
using Android.Runtime;
using MAUISampleApp.MVVM.Platforms.Android.Helpers;

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

        AndroidBootStrapper.Initialize();

    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
