using MauiTest.Modules.Tasker.ViewModels;

namespace MauiTest.Modules.Tasker.Views;

public partial class TaskerPage : ContentPage
{
	private TaskerViewModel _taskerViewModel = new TaskerViewModel();

    public TaskerPage()
	{
		InitializeComponent();
		BindingContext = _taskerViewModel;
    }

    private void checkboxTask_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _taskerViewModel.UpdateData();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Passer en param les data qui son dans la page principal ver le Add
        var newTask = new NewTaskPage()
        {
            BindingContext = new NewTaskViewModel()
            {
                Todos= _taskerViewModel.Todos,
                Categories = _taskerViewModel.Categories,
            },
        };

        await Navigation.PushAsync(newTask);
    }
}