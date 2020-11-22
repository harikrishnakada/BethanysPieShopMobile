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

namespace BethanysPieShopMobile
{
    [Activity(Label = "CartActivity")]
    public class CartActivity : Activity
    {
        private RecyclerView _cartItemsRecyclerView;
        private RecyclerView.LayoutManager _cartLayoutManager;
        private CartAdapter _cartAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cart);
            // Create your application here

            _cartItemsRecyclerView = FindViewById<RecyclerView>(Resource.Id.cartRecyclerView);

            _cartLayoutManager = new LinearLayoutManager(this);
            _cartItemsRecyclerView.SetLayoutManager(_cartLayoutManager);

            _cartAdapter = new CartAdapter();
            _cartItemsRecyclerView.SetAdapter(_cartAdapter);
        }
    }
}