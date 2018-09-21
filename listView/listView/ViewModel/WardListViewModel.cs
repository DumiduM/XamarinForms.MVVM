using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using ListViewApp.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListViewApp.ViewModel
{
    public class WardListViewModel : ViewModelBase
    {
        public ObservableCollection<WardModel> Wards = new ObservableCollection<WardModel>();
        private Service service = new Service();
        public void Initialize()
        {
            var wardData = service.SeedData();
            Wards.Clear();
            foreach(var newWard in wardData)
            {
                Wards.Add(newWard);
            }
        }



    }
}
