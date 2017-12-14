using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BeerTopia.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
		protected INavigationService _navigationService;
		protected IPageDialogService _pageDialogService;

		public DelegateCommand<string> NavigateCommand { get; }


		public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService )
        {
            _pageDialogService = pageDialogService;
			_navigationService = navigationService;
            //Title = Resources.MainPageTitle;

            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }


		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			throw new NotImplementedException();
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			throw new NotImplementedException();
		}

		public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        private async void OnNavigateCommandExecuted(string pageName)
        {
            try
            {
                await _navigationService.NavigateAsync($"NavigationPage/{pageName}");
            }
            catch (Exception ex)
            {
                await _pageDialogService.DisplayAlertAsync(ex.GetType().Name, ex.Message, "Ok");
            }
        }
    }
}

