using MauiTest.Modules.Tasker.Models;

namespace MauiTest.Modules.Tasker.Services;

public class TaskerService : ITaskerService
{
    public List<Category> GetAllCategories()
    {
        return new List<Category>()
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
    }

    public List<Todo> GetAllTodos()
    {
        return new List<Todo>()
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

    }
}
