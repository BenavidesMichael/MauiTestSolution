using CommunityToolkit.Maui;
using MauiTest.Extentions;
using Syncfusion.Maui.Core.Hosting;

namespace MauiTest
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                    fonts.AddFont("Roboto-Black.ttf", "Strong");
                })
                .AddConfiguration();

            builder.UseMauiApp<App>().UseMauiCommunityToolkit();

            return builder.Build();
        }
    }
}