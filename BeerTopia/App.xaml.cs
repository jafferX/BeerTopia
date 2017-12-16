using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Unity;
using BeerTopia.Views;
using Xamarin.Forms;
using System.Diagnostics;
using BeerTopia.API;
using BeerTopia.Models;
using System.Collections.ObjectModel;

namespace BeerTopia
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
           
            await NavigationService.NavigateAsync("MainPage/NavigationPage/WelcomeScreen");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<BreweryDetailPage>();
			Container.RegisterTypeForNavigation<BreweriesPage>();
			Container.RegisterTypeForNavigation<BeerPage>();
            Container.RegisterTypeForNavigation<BeerDetailPage>();
            Container.RegisterTypeForNavigation<WelcomeScreen>();
		}
    }
}

