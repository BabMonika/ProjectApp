using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.Reactive;

namespace ToDoNotesApp.ViewModels
{
    public class EditTaskViewModel : ReactiveObject
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set => this.RaiseAndSetIfChanged(ref _date, value);
        }

        private bool _isCompleted;
        public bool IsCompleted
        {
            get => _isCompleted;
            set => this.RaiseAndSetIfChanged(ref _isCompleted, value);
        }

        public ReactiveCommand<Unit, EditTaskViewModel> SaveCommand { get; }

        public EditTaskViewModel()
        {
            SaveCommand = ReactiveCommand.Create(() => this);
        }
    }
}
