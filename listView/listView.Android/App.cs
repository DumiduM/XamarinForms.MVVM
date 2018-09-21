using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Views;
using ListViewApp.ViewModel;

namespace ListViewApp.Droid
{
    public static class App
    {
        public static ViewModelLocator locator;

        public static ViewModelLocator Locator
        {
            get
            {
                if (locator == null)
                {
                    // Initialize the MVVM Light DispatcherHelper.
                    // This needs to be called on the UI thread.
                    DispatcherHelper.Initialize();

                    // Configure and register the MVVM Light NavigationService
                    var nav = new NavigationService();
                    SimpleIoc.Default.Register<INavigationService>(() => nav);
                    nav.Configure(ViewModelLocator.ListViewPageKey, typeof(ListViewActivity));

                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }
    }
}