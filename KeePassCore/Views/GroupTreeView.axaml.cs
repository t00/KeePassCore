using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using KeePassCore.ViewModels;
using ReactiveUI;

namespace KeePassCore.Views
{
    public class GroupTreeView : ReactiveUserControl<GroupTreeViewModel>
    {
        public GroupTreeView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}