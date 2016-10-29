using Android.App;
using Android.Widget;
using Android.OS;
using RealTime.Shared;

namespace RealTime.Droid
{
    [Activity(Label = "RealTime.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var client = new Startup();
            client.Start();
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            FindViewById<Button>(Resource.Id.button1).Click += (e, s) =>
            {
                client.Send("test", "from xamrin");
            };
        }
    }
}

