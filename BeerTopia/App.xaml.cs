using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Unity;
using BeerTopia.Views;
using Xamarin.Forms;
using System.Diagnostics;

namespace BeerTopia
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainPage/NavigationPage/BreweriesPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<BreweryDetailPage>();
			Container.RegisterTypeForNavigation<BreweriesPage>();
			Container.RegisterTypeForNavigation<BeerPage>();
		}
    }
}

