using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace BethanysPieShopMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button myButton = FindViewById<Button>(Resource.Id.button1);
            myButton.Click += this.Button1Click;
        }

        private void Button1Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnStart()
        {
            base.OnStart();
        }
        protected override void OnResume()
        {
            base.OnResume();
        }
        protected override void OnStop()
        {
            base.OnStop();
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}