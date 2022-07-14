using GalaSoft.MvvmLight;

namespace GitVaisgur.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _appName;

        public string AppName
        {
            get
            {
                return _appName;
            }
            set
            {
                Set(ref _appName, value);
            }
        }

        public MainViewModel()
        {
            AppName = "GitVaisgur made by Alon Vaisgur";
        }
    }
}
