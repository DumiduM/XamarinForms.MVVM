using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using ListViewApp.ViewModel;

namespace ListViewApp.ViewModel
{
    public class ViewModelLocator
    {
        public const string ListViewPageKey = "ListViewPage";

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<WardListViewModel>();
        }

        

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public WardListViewModel WardListView
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WardListViewModel>();
            }
        }

        public static void Cleanup()
        {

        }



    }

    
}

