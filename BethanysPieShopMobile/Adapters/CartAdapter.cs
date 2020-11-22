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
using BethanysPieShopMobile.Core.Model;
using BethanysPieShopMobile.Core.Repository;
using BethanysPieShopMobile.Utility;
using BethanysPieShopMobile.ViewHolders;

namespace BethanysPieShopMobile.Adapters
{
    public class CartAdapter : RecyclerView.Adapter
    {
        private List<ShoppingCartItem> _cartItems;
        public override int ItemCount => _cartItems.Count;

        public CartAdapter()
        {
            _cartItems = ShoppingCartRepository.GetAllShoppingCartItems();
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is CartViewHolder cartViewHolder)
            {
                cartViewHolder._cartImageTextView.Text = _cartItems[position].Pie.Name;
                cartViewHolder._cartItemAmount.Text = _cartItems[position].Amount.ToString();

                var imageBitmap = ImageHelper.GetImageBitmapFromUrl(_cartItems[position].Pie.ImageUrl);
                cartViewHolder._cartImageView.SetImageBitmap(imageBitmap);
            }
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.FromContext(parent.Context).Inflate(Resource.Layout.cart_viewholder, parent, false);
            CartViewHolder cartViewHolder = new CartViewHolder(itemView);
            return cartViewHolder;
        }
    }
}