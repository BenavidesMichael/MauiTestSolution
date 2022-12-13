using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest.Modules.Budget.Models;
using MauiTest.Modules.Budget.Views;
using MauiTest.Repository;
using MauiTest.ViewModels;
using System.Collections.ObjectModel;

namespace MauiTest.Modules.Budget.ViewModels
{
    public partial class BudgetViewModel : BaseViewModel
    {
        IBaseRepository<Transaction> _repo;

        #region Properties
        [ObservableProperty]
        ObservableCollection<Transaction> transactions;

        [ObservableProperty]
        decimal balance;

        [ObservableProperty]
        decimal income;

        [ObservableProperty]
        decimal expenses;
        #endregion

        public BudgetViewModel(IBaseRepository<Transaction> repo)
        {
            Title = "My Budget";
            _repo = repo;
            GetDataTransactions();
        }

        public void GetDataTransactions()
        {
            Balance = 0;
            Income = 0;
            Expenses = 0;

            var data = _repo.GetItems();
            data.OrderByDescending(dt => dt.OperationDate).ToList();
            Transactions = new ObservableCollection<Transaction>(data);

            foreach (var item in Transactions)
            {
                if (item.IsIncome)
                {
                    Income += item.Amount;
                }
                else
                {
                    Expenses += item.Amount;
                }
            }

            Balance = Income - Expenses;
        }

        #region Commands
        [RelayCommand]
        async Task AddNewTransaction()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                await Shell.Current.GoToAsync($"{nameof(TransactionPage)}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error", $"Unable to get characters : {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }

        }


        [RelayCommand]
        void Refresh()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                GetDataTransactions();
            }
            finally
            {
                IsRefreshing = false;
                IsBusy = false;
            }
        }
        #endregion
    }
}
