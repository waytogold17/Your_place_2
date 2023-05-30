using Demo2.ViewModel;

namespace Demo2;

public partial class HotelDetailsPage : ContentPage
{
	public HotelDetailsPage(HotelDetailsPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		
    }
    


    Task Back => Shell.Current.GoToAsync("");
}