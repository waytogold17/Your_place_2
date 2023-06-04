using Demo2.ViewModel;
namespace Demo2;

public partial class HotelsPage : ContentPage
{
	public  HotelsPage(HotelsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
    
}
