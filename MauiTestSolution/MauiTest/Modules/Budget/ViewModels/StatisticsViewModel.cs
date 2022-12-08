using CommunityToolkit.Mvvm.ComponentModel;
using MauiTest.Modules.Budget.Models;
using MauiTest.Repository;
using MauiTest.ViewModels;
using System.Collections.ObjectModel;

namespace MauiTest.Modules.Budget.ViewModels
{
    public partial class StatisticsViewModel : BaseViewModel
    {
        IBaseRepository<Transaction> _repo;

        [ObservableProperty]
        ObservableCollection<TransactionSummary> summaries;

        [ObservableProperty]
        ObservableCollection<Transaction> spendingList;

        public StatisticsViewModel(IBaseRepository<Transaction> repo)
        {
            Title = "Statistics";
            _repo = repo;
            GetTransactionsSummary();
        }


        void GetTransactionsSummary()
        {
            var data = _repo.GetItems();
            var result = new List<TransactionSummary>();
            var groupedTransactions = data.GroupBy(t => t.OperationDate.Date)
                                          .Select(s => new TransactionSummary()
                                          {
                                              TransactionDate = s.Key,
                                              TransactionTotal = s.Sum(money => money.IsIncome ? money.Amount : -money.Amount),
                                              ShownDate = s.Key.ToString("dd/MM")
                                          });
            result.AddRange(groupedTransactions);
            result = result.OrderBy(x => x.TransactionDate).ToList();
            summaries = new ObservableCollection<TransactionSummary>(result);


            var spendingData = data.Where(x => !x.IsIncome);
            SpendingList = new ObservableCollection<Transaction>(spendingData);
        }
    }
}
