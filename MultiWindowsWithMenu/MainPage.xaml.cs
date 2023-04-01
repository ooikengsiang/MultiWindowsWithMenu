namespace MultiWindowsWithMenu;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void MenuFlyoutItem_Clicked(System.Object sender, System.EventArgs e)
    {
        var newWindow = new Window(new SubPage());
        Application.Current.OpenWindow(newWindow);
    }

    void NewWindowButton_Clicked(System.Object sender, System.EventArgs e)
    {
        var newWindow = new Window(new SubPage());
        Application.Current.OpenWindow(newWindow);
    }

    async void AlertButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await this.DisplayAlert("Alert", $"Alert from {nameof(MainPage)}", "OK");
    }
}
