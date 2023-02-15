﻿using iscaBar.DAO.Servidor;
using iscaBar.Services;
using iscaBar.ViewModels;
using iscaBar.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iscaBar
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new ListOrdersView());
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
