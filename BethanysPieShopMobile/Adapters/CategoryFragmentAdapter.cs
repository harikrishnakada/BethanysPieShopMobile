﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Core.Model;
using BethanysPieShopMobile.Core.Repository;
using BethanysPieShopMobile.Fragments;
using Java.Lang;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace BethanysPieShopMobile.Adapters
{
    public class CategoryFragmentAdapter : FragmentPagerAdapter
    {
        private List<Category> _categories;
        public CategoryFragmentAdapter(FragmentManager fm) : base(fm)
        {
            _categories = PieRepository.GetCategoriesWithPies();
        }
        public override int Count => _categories.Count;

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            var pieCategoryFragment = new PieCategoryFragment(_categories[position]);

            return pieCategoryFragment;
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(_categories[position].CategoryName);
        }
    }
}