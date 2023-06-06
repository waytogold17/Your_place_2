
using hotellerie.Models;
using hotellerie.ViewModels;

namespace hottellerie.ViewModels;

[QueryProperty(nameof(Hotel), nameof(Hotel))]
public partial class DetailReservationViewModel: BaseViewModel3
{

    public DetailReservationViewModel() { }

    [ObservableProperty]
    Hotel hotel;



   

}
