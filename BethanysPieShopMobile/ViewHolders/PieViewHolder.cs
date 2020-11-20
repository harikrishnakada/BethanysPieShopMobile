using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace BethanysPieShopMobile.ViewHolders
{
    public class PieViewHolder : RecyclerView.ViewHolder
    {
        public ImageView _pieImageView { get; set; }
        public TextView _pieImageTextView { get; set; }
        public PieViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            _pieImageView = itemView.FindViewById<ImageView>(Resource.Id.pieImageSingleView);
            _pieImageTextView = itemView.FindViewById<TextView>(Resource.Id.pieImageTextView);

            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}