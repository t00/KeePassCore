using ReactiveUI;

namespace KeePassCore.ViewModels
{
    public class ViewModelBase : ReactiveObject, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();
    }
}