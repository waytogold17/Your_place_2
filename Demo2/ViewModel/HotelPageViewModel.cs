

using Demo2.Services;
namespace Demo2.ViewModel;

public partial class HotelsViewModel : BaseViewModel
{

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



   
}

