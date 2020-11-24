using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace BethanysPieShopMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _orderPiesButton;
        private Button _viewCartItemsButton;
        private Button _aboutButton;
        private Button _pieByCategoryButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            FindViews();
            InitializeEventHandlers();
        }

        private void FindViews()
        {
            _orderPiesButton = FindViewById<Button>(Resource.Id.orderPiesButton);
            _viewCartItemsButton = FindViewById<Button>(Resource.Id.viewCartItemsButton);
            _aboutButton = FindViewById<Button>(Resource.Id.aboutButton);
            _pieByCategoryButton = FindViewById<Button>(Resource.Id.pieByCategoryButton);

        }

        private void InitializeEventHandlers()
        {
            _orderPiesButton.Click += this.onOrderPiesButtonClick;
            _viewCartItemsButton.Click += this.onViewCartItemsButtonClick;
            _aboutButton.Click += this._aboutButton_Click;
            _pieByCategoryButton.Click += this._pieByCategoryButton_Click;
        }

        private void _pieByCategoryButton_Click(object sender, System.EventArgs e) {
            Intent intent = new Intent(this, typeof(PieMenuWithTabsActivity));
            StartActivity(intent);
        }

        private void _aboutButton_Click(object sender, System.EventArgs e) {
            Intent intent = new Intent(this, typeof(AboutActivity));
            StartActivity(intent);
        }

        private void onOrderPiesButtonClick(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PieMenuActivity));
            StartActivity(intent);
        }

        private void onViewCartItemsButtonClick(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
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