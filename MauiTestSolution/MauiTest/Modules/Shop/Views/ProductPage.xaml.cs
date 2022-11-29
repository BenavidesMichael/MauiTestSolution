using MauiTest.Modules.Shop.ViewModels;

namespace MauiTest.Modules.Shop.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage(ProductViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}