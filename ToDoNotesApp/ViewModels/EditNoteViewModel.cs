using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.Reactive;

namespace ToDoNotesApp.ViewModels
{
    public class EditNoteViewModel : ReactiveObject
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }

        public ReactiveCommand<Unit, EditNoteViewModel> SaveCommand { get; }

        public EditNoteViewModel()
        {
            SaveCommand = ReactiveCommand.Create(() => this);
        }
    }
}
