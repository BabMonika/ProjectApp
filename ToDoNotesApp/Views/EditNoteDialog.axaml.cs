using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ToDoNotesApp.Views
{
    public partial class EditNoteDialog : Window
    {
        public EditNoteDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
