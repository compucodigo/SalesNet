using Sales.Mobile.Models;
using Sales.Mobile.PageModels;

namespace Sales.Mobile.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}