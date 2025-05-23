using TRojasTallerMAUI.Pages;

namespace TRojasTallerMAUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(StackPage), typeof(StackPage));
        Routing.RegisterRoute(nameof(FlexPage), typeof(FlexPage));
        Routing.RegisterRoute(nameof(AbsolutePage), typeof(AbsolutePage));
    }
}
