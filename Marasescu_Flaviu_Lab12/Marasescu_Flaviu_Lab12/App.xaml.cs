﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Marasescu_Flaviu_Lab12.Data;

namespace Marasescu_Flaviu_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            //  InitializeComponent();

            //  MainPage = new MainPage();
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
