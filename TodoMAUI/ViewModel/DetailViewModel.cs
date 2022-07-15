using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TodoMAUI.ViewModel;
[QueryProperty("Text", "Text")]

public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task GoBack()
    {
        //Navigation back just like shell. Eg ../ will go up 1 level. ../../ will go up 2 levels
        await Shell.Current.GoToAsync("..");
    }
}

