using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace _02112019
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            var to2ndActivityButton = FindViewById<Button>(Resource.Id.button1);
            var WebViewActivityButton = FindViewById<Button>(Resource.Id.button2);
            var editText = FindViewById<EditText>(Resource.Id.edittext1);

            to2ndActivityButton.Click += delegate
            {
                var text = editText.Text;
                var intent = new Intent(this, typeof(_2ndactivity));
                intent.PutExtra("editextvalue", text);
                StartActivity(intent);

            };

            WebViewActivityButton.Click += delegate
            {
                var text = editText.Text;
                var intent = new Intent(this, typeof(WebViewActivity));
                StartActivity(intent);

            };
        }
    }
}