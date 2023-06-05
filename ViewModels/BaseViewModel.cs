using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotellerie.ViewModels
{
    public partial class BaseViewModel: CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
        public bool _isBusy;
        [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
        public string _title;
    }
}
