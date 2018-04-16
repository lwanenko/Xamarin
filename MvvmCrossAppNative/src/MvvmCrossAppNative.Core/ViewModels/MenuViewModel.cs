using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAppNative.Core.ViewModels.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossAppNative.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowPlanetsCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<LoginViewModel>());
            ShowPeopleCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<LoginViewModel>());
            ShowStatusCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<LoginViewModel>());
        }

        // MvvmCross Lifecycle

        // MVVM Properties

        // MVVM Commands
        public IMvxCommand ShowStatusCommand { get; private set; }
        public IMvxCommand ShowPlanetsCommand { get; private set; }
        public IMvxCommand ShowPeopleCommand { get; private set; }

        // Private methods
    }
}
