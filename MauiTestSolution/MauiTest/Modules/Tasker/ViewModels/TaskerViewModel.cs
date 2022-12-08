using CommunityToolkit.Mvvm.Input;
using MauiTest.Modules.Tasker.Models;
using MauiTest.Modules.Tasker.Services;
using MauiTest.Modules.Tasker.Views;
using MauiTest.ViewModels;
using System.Collections.ObjectModel;

namespace MauiTest.Modules.Tasker.ViewModels;

public partial class TaskerViewModel : BaseViewModel
{
    ITaskerService _taskerService;
    public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();
    public ObservableCollection<Todo> Todos { get; set; } = new ObservableCollection<Todo>();


    public TaskerViewModel(ITaskerService taskerService)
    {
        Title = "Tasker";
        _taskerService = taskerService;
        Seeddata();
    }

    private void Seeddata()
    {
        var todos = _taskerService.GetAllTodos();
        var categories = _taskerService.GetAllCategories();

        foreach (var item in categories)
            Categories.Add(item);

        foreach (var item in todos)
            Todos.Add(item);

        UpdateData();
    }

    public void UpdateData()
    {
        foreach (var item in Categories)
        {
            var task = Todos.Where(t => t.CategorieId == item.Id);
            var completed = task.Where(t => t.Completed);
            var notCompleted = task.Where(t => !t.Completed);

            item.Pending = notCompleted.Count();
            item.Percentage = (float)completed.Count() / (float)task.Count();
        }

        foreach (var tsk in Todos)
        {
            var catColor = Categories.FirstOrDefault(c => c.Id == tsk.CategorieId)?.Color;
            tsk.TaskColor = catColor;
        }
    }

    [RelayCommand]
    public async Task AddTask()
    {
        var queryParameters = new Dictionary<string, object>()
        {
            { "Todos", Todos },
            { "Categories", Categories }
        };

        await Shell.Current.GoToAsync($"{nameof(NewTaskPage)}",
                                           true,
                                           queryParameters);

        UpdateData();
    }




}
