using MauiTest.Modules.Budget.ViewModels;

namespace MauiTest.Modules.Budget.Views;

public partial class StatisticsPage : ContentPage
{
    public StatisticsPage(StatisticsViewModel statisticsViewModel)
	{
		InitializeComponent();
		BindingContext = statisticsViewModel;
	}
}