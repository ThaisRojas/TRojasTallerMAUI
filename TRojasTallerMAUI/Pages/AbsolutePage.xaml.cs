namespace TRojasTallerMAUI.Pages
{
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();
        }

        private async void OnGoToGridClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
