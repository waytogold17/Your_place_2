namespace Demo2;


public partial class ReservationTabbedPage : TabbedPage
{
    
    public ReservationTabbedPage()
	{
        InitializeComponent();
        Children.Add(new DetailsReservationPage1());
        Children.Add(new ValidationReservationPage());
    }
}