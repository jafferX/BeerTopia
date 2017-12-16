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
	public class BeerPageViewModel : BindableBase, INavigationAware
	{
		protected INavigationService _navigationService;
		private BeerApiCalls beerCaller;
		public ObservableCollection<Datum> Beer { get; set; }
		public DelegateCommand<Datum> BeerSelectedCommand { get; }


		public BeerPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			Beer = new ObservableCollection<Datum>();
			beerCaller = new BeerApiCalls();
			BeerSelectedCommand = new DelegateCommand<Datum>(OnBeerSelectedCommandExecuted);
		}


		private async void OnBeerSelectedCommandExecuted(Datum beer)
		{
			NavigationParameters navParams = new NavigationParameters();
			navParams.Add("beer", beer);
			await _navigationService.NavigateAsync("BeerDetailPage", navParams);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			beerCaller.GetSampleBeers(Beer);
			
		}
	}
}