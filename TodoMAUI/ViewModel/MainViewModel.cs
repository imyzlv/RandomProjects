using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TodoMAUI.ViewModel;

public partial class MainViewModel : ObservableObject
{
    IConnectivity connectivity;
    public MainViewModel(IConnectivity connectivity)
    {
        Items = new ObservableCollection<string>();
        this.connectivity = connectivity;
        Refresh();
    }
    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
        {
            return;
        }
        if (connectivity.NetworkAccess != NetworkAccess.Internet)
        {
            await Shell.Current.DisplayAlert("Oh, oh!", "No internet", "OK");
            return;
        }
        await TodoMAUI.Services.TodoService.AddTask(Text, Text, 1, false);
        //Items.Add(Text);
        await Refresh();
        Text = string.Empty;
    }
    async Task Refresh()
    {
        //Items.Clear();
        var tasks = await TodoMAUI.Services.TodoService.GetTask();
        foreach (var i in tasks)
        {
            if (!Items.Contains(i.Title.ToString()))
            {
                Items.Add(i.Title.ToString());
            }
        }
    }

    [RelayCommand]
    async Task Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
            //Items.
            await TodoMAUI.Services.TodoService.RemoveTask(s);
        }
    }

    [RelayCommand]
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
    }
}

