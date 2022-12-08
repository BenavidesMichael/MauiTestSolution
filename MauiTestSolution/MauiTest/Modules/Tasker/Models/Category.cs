using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTest.Modules.Tasker.Models;

public partial class Category : ObservableObject
{
    [ObservableProperty]
    int id;

    [ObservableProperty]
    string name;

    [ObservableProperty]
    string color;

    [ObservableProperty]
    int pending;

    [ObservableProperty]
    float percentage;

    [ObservableProperty]
    bool isSelected;
}
