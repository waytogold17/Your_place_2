namespace Demo2;


public partial class DetailsReservationPage1 : ContentPage
{
   
    public DetailsReservationPage1()
    {
        InitializeComponent();
    }

    public DetailsReservationPage1(HotelDetailsPageViewModel viewModel) : this()
    {
        BindingContext = viewModel;

      
    }
    private void StartDate_DateSelected(object sender, DateChangedEventArgs e)
    {
       
            if (endDate.Date < startDate.Date )
            {
                endDate.Date = startDate.Date;
            }
            
        
        TimeSpan timeSpan = endDate.Date - startDate.Date;
        label.Text = $"Nombre total de jour: {timeSpan.Days}";
    }




}