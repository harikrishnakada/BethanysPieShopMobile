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

namespace BethanysPieShopMobile.ViewHolders
{
    public class CartViewHolder: RecyclerView.ViewHolder
    {
        public ImageView _cartImageView { get; set; }
        public TextView _cartImageTextView { get; set; }
        public TextView _cartItemAmount { get; set; }
        public CartViewHolder(View itemView): base(itemView)
        {
            _cartImageTextView = itemView.FindViewById<TextView>(Resource.Id.cartItemImageTextView);
            _cartItemAmount = itemView.FindViewById<TextView>(Resource.Id.cartItemAmountTextView);
            _cartImageView = itemView.FindViewById<ImageView>(Resource.Id.cartItemImageSingleView);
        }
    }
}