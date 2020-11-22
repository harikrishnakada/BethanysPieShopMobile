using BethanysPieShopMobile.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopMobile.Core.Repository
{
    public static class ShoppingCartRepository
    {
        private static ShoppingCart _shoppingCart = new ShoppingCart();

        public static void AddToShoppingCart(Pie pie, int amount)
        {
            var shoppingCartItem = new ShoppingCartItem()
            {
                Pie = pie,
                Amount = amount
            };

            _shoppingCart.CartItems.Add(shoppingCartItem);
        }

        public static List<ShoppingCartItem> GetAllShoppingCartItems()
        {

            return _shoppingCart.CartItems;
        }

    }
}
