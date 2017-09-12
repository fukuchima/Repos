﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace c1x_FlexGrid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // ライセンス設定
            C1.Xamarin.Forms.Core.LicenseManager.Key = License.Key;

            MainPage = new NavigationPage(new  c1x_FlexGrid.CustomerRequestView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
