using System;
using Android.App;
using Android.Content.PM;
using Android.Widget;
using Android.OS;
using Android.Views;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;
using ListViewApp.ViewModel;
using ListViewApp.Droid;
using listView.Droid;

namespace ListViewApp.Droid
{
    [Activity(Label = "listView", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : ActivityBase
    {
        private readonly List<Binding> bindings = new List<Binding>();
        private Button navigationButton;
       

        

        public object NavigateButton
        {
            get
            {
                return navigationButton ?? (navigationButton = FindViewById<Button>(Resource.Id.navigationButton));
            }
            

        }

        private MainViewModel ViewModel
        {
            get
            {
                return App.Locator.Main;
            }
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            NavigateButton.SetCommand(
                "Click",ViewModel.NavigateCommand);
        }
    }
}