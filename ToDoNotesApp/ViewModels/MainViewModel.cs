using ReactiveUI;
using System.Reactive;
using Avalonia.Controls;
using ToDoNotesApp.Views;
using ToDoNotesApp;
using ToDoNotesApp.ViewModels;
using ToDoNotesApp.Models;
using System.Collections.ObjectModel;
using Avalonia.Markup.Xaml;
using System;

namespace ToDoNotesApp.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public ReactiveCommand<Unit, Unit> ShowNotesCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowToDoCommand { get; }

        private UserControl _currentView;
        public UserControl CurrentView
        {
            get => _currentView;
            set => this.RaiseAndSetIfChanged(ref _currentView, value);
        }

        public MainViewModel()
        {
            ShowNotesCommand = ReactiveCommand.Create(() =>
            {
                CurrentView = new NotesView();
                return Unit.Default;
            });

            ShowToDoCommand = ReactiveCommand.Create(() =>
            {
                CurrentView = new ToDoView();
                return Unit.Default;
            });

            CurrentView = new NotesView();
        }
    }
}
