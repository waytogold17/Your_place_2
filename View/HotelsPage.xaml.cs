
using hotellerie.ViewModels;
namespace hotellerie.View;

public partial class HotelsPage : ContentPage
{
	public  HotelsPage(HotelsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
    
}
