using CommunityToolkit.Mvvm.Input;
using MauiTest.Modules.Tasker.Models;
using MauiTest.Modules.Tasker.Views;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace MauiTest.Modules.Tasker.ViewModels;

[AddINotifyPropertyChangedInterface]
public partial class TaskerViewModel
{
    public ObservableCollection<Category> Categories { get; set; }
    public ObservableCollection<Todo> Todos { get; set; }

    public TaskerViewModel()
    {
        Seeddata();
        Todos.CollectionChanged += todosUpdateListCollectionChanged;
    }

    private void todosUpdateListCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        UpdateData();
    }

    private void Seeddata()
    {
        Categories = new ObservableCollection<Category>()
        {
            new Category()
            {
                Id = 1,
                Name= ".Net Maui Test",
                Color = "#CF14DF"
            },
            new Category()
            {
                Id = 2,
                Name= ".Net 7",
                Color = "#df6f14"
            },
            new Category()
            {
                Id = 3,
                Name= "Ef core",
                Color = "#14df80"
            }
        };

        Todos = new ObservableCollection<Todo>()
        {
            new Todo()
            {
                Name = "CollectionView tamplate",
                Completed= false,
                CategorieId= 1,
            },
            new Todo()
            {
                Name = "Task 2",
                Completed= true,
                CategorieId= 2,
            },
            new Todo()
            {
                Name = "Task 3",
                Completed= false,
                CategorieId= 3,
            },
            new Todo()
            {
                Name = "Task 4",
                Completed= false,
                CategorieId= 1,
            },
            new Todo()
            {
                Name = "Task 5",
                Completed= false,
                CategorieId= 2,
            }
        };

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
