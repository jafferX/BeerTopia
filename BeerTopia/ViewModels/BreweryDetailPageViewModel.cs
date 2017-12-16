using Prism.Commands; using Prism.Mvvm; using Prism.Navigation; using System; using System.Collections.Generic; using System.Linq; using BeerTopia.Models; using System.Diagnostics;
using Xamarin.Forms;

namespace BeerTopia.ViewModels {
	public class BreweryDetailPageViewModel : BindableBase, INavigationAware
	{

		private string _name;
		public string Name
		{
			get { return _name; }
			set { SetProperty(ref _name, value); }
		}

		private string _established;
		public string Established
		{
			get { return _established; }
			set { SetProperty(ref _established, value); }
		}

		private string _description;
		public string Description
		{
			get { return _description; }
			set { SetProperty(ref _description, value); }
		}         private DatumB _model;
        public DatumB Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }         }
		public BreweryDetailPageViewModel()
		{
		

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
            
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			Model = parameters.GetValue<DatumB>("brewer");             //_name = brewer.Name;             //_established = brewer.Established;             //_description = brewer.Description;             Debug.WriteLine("@@@@@@@@ @@@@@@@@@@@@@@@@@@@@@@@");
		}
	} } 