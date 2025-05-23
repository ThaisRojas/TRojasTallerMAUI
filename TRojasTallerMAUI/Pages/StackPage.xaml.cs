namespace TRojasTallerMAUI.Pages;

public partial class StackPage : ContentPage
{
    public StackPage()
    {
        InitializeComponent();
    }

    private async void OnGoToFlexClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(FlexPage));
    }
}

