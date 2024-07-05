using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive;
using ToDoNotesApp.Models;
using ToDoNotesApp.Views;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;




namespace ToDoNotesApp.ViewModels
{
    public class ToDoViewModel : ReactiveObject
    {
        public ObservableCollection<TaskModel> Tasks { get; } = new ObservableCollection<TaskModel>();
        private TaskModel _selectedTask;
        public TaskModel SelectedTask
        {
            get => _selectedTask;
            set => this.RaiseAndSetIfChanged(ref _selectedTask, value);
        }

        public ReactiveCommand<Unit, Unit> AddTaskCommand { get; }
        public ReactiveCommand<Unit, Unit> EditTaskCommand { get; }
        public ReactiveCommand<Unit, Unit> DeleteTaskCommand { get; }

        public ToDoViewModel()
        {
            AddTaskCommand = ReactiveCommand.Create(AddTask);
            EditTaskCommand = ReactiveCommand.Create(EditTask);
            DeleteTaskCommand = ReactiveCommand.Create(DeleteTask);
        }

        private void AddTask()
        {
            Tasks.Add(new TaskModel { Name = "New Task", Date = DateTime.Now });
        }

        private async void EditTask()
        {
            if (SelectedTask != null)
            {
                var dialog = new EditTaskDialog
                {
                    DataContext = new EditTaskViewModel
                    {
                        Name = SelectedTask.Name,
                        Date = SelectedTask.Date,
                        IsCompleted = SelectedTask.IsCompleted
                    }
                };

                var result = await dialog.ShowDialog<EditTaskViewModel>(App.Current.MainWindow);

                if (result != null)
                {
                    SelectedTask.Name = result.Name;
                    SelectedTask.Date = result.Date;
                    SelectedTask.IsCompleted = result.IsCompleted;
                    this.RaisePropertyChanged(nameof(Tasks));
                }
            }
        }

        private void DeleteTask()
        {
            if (SelectedTask != null)
            {
                Tasks.Remove(SelectedTask);
            }
        }
    }
}
