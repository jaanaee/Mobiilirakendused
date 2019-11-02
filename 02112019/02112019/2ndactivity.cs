using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Essentials;

namespace _02112019
{
    [Activity(Label = "_2ndactivity")]
    public class _2ndactivity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout1);

            var text = Intent.GetStringExtra("editextvalue");

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = text;


            //Xamarin Essentials osa

            var appName = AppInfo.Name;
            var packageName = AppInfo.PackageName;
            var version = AppInfo.VersionString;
            var build = AppInfo.BuildString;

            AppInfo.ShowSettingsUI();

            var duration = TimeSpan.FromSeconds(10);
            //Vibration.Vibrate(duration);
            await NavigateToBuilding();
        }


        public async Task NavigateToBuilding()
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { Name = "Microdoft building" };
            await Map.OpenAsync(location, options);
        }

    }
}