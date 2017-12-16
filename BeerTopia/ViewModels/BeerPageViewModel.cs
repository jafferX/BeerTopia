using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Events;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;
using BeerTopia.Models;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using BeerTopia.API;

namespace BeerDrinking.ViewModels
{
    public class BeerPageViewModel : BindableBase, INavigationAware
	{
        private BeerApiCalls beerCaller;
        public ObservableCollection<Datum> Beer { get; set; }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _style;
        public string Style
        {
            get { return _style; }
            set { SetProperty(ref _style, value); }
        }

       

		public BeerPageViewModel()
		{
			Beer = new ObservableCollection<Datum>();
            beerCaller = new BeerApiCalls();
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
            beerCaller.GetSampleBeers(Beer);
            //_name = Beer.Name;
            //_style = Beer.Style.ToString();
		}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}