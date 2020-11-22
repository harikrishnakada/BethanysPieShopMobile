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
using BethanysPieShopMobile.Core.Repository;
using BethanysPieShopMobile.Utility;

namespace BethanysPieShopMobile
{
    [Activity(Label = "PieDetailActivity", MainLauncher = false)]
    public class PieDetailActivity : Activity
    {
        private Pie _selectedPie;
        private ImageView _pieImageView;
        private TextView _pieNameTextView;
        private TextView _shortDescriptionTextView;
        private TextView _descriptionTextView;
        private TextView _priceTextView;
        private EditText _amountEditText;
        private Button _addToCartButton;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_details);
            // Create your application here
            var selectedPieId = Intent.Extras.GetInt("selectedPieId");
            _selectedPie = PieRepository.GetPieById(selectedPieId);
            FindViews();
            BindData();
            InitializeClickEvents();
        }

        private void InitializeClickEvents()
        {
            _addToCartButton.Click += this._addToCartButton_Click;
        }

        private void _addToCartButton_Click(object sender, EventArgs e)
        {
            ShoppingCartRepository.AddToShoppingCart(_selectedPie, int.Parse(this._amountEditText.Text));
            Toast.MakeText(Application.Context, "Pie added to the cart", ToastLength.Long).Show();

            //this.Finish() will remove the current activity from the stack.
            this.Finish();
        }

        private void BindData()
        {
            _pieNameTextView.Text = _selectedPie.Name;
            _shortDescriptionTextView.Text = _selectedPie.ShortDescription;
            _descriptionTextView.Text = _selectedPie.LongDescription;
            _priceTextView.Text = $"Price: {_selectedPie.Price}";

            var imageBitmap = ImageHelper.GetImageBitmapFromUrl(_selectedPie.ImageThumbnailUrl);
            _pieImageView.SetImageBitmap(imageBitmap);
        }

        private void FindViews()
        {
            _pieImageView = FindViewById<ImageView>(Resource.Id.pieImageView);
            _pieNameTextView = FindViewById<TextView>(Resource.Id.pieNameTextView);
            _shortDescriptionTextView = FindViewById<TextView>(Resource.Id.pieShortDescriptionTextView);
            _descriptionTextView = FindViewById<TextView>(Resource.Id.pieShortDescriptionTextValue);
            _priceTextView = FindViewById<TextView>(Resource.Id.piePriceTextView);
            _amountEditText = FindViewById<EditText>(Resource.Id.pieAmmountValue);
            _addToCartButton = FindViewById<Button>(Resource.Id.addToCartButton);
        }
    }
}