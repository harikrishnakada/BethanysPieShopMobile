using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BethanysPieShopMobile
{
    [Activity(Label = "AboutActivity")]
    public class AboutActivity : Activity
    {
        private Button _phoneButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.about);

            // Create your application here
            FindViews();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            _phoneButton.Click += this._phoneButton_Click;
        }

        private void _phoneButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(Intent.ActionDial);
            intent.SetData(Android.Net.Uri.Parse("tel:+917416203280"));
            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        private void FindViews()
        {
            _phoneButton = FindViewById<Button>(Resource.Id.phoneButton);
        }
    }
}