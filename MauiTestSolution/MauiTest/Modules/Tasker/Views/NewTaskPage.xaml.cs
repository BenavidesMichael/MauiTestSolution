using MauiTest.Modules.Tasker.Models;
using MauiTest.Modules.Tasker.ViewModels;

namespace MauiTest.Modules.Tasker.Views;

public partial class NewTaskPage : ContentPage
{
	public NewTaskPage()
	{
		InitializeComponent();
	}

    private async void AddNewCategory(object sender, EventArgs e)
	{
        var vm = BindingContext as NewTaskViewModel;

		string categoryName = await DisplayPromptAsync("New Category", "Write the new category Name", maxLength: 15, keyboard: Keyboard.Text);

		var rnd = new Random();

		if (!string.IsNullOrEmpty(categoryName))
		{
			vm.Categories.Add(new Category
			{
				Id = vm.Categories.Max(c => c.Id) + 1,
				Name = categoryName,
				Color = Color.FromRgb(rnd.Next(0,255), rnd.Next(0, 255), rnd.Next(0, 255)).ToHex()
			});
		}
    }

    private async void AddNewTask(object sender, EventArgs e)
    {
		var vm = BindingContext as NewTaskViewModel;
		var selectedCategory = vm.Categories.FirstOrDefault(c => c.IsSelected);

		if (selectedCategory is not null)
		{
			var task = new Todo
			{
				Name = vm.NewTask,
				CategorieId = selectedCategory.Id,
				Completed = false,
			};

			vm.Todos.Add(task);
			await Navigation.PopAsync();
		}
		else
		{
			await DisplayAlert("Invalid Selection", "You must select a category", "Ok");
		}
    }
}