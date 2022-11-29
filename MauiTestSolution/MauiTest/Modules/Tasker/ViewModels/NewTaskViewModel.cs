using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest.Modules.Tasker.Models;
using MauiTest.Services.Dialog;
using MauiTest.ViewModels;
using System.Collections.ObjectModel;

namespace MauiTest.Modules.Tasker.ViewModels
{
    //Majuscule
    [QueryProperty(nameof(Todos), nameof(Todos))]
    [QueryProperty(nameof(Categories), nameof(Categories))]
    public partial class NewTaskViewModel : BaseViewModel
    {
        readonly IDialogService _dialogService;
        public NewTaskViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            Title = "New Task";
        }

        [ObservableProperty]
        string newTask;

        [ObservableProperty]
        ObservableCollection<Todo> todos;

        [ObservableProperty]
        ObservableCollection<Category> categories;

        [RelayCommand]
        async void AddNewCategory()
        {
            string categoryName = await _dialogService.DisplayPromptAsync("New Category", "Write the new category Name");

            var rnd = new Random();

            if (!string.IsNullOrEmpty(categoryName))
            {
                categories.Add(new Category
                {
                    Id = categories.Max(c => c.Id) + 1,
                    Name = categoryName,
                    Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)).ToHex()
                });
            }
        }


        [RelayCommand]
        async void AddNewTask()
        {
            var selectedCategory = categories.FirstOrDefault(c => c.IsSelected);

            if (selectedCategory is not null)
            {
                if (string.IsNullOrEmpty(newTask))
                {
                    await _dialogService.ShowAlertAsync("You must write a new Task", "Error", "Ok");
                    return;
                }

                var task = new Todo
                {
                    Name = newTask,
                    CategorieId = selectedCategory.Id,
                    Completed = false,
                };

                todos.Add(task);
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                await _dialogService.ShowAlertAsync("You must select a category", "Invalid Selection", "Ok");
            }
        }
    }
}
