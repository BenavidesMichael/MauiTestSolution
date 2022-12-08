using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTest.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    string _title;

    [ObservableProperty]
    bool _isBusy;

    [ObservableProperty]
    bool isRefreshing;
}
