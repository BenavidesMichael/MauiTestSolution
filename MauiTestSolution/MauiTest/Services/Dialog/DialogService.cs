namespace MauiTest.Services.Dialog;

public class DialogService : IDialogService
{
    public Task ShowAlertAsync(string message, string title, string buttonLabel)
    {
        return Application.Current.MainPage.DisplayAlert(title, message, buttonLabel);
    }

    public async Task<string> DisplayPromptAsync(string message, string title)
    {
        return await Application.Current.MainPage.DisplayPromptAsync(title, message, maxLength: 15, keyboard: Keyboard.Text);
    }
}
