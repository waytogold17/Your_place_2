using hotellerie.ViewModels;
using hottellerie.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Threading.Tasks;
namespace hotellerie.View;

public partial class HotelDetailsPage : ContentPage
{
  

    public HotelDetailsPage(HotelDetailsPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
       
    }
   
   
}



