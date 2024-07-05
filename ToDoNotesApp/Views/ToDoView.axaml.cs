using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ToDoNotesApp.ViewModels;

namespace ToDoNotesApp.Views
{
    public partial class ToDoView : UserControl
    {
        public ToDoView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
