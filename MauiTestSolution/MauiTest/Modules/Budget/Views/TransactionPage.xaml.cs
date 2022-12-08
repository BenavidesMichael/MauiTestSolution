using MauiTest.Modules.Budget.ViewModels;

namespace MauiTest.Modules.Budget.Views;

public partial class TransactionPage : ContentPage
{
	public TransactionPage(TransactionViewModel transactionViewModel)
	{
		InitializeComponent();
		BindingContext = transactionViewModel;
	}
}