using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Events;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;
using BeerTopia.Models;
using Prism.AppModel;
using Prism.Mvvm;

namespace BeerDrinking.ViewModels
{
	public class BeerPageViewModel : BindableBase
	{
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
			
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
            Datum beer = (BeerTopia.Models.Datum)parameters["beer"];
            _name = beer.Name;
            _style = beer.Style.ToString();
		}
	}
}