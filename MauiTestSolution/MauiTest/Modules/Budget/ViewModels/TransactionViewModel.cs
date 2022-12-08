using CommunityToolkit.Mvvm.Input;
using MauiTest.Modules.Budget.Models;
using MauiTest.Repository;
using MauiTest.ViewModels;

namespace MauiTest.Modules.Budget.ViewModels;

public partial class TransactionViewModel : BaseViewModel
{
    public Transaction Transaction { get; set; } = new Transaction();
    IBaseRepository<Transaction> _repo;

    public TransactionViewModel(IBaseRepository<Transaction> repo)
    {
        Transaction.OperationDate = DateTime.Now;
        Title = "Transaction";
        _repo = repo;
    }


    [RelayCommand]
    async void SaveTransaction()
    {
        _repo.SaveItem(Transaction);
        await Shell.Current.Navigation.PopToRootAsync();
    }
}
