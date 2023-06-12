using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PlaygroundMAUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
        }

        private bool _bottomContentVisible = false;

        public bool BottomContentVisible
        {
            get { return _bottomContentVisible; }
            set
            {
                _bottomContentVisible = value;
                OnPropertyChanged(nameof(BottomContentVisible));
            }
        }

        private ICommand _saveCommand;

        public ICommand TapButtonCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new Command(async () =>
                    {
                        await Application.Current.MainPage.DisplayAlert("Button work", "Button worked tapped", "OK");
                    });
                }

                return _saveCommand;
            }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged
    }
}