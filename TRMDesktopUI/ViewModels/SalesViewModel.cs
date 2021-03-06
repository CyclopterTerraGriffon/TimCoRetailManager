﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;

        public BindingList<string> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private int _itemQuantity;

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal
        {
            get
            {
                // TODO - Replace with Calculation
                return "$0:00";
            }
        }

        public string Total
        {
            get
            {
                // TODO - Replace with Calculation
                return "$0:00";
            }
        }

        public string Tax
        {
            get
            {
                // TODO - Replace with Calculation
                return "$0:00";
            }
        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set { 
                    _cart = value;
                NotifyOfPropertyChange(() => Cart);
                }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;

                //Make Sure something is selected and item quantity > 0
                    return output;
            }
        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                //Make Sure something is selected and item quantity > 0
                    return output;
            }
        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                //Make sure something is in the cart

                return output;
            }
        }

        public void AddToCart()
        {

        }

        public void RemoveFromCart()
        {

        }

        public void CheckOut()
        {

        }

    }
}
