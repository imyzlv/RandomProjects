using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FishinLogs.ViewModel;

public partial class HomeViewModel : ObservableObject
{
    public HomeViewModel()
    {
        Fish = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> fish;

    [ObservableProperty]
    string species;

    [ObservableProperty]
    string length;

    [ObservableProperty]
    string weight;

    [ObservableProperty]
    string lure;

    [ObservableProperty]
    string fishingMethod;

    [ObservableProperty]
    string comment;

    [RelayCommand]
    async Task AddRecord()
    {
        if (string.IsNullOrWhiteSpace(Species) || string.IsNullOrWhiteSpace(Lure))
        {
            return;
        }
        await FishinLogs.Services.CatchService.AddCatch(species, Convert.ToDouble(length), Convert.ToDouble(weight), lure, fishingMethod, "picture", comment);
        ResetInputFields();
    }

    private void ResetInputFields()
    {
        Species = string.Empty;
        Length = string.Empty;
        Weight = string.Empty;
        Lure = string.Empty;
        FishingMethod = string.Empty;
        Comment = string.Empty;
    }
}


