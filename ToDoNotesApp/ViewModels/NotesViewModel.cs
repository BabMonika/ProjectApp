using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;
using ToDoNotesApp.Models;
using ToDoNotesApp.Views;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace ToDoNotesApp.ViewModels
{
    public class NotesViewModel : ReactiveObject
    {
        public ObservableCollection<Note> Notes { get; } = new ObservableCollection<Note>();
        private Note _selectedNote;
        public Note SelectedNote
        {
            get => _selectedNote;
            set => this.RaiseAndSetIfChanged(ref _selectedNote, value);
        }


        public ReactiveCommand<Unit, Unit> AddNoteCommand { get; }
        public ReactiveCommand<Unit, Unit> EditNoteCommand { get; }
        public ReactiveCommand<Unit, Unit> DeleteNoteCommand { get; }

        public NotesViewModel()
        {
            AddNoteCommand = ReactiveCommand.Create(AddNote);
            EditNoteCommand = ReactiveCommand.Create(EditNote);
            DeleteNoteCommand = ReactiveCommand.Create(DeleteNote);
        }

        private void AddNote()
        {
            Notes.Add(new Note { Title = "New Note", Description = "Description" });
        }

        private async void EditNote()
        {
            if (SelectedNote != null)
            {
                var dialog = new EditNoteDialog
                {
                    DataContext = new EditNoteViewModel
                    {
                        Title = SelectedNote.Title,
                        Description = SelectedNote.Description
                    }
                };

                var result = await dialog.ShowDialog<EditNoteViewModel>(App.Current.MainWindow);

                if (result != null)
                {
                    SelectedNote.Title = result.Title;
                    SelectedNote.Description = result.Description;
                    this.RaisePropertyChanged(nameof(Notes));
                }
            }
        }

        private void DeleteNote()
        {
            if (SelectedNote != null)
            {
                Notes.Remove(SelectedNote);
            }
        }
    }
}
