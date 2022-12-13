using MauiTest.Modules.Budget.ViewModels;

namespace MauiTest.Modules.Budget.Views;

public partial class BudgetPage : ContentPage
{
    public BudgetPage(BudgetViewModel budgetViewModel)
	{
		InitializeComponent();
		BindingContext = budgetViewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var model = (BudgetViewModel) BindingContext;
        model.GetDataTransactions();
    }
}