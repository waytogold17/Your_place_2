using hotellerie.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotellerie.ViewModels
{
    public partial class MainPageViewModel
    {
        private INavigation _navigationService;
        public MainPageViewModel(INavigation navigation) 
        {
            this._navigationService = navigation;
        }
        //[RelayCommand]

        public async void NavigateToConnexionpage()
        {
            await _navigationService.PushAsync(new Connexionpage());
        }
    }
}
