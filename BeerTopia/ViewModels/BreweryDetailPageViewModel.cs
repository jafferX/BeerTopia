using Prism.Commands; using Prism.Mvvm; using Prism.Navigation; using System; using System.Collections.Generic; using System.Linq; using BeerTopia.Models;  namespace BeerTopia.ViewModels {
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
		}

		public BreweryDetailPageViewModel()
		{



		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			DatumB brewer = (BeerTopia.Models.DatumB)parameters["brewer"];
			_name = brewer.Name;
			_established = brewer.Established;
			_description = brewer.Description;
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	} } 