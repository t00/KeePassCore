using ReactiveUI.Fody.Helpers;

namespace KeePassCore.ViewModels
{
    public class GroupTreeViewModel : ViewModelBase
    {
        [Reactive]
        public string Name { get; set; }
    }
}