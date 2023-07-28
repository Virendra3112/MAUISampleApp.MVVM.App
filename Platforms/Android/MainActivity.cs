using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using MAUISampleApp.MVVM.Platforms.Android.Helpers;

namespace MAUISampleApp.MVVM;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        AndroidBootStrapper.Initialize();

        //restrict screenshot
        Window.SetFlags(WindowManagerFlags.Secure, WindowManagerFlags.Secure);

    }

}
