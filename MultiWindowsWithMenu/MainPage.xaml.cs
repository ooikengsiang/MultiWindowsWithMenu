﻿namespace MultiWindowsWithMenu;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void MenuFlyoutItem_Clicked(System.Object sender, System.EventArgs e)
    {
        var newWindow = new Window(new SubPage());
        Application.Current.OpenWindow(newWindow);
    }
}
