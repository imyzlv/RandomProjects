using CommunityToolkit.Mvvm.ComponentModel;
using TravelRecord.Views;

namespace TravelRecord;

public partial class MainPage : ContentPage
{
    int count = 0;
    //[ObservableObject]
    public MainPage()
    {
        InitializeComponent();
    }

    void LoginButton_Clicked(System.Object sender, System.EventArgs e)
    {
        bool isEmailEmpty = string.IsNullOrWhiteSpace(emailEntry.Text);
        bool isPasswordEmpty = string.IsNullOrWhiteSpace(passwordEntry.Text);
        if (isEmailEmpty || isPasswordEmpty)
        {

        }
        else
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}


