



namespace Demo2.ViewModel;

[QueryProperty(nameof(Hotel), nameof(Hotel))]

public partial class HotelDetailsPageViewModel : BaseViewModel
{
    IMap map;
    public HotelDetailsPageViewModel(IMap map)
    {
        this.map = map;

    }
    [ObservableProperty]
    Hotel hotel;



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
    Task Naviguate() => Shell.Current.GoToAsync(nameof(ReservationsPage));
   
}
