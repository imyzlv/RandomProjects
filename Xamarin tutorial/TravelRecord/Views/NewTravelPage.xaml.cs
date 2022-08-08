using TravelRecord.Models;
using TravelRecord.Services;
namespace TravelRecord.Views;

public partial class NewTravelPage : ContentPage
{

	public NewTravelPage()
	{
		InitializeComponent();
	}

    async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
    {
        Post post = new Post()
        {
            Experience = experienceEntry.Text
        };

        int id = await DbService.AddExperience(post);
        experienceEntry.Text = string.Empty;
        if(id > 0)
        {
            DisplayAlert("Success", "Experience successfully inserted", "OK");
        }
        else
        {
            DisplayAlert("Failure", "Experience was not inserted", "OK");
        }
    }
}
