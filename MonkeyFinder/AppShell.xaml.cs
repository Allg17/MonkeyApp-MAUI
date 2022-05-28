namespace MonkeyFinder;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		//Register the pages here.
        Routing.RegisterRoute(nameof(DetailsPage),
                              typeof(DetailsPage));
    
	}
}