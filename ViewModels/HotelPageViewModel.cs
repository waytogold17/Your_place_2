using hotellerie.Models;
using hotellerie.Services;
using hotellerie.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace hotellerie.ViewModels;

public partial class HotelsViewModel : BaseViewModel3
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

