using Demo2.ViewModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Threading.Tasks;
namespace Demo2;

public partial class HotelDetailsPage : ContentPage
{
  

    public HotelDetailsPage(HotelDetailsPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
       
    }
   
   
}



