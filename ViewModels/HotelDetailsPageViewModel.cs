

using hotellerie;
using hotellerie.Models;
using hotellerie.ViewModels;
using System.Diagnostics;

namespace hotellerie.ViewModels;


[QueryProperty(nameof(Hotel), nameof(Hotel))]

public partial class HotelDetailsPageViewModel :BaseViewModel3
{
    IMap map;
   

    [ObservableProperty]
    Hotel hotel;


    public HotelDetailsPageViewModel(IMap map)
    {
        this.map = map;
    }

    [RelayCommand]
    async Task OpenMap()
    {
        try
        {
            await map.OpenAsync(Hotel.Latitude, Hotel.Longitude, new MapLaunchOptions
            {
                Name = Hotel.Nom,
                NavigationMode = NavigationMode.None
            });
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to launch maps: {ex.Message}");
            await Shell.Current.DisplayAlert("Error, no Maps app!", ex.Message, "OK");
        }
    }



    [RelayCommand]

    Task NaviguatePlus() => Shell.Current.GoToAsync(nameof(hotellerie.View.DetailsReservationPage1));


  


}

