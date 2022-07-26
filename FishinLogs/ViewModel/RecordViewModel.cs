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
            var fishes = new List<Catch>();
            //fishes
            //Fish = new ObservableCollection<IEnumerable<Catch>>();
            //Fish.Add(Services.CatchService.GetCatch());
        }

        //[ObservableProperty]
        //ObservableCollection<IEnumerable<Catch>> fish;
    }
}

