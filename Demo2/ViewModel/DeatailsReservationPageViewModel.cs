using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.ViewModel;

[QueryProperty(nameof(Hotel), nameof(Hotel))]

public partial class DeatailsReservationPageViewModel : BaseViewModel
{
    
    public ObservableCollection<Hotel> Hotels { get; set; }
    public Hotel SelectedHotel { get; set; }

    [ObservableProperty]
    Hotel hotel;


    public DateTime currentDate;
    public DateTime CurrentDate

    {
        get { return currentDate; }
        set
        {
            currentDate = value;
            OnPropertyChanged();
        }
    }
    public DeatailsReservationPageViewModel( ) 
    {
        currentDate = DateTime.Today;
        Hotels = new ObservableCollection<Hotel>();
        
       

    }

    [RelayCommand]
    async Task NaviguatePlus() => await Shell.Current.GoToAsync(nameof(ValidationReservationPage));

}
