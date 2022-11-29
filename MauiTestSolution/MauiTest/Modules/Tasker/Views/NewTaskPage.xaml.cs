using MauiTest.Modules.Tasker.ViewModels;

namespace MauiTest.Modules.Tasker.Views;

public partial class NewTaskPage : ContentPage
{
    public NewTaskPage(NewTaskViewModel newTaskViewModel)
    {
        InitializeComponent();
        BindingContext = newTaskViewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}