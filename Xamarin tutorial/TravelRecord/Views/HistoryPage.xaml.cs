using TravelRecord.Services;

namespace TravelRecord.Views;

public partial class HistoryPage : ContentPage
{
	public HistoryPage()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        var posts = await DbService.GetExperience();
        postListView.ItemsSource = posts;
    }
}
