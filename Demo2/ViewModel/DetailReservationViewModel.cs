
namespace Demo2.ViewModel;

[QueryProperty(nameof(Hotel), nameof(Hotel))]
public partial class DetailReservationViewModel: BaseViewModel
{

    public DetailReservationViewModel() { }

    [ObservableProperty]
    Hotel hotel;



   

}
