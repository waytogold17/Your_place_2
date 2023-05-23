

using Demo2.Services;
namespace Demo2.ViewModel;

public partial class HotelsViewModel : BaseViewModel
{
    public ObservableCollection<Hotel> Hotel { get; } = new();
    

     HotelServicecs hotelService;
     IConnectivity connectivity;
     IGeolocation geolocation;

    public HotelsViewModel(HotelServicecs hotelService, IConnectivity connectivity, IGeolocation geolocation)
    {
        Title = "titre ";
        this.hotelService = hotelService;
        this.connectivity = connectivity;
        this.geolocation = geolocation;
        
    }

    [RelayCommand]
    async Task GoToDetails(Hotel hotel)
    {
        if (hotel == null)
            return;

        await Shell.Current.GoToAsync(nameof(HotelDetailsPage), true, new Dictionary<string, object>
    {
        {"Hotel", hotel }
    });
    }

    

    [ObservableProperty]
    bool isRefreshing;

    [RelayCommand]
    async Task GetMonkeysAsync()
    {
        if (IsBusy)
            return;

        try
        {
            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("No connectivity!",
                    $"Please check internet and try again.", "OK");
                return;
            }

            IsBusy = true;
           
            List<Hotel> hotels = await hotelService.GetHotels();
            
            if (Hotel.Count != 0)
                Hotel.Clear(); 

            foreach (var hotel in Hotel)
                Hotel.Add(hotel);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }

    }

    [RelayCommand]
    async Task GetHotel()
    {
        if (IsBusy || Hotel.Count == 0)
            return;

        try
        {
            // Get cached location, else get real location.
            var location = await geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });
            }

            // Find closest monkey to us
            var first = Hotel.OrderBy(m => location.CalculateDistance(
                new Location(m.Latitude, m.Longitude), DistanceUnits.Miles))
                .FirstOrDefault();

            await Shell.Current.DisplayAlert("", first.Nom + " " +
                first.Nom, "OK");

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to query location: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
    

}
}

