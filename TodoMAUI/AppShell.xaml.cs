namespace TodoMAUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // register detail page route
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
}

