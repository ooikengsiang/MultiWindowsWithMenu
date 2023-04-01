namespace MultiWindowsWithMenu;

public partial class SubPage : ContentPage
{
    public SubPage()
    {
        InitializeComponent();
    }

    async void AlertButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await this.DisplayAlert("Alert", $"Alert from {nameof(SubPage)}", "OK");
    }
}
