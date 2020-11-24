using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Adapters;

namespace BethanysPieShopMobile
{
    [Activity(Label = "PieMenuWithTabsActivity", Theme = "@style/AppTheme")]
    public class PieMenuWithTabsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_menu_tabs);
            // Create your application here

            var _piePager = FindViewById<ViewPager>(Resource.Id.piePager);
            var categoryFragmentAdapter = new CategoryFragmentAdapter(SupportFragmentManager);
            _piePager.Adapter = categoryFragmentAdapter;
        }
    }
}