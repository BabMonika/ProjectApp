using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ToDoNotesApp.ViewModels;

namespace ToDoNotesApp.Views
{
    public partial class NotesView : UserControl
    {
        public NotesView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
