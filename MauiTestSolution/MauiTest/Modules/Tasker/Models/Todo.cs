using PropertyChanged;

namespace MauiTest.Modules.Tasker.Models;

[AddINotifyPropertyChangedInterface]
public class Todo
{
    public string Name { get; set; }
    public bool Completed { get; set; }
    public string TaskColor { get; set; }
    public int CategorieId { get; set; }
}
