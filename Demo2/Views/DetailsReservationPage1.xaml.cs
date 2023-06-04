namespace Demo2;


public partial class DetailsReservationPage1 : ContentPage
{
    List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
    public int number = 1;
    public int Convertible;

    

  
    public DetailsReservationPage1(DeatailsReservationPageViewModel viewModel) 
    {
        InitializeComponent();
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

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        if(!validation.IsChecked)
        {
            validation.IsChecked = true;
        }
        
    }
    private void numberPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedNumber = (int)numberPicker.SelectedItem;
        number = selectedNumber;
        

        // Utilisez la valeur sélectionnée (selectedNumber) dans votre logique
    }

    private void Result(object sender, EventArgs e)
    {
        Convertible = Convert.ToInt32(lasource.Text);
        lacible.Text = (number * Convertible).ToString();
    }

 



}