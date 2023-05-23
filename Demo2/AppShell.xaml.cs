using Demo2.ViewModel;
namespace Demo2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HotelDetailsPage), typeof(HotelDetailsPage));
		Routing.RegisterRoute(nameof(HotelsPage), typeof(HotelsPage));
		Routing.RegisterRoute(nameof(HotelsViewModel),typeof(HotelsViewModel));
	}
}
