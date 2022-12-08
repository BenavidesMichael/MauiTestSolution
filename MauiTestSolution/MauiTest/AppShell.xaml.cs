using MauiTest.Modules.Budget.Views;
using MauiTest.Modules.Shop.Views;
using MauiTest.Modules.Tasker.Views;

namespace MauiTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.RouterShell();
        }

        private void RouterShell()
        {
            Routing.RegisterRoute(nameof(TaskerPage), typeof(TaskerPage));
            Routing.RegisterRoute(nameof(NewTaskPage), typeof(NewTaskPage));
            Routing.RegisterRoute(nameof(ProductPage), typeof(ProductPage));

            Routing.RegisterRoute(nameof(BudgetPage), typeof(BudgetPage));
            Routing.RegisterRoute(nameof(StatisticsPage), typeof(StatisticsPage));
            Routing.RegisterRoute(nameof(TransactionPage), typeof(TransactionPage));
            Routing.RegisterRoute(nameof(BudgetMenuPage), typeof(BudgetMenuPage));
        }
    }
}