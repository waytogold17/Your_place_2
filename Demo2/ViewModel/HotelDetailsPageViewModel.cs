
namespace Demo2.ViewModel;

[QueryProperty(nameof(Hotel), nameof(Hotel))]

public partial class HotelDetailsPageViewModel : BaseViewModel
{
    IMap map;
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



    public HotelDetailsPageViewModel(IMap map)
    {
        this.map = map;
        currentDate = DateTime.Today;

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
    async Task NaviguateNow() => await Shell.Current.GoToAsync(nameof(DetailsReservationPage1));

    [RelayCommand]
    async Task NaviguatePlus() => await Shell.Current.GoToAsync(nameof(ValidationReservationPage));


}

