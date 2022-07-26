using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using FishinLogs.Model;

namespace FishinLogs.ViewModel
{
    public partial class RecordViewModel : ObservableObject
    {
        public RecordViewModel()
        {
            fishes.ItemSource = Services.CatchService.GetCatch();
            //Fish = new ObservableCollection<IEnumerable<Catch>>();
            //Fish.Add(Services.CatchService.GetCatch());
        }

        //[ObservableProperty]
        //ObservableCollection<IEnumerable<Catch>> fish;
    }
}

