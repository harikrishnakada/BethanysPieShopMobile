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

namespace BethanysPieShopMobile.Fragments
{
    public class PieCategoryFragment : Android.Support.V4.App.Fragment
    {
        private Category _category;
        private RecyclerView _pieCategoryRecyclerView;
        public PieCategoryFragment(Category category)
        {
            _category = category;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.pie_menu_fragment, container, false);

            var categoryTextView = view.FindViewById<TextView>(Resource.Id.categoryTextView);
            categoryTextView.Text = _category.CategoryName;

            _pieCategoryRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.pieFragmentRecyclerView);

            var _layoutManager = new LinearLayoutManager(this.Context);
            _pieCategoryRecyclerView.SetLayoutManager(_layoutManager);

            var pieAdapter = new PieAdapter(_category);
            pieAdapter.itemClick += OnPieAdapterItemClick;
            _pieCategoryRecyclerView.SetAdapter(pieAdapter);

            return view;
        }

        private void OnPieAdapterItemClick(object sender, int e)
        {
            var intent = new Intent();
            intent.SetClass(this.Context, typeof(PieDetailActivity));
            intent.PutExtra("selectedPieId", e);
            StartActivity(intent);
        }
    }
}