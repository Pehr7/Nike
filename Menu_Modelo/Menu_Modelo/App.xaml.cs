﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu_Modelo.View;

namespace Menu_Modelo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MasterPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
