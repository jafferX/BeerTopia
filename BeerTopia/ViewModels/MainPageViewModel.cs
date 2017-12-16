using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

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

            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        private async void OnNavigateCommandExecuted(string pageName)
        {
            Debug.WriteLine(pageName);
            await _navigationService.NavigateAsync(pageName);
        }
    }
}

