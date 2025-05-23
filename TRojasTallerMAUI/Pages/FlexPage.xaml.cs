namespace TRojasTallerMAUI.Pages;

public partial class FlexPage : ContentPage
{
    public FlexPage()
    {
        InitializeComponent();
    }

    private async void OnGoToAbsoluteClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AbsolutePage));
    }
}


