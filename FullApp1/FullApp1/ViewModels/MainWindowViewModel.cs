using System.ComponentModel;
using FullApp1.Services.Interfaces;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Services.Dialogs;

namespace FullApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase, INotifyPropertyChanged
    {
        private readonly IDialogService _dialogService;
        private string _title = "Prism Application";

        private string _param;

        public string Params
        {
            get => _param;
            set => SetProperty(ref _param, value);
        }

        public DelegateCommand<object> SubmitCommand { get; private set; }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IDialogService dialogService, IMessageService message)
        {
            _dialogService = dialogService;
            Params = message.GetMessage();
            SubmitCommand = new DelegateCommand<object>((object args) =>
            {
                var param = new DialogParameters
                {
                    {"Text", args}
                };
                _dialogService.ShowDialog("ViewA", param, null);
            });
        }
    }
}