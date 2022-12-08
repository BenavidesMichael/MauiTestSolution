using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTest.Modules.Tasker.Models;

public partial class Todo : ObservableObject
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    bool completed;

    [ObservableProperty]
    string taskColor;

    [ObservableProperty]
    int categorieId;
}
