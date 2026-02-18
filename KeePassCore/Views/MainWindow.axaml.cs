using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using KeePassCore.ViewModels;
using ReactiveUI;

namespace KeePassCore.Views
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {   
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}