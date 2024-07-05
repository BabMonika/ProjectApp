using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ToDoNotesApp.Views
{
    public partial class EditTaskDialog : Window
    {
        public EditTaskDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
