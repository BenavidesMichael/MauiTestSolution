using MauiTest.Modules.Shop.Views;
using MauiTest.Modules.Shop.ViewModels;
using MauiTest.Modules.Tasker.Views;
using MauiTest.Modules.Tasker.ViewModels;
using MauiTest.Services.Dialog;

namespace MauiTest.Extentions
{
    public static class ConfigurationExtention
    {
        public static MauiAppBuilder AddConfiguration(this MauiAppBuilder builder)
        {
            //Services
            builder.Services.AddTransient<IDialogService, DialogService>();

            //Tasker
            builder.Services.AddSingleton<TaskerViewModel>();
            builder.Services.AddTransient<NewTaskViewModel>();
            builder.Services.AddSingleton<TaskerPage>();
            builder.Services.AddTransient<NewTaskPage>();
            //Shop
            builder.Services.AddSingleton<ProductViewModel>();
            builder.Services.AddSingleton<ProductPage>();


            return builder;
        }
    }
}
