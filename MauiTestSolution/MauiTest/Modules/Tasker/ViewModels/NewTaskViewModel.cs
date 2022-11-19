using MauiTest.Modules.Tasker.Models;
using System.Collections.ObjectModel;

namespace MauiTest.Modules.Tasker.ViewModels
{
    public class NewTaskViewModel
    {
        public string NewTask { get; set; }
        public ObservableCollection<Todo> Todos { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
    }
}
