using MauiTest.Modules.Budget.ViewModels;
using MauiTest.Modules.Budget.Views;
using MauiTest.Modules.Shop.ViewModels;
using MauiTest.Modules.Shop.Views;
using MauiTest.Modules.Tasker.Services;
using MauiTest.Modules.Tasker.ViewModels;
using MauiTest.Modules.Tasker.Views;
using MauiTest.Repository;
using MauiTest.Services.Dialog;

namespace MauiTest.Extentions;

public static class ConfigurationExtention
{
    public static MauiAppBuilder AddConfiguration(this MauiAppBuilder builder)
    {
        // Services
        builder.Services.AddTransient<IDialogService, DialogService>();
        builder.Services.AddSingleton<ITaskerService, TaskerService>();
        builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        //Tasker
        builder.Services.AddSingleton<TaskerViewModel>();
        builder.Services.AddTransient<NewTaskViewModel>();
        builder.Services.AddSingleton<TaskerPage>();
        builder.Services.AddTransient<NewTaskPage>();
        //Shop
        builder.Services.AddSingleton<ProductViewModel>();
        builder.Services.AddSingleton<ProductPage>();
        //Budget
        builder.Services.AddSingleton<BudgetPage>();
        builder.Services.AddSingleton<BudgetViewModel>();
        builder.Services.AddSingleton<TransactionPage>();
        builder.Services.AddSingleton<TransactionViewModel>();
        builder.Services.AddSingleton<StatisticsPage>();
        builder.Services.AddSingleton<StatisticsViewModel>();

        return builder;
    }
}
