using System.ComponentModel;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Services.Dialogs;

namespace FullApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase, INotifyPropertyChanged
    {
        private readonly IDialogService _dialogService;
        private string _title = "Prism Application";
        public string Params { get; set; }

        public DelegateCommand<object> SubmitCommand { get; private set; }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IDialogService dialogService)
        {
            Params = "NULL";
            _dialogService = dialogService;
            SubmitCommand = new DelegateCommand<object>((object args)=> {
                var param = new DialogParameters {
                    { "Text",args }
                };
                _dialogService.ShowDialog("ViewA",param,null);
            });
        }


    }
}
