﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab08
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BatterDemo());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new QrScanDemo());
            };
        }
    }
}
