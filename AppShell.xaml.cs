using hotellerie;

using hotellerie.ViewModels;
using hotellerie.ViewModels;
using hotellerie.View;

namespace hotellerie;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(HotelDetailsPage), typeof(HotelDetailsPage));
        Routing.RegisterRoute(nameof(HotelsPage), typeof(HotelsPage));
        Routing.RegisterRoute(nameof(HotelsViewModel), typeof(HotelsViewModel));
        Routing.RegisterRoute(nameof(ReservationsPage), typeof(ReservationsPage));
        Routing.RegisterRoute(nameof(HotelDetailsPageViewModel), typeof(HotelDetailsPageViewModel));
        Routing.RegisterRoute(nameof(DetailsReservationPage1), typeof(DetailsReservationPage1));
        Routing.RegisterRoute(nameof(DeatailsReservationPageViewModel), typeof(DeatailsReservationPageViewModel));
    }
}
