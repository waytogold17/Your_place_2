using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotellerie.ViewModels
{
    public partial class LoginPageViewModels: BaseViewModel
    {
        [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
        private string _userName;
        [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
        private string _password;
    }
}
