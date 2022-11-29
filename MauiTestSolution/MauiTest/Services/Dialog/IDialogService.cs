namespace MauiTest.Services.Dialog;

public interface IDialogService
{
    Task<string> DisplayPromptAsync(string message, string title);
    Task ShowAlertAsync(string message, string title, string buttonLabel);
}
