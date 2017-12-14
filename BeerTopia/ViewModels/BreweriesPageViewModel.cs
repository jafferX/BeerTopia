using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerTopia.Models;
using Prism.Commands;
using BeerTopia.API;
using System.Diagnostics;

namespace BeerTopia.ViewModels
{
    class BreweriesPageViewModel: BindableBase, INavigationAware
    {
		protected INavigationService _navigationService;
		private BreweryApiCalls breweryCaller;
		public ObservableCollection<DatumB> Breweries { get; set; }
		public DelegateCommand<DatumB> BrewerySelectedCommand { get; }

		public BreweriesPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			Breweries = new ObservableCollection<DatumB>();
			BrewerySelectedCommand = new DelegateCommand<DatumB>(OnBrewerySelectedCommandExecuted);

			breweryCaller = new BreweryApiCalls();
		}


		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{

			Debug.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ hello from breweriesPageViewModel");
			breweryCaller.GetSampleBreweryList(Breweries);
			Debug.WriteLine(Breweries);
			Debug.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ hello from after api call breweriesPageViewModel");
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}

		private async void OnBrewerySelectedCommandExecuted(DatumB brewer)
		{
			NavigationParameters navParams = new NavigationParameters();
			navParams.Add("brewer", brewer);
			//await _navigationService.NavigateAsync("TabbedPage?tab=BreweryDetailPage&tab=BreweryBeersPage",  navParams);
			Debug.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Brewery selected command executed");
		}
	}
}
