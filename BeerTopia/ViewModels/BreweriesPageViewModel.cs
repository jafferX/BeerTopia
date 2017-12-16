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
    public class BreweriesPageViewModel: BindableBase, INavigationAware
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
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
			breweryCaller.GetSampleBreweryList(Breweries);
		}

		private async void OnBrewerySelectedCommandExecuted(DatumB brewer)
		{
			NavigationParameters navParams = new NavigationParameters();
			navParams.Add("brewer", brewer);
			await _navigationService.NavigateAsync("BreweryDetailPage",  navParams);
		}
	}
}
