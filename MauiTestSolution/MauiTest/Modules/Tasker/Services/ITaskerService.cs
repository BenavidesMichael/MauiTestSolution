using MauiTest.Modules.Tasker.Models;

namespace MauiTest.Modules.Tasker.Services;

public interface ITaskerService
{
    List<Category> GetAllCategories();
    List<Todo> GetAllTodos();
}
