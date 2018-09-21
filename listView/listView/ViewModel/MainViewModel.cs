using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private RelayCommand navigateCommand;
        private readonly INavigationService navigationService;


        public MainViewModel(INavigationService navigationService)
        {
  
            this.navigationService = navigationService;

        }

        
        public RelayCommand NavigateCommand
        {
            get
            {
                return navigateCommand
                    ?? (navigateCommand = new RelayCommand(() => navigationService.NavigateTo(
                            ViewModelLocator.ListViewPageKey)));
            }
        }

        
    }
}
