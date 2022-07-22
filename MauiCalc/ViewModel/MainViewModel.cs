using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiCalc.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string result;
    }
}

