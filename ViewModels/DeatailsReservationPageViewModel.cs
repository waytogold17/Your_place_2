using hotellerie;
using hotellerie.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotellerie.View;
namespace hotellerie.ViewModels;
using hotellerie.Models;
using System.Collections.ObjectModel;

[QueryProperty(nameof(Hotel), nameof(Hotel))]

public partial class DeatailsReservationPageViewModel : BaseViewModel3
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
