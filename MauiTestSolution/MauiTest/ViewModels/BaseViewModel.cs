using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTest.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    string _title;
}
