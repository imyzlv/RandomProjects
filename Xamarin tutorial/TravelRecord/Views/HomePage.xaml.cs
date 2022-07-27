namespace TravelRecord.Views;

public partial class HomePage : TabbedPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new NewTravelPage());
    }
}
