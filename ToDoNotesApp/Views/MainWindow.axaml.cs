using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ToDoNotesApp.ViewModels;

namespace ToDoNotesApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
