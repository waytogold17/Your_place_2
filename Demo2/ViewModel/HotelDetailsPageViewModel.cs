
namespace Demo2.ViewModel;
using Demo2.Services;

[QueryProperty(nameof(Hotel), nameof(Hotel))]

public partial class HotelDetailsPageViewModel : BaseViewModel
{
    IMap map;
    HotelServicecs hotelService;

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

    Task NaviguatePlus() => Shell.Current.GoToAsync(nameof(DetailsReservationPage1));


  


}

