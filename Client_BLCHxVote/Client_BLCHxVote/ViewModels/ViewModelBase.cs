using System.ComponentModel;
using System.Runtime.CompilerServices;
using ReactiveUI;

namespace Client_BLCHxVote.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public new event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}