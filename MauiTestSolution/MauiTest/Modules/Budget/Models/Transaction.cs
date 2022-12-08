using Humanizer;
using MauiTest.Repository;

namespace MauiTest.Modules.Budget.Models;

public partial class Transaction : TableData
{
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public bool IsIncome { get; set; }
    public DateTime OperationDate { get; set; }
    public string HumainDate { get => OperationDate.Humanize(); }
}
