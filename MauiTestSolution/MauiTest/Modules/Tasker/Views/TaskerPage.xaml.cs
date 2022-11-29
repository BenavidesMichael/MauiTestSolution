using MauiTest.Modules.Tasker.ViewModels;

namespace MauiTest.Modules.Tasker.Views;

public partial class TaskerPage : ContentPage
{
    private TaskerViewModel _taskerViewModel;

    public TaskerPage(TaskerViewModel taskerViewModel)
    {
        InitializeComponent();
        BindingContext = taskerViewModel;
        _taskerViewModel = taskerViewModel;
    }

    private void checkboxTask_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _taskerViewModel.UpdateData();
    }
}