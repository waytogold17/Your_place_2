using Demo2.ViewModel;
using Microsoft.Extensions.Logging;
using Demo2.Services;


namespace Demo2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<HotelDetailsPage>();
		builder.Services.AddSingleton<HotelsViewModel>();
		builder.Services.AddSingleton<HotelsPage>();


#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<IMap>(Map.Default);

        builder.Services.AddSingleton<HotelsViewModel>();
        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<HotelServicecs>();
        builder.Services.AddSingleton<ReservationsPage>();
        builder.Services.AddTransient<HotelDetailsPageViewModel>();
        builder.Services.AddTransient<HotelDetailsPage>();
		builder.Services.AddTransient<DetailsReservationPage1>();
		builder.Services.AddTransient<ValidationReservationPage>();
		builder.Services.AddSingleton<DeatailsReservationPageViewModel>();

        return builder.Build();
	}
}
