using Microsoft.Maui.Controls;

namespace TRojasTallerMAUI.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnGoToStackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackPage());
    }
}
