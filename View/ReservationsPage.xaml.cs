namespace hotellerie.View;

public partial class ReservationsPage : ContentPage
{
	public ReservationsPage()
	{
		InitializeComponent();
	}

    Task Back => Shell.Current.GoToAsync("");
}