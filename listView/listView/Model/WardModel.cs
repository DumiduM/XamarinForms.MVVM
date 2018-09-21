using GalaSoft.MvvmLight;

namespace ListViewApp.Model
{
    public class WardModel : ObservableObject
    {
        public WardModel()
        {
        }

        public int WardID { get; set; }
        public string WardName { get; set; }

    }
}

