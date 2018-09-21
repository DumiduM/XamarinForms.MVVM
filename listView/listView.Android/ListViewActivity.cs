
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;
using listView.Droid;
using ListViewApp.Droid;
using ListViewApp.Model;
using ListViewApp.ViewModel;

namespace ListViewApp.Droid
{
    [Activity(Label = "Wards", Icon = "@mipmap/icon")]
    public class ListViewActivity : ActivityBase
    {
        private ListView wardList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.WardListView);
            Vm.Initialize();
            WardList.Adapter = Vm.Wards.GetAdapter(GetTaskAdapter);
        }
        public ListView WardList
        {
            get
            {
                return wardList
                    ?? (wardList = FindViewById<ListView>(Resource.Id.wardListView));
            }
        }

        private WardListViewModel Vm
        {
            get
            {
                return App.Locator.WardListView;
            }
        }

        private View GetTaskAdapter(int position, WardModel wardModel, View convertView)
        {

            convertView = LayoutInflater.Inflate(
                            Resource.Layout.WardTemplate, null);

            var wardID = convertView.FindViewById<TextView>(
                          Resource.Id.WardIdText);
            var wardName = convertView.FindViewById<TextView>(
                         Resource.Id.WardNameText);

            wardID.Text = wardModel.WardID.ToString();
            wardName.Text = wardModel.WardName;

            return convertView;

        }
    }
}