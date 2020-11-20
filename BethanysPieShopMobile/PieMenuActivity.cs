using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Adapters;
using BethanysPieShopMobile.Core.Model;

namespace BethanysPieShopMobile
{
    [Activity(Label = "PieMenuActivity", MainLauncher = true)]
    public class PieMenuActivity : Activity
    {
        private RecyclerView _pieMenuRecyclerView;
        private RecyclerView.LayoutManager _pieLayoutManager;
        private PieAdapter _pieAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.pie_menu);
            _pieMenuRecyclerView = FindViewById<RecyclerView>(Resource.Id.pieMenuRecyclerView);

            //pie adapter
            //layout manager
            //view holder

            _pieLayoutManager = new LinearLayoutManager(this);
            //_pieLayoutManager = new GridLayoutManager(this, 2, GridLayoutManager.Horizontal, false);
            _pieMenuRecyclerView.SetLayoutManager(_pieLayoutManager);

            _pieAdapter = new PieAdapter();
            _pieMenuRecyclerView.SetAdapter(_pieAdapter);
        }
    }
}