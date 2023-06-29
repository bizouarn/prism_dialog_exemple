using System;
using FullApp1.Services.Interfaces;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace FullApp1.Modules.ModuleName.ViewModels
{
    public class ViewAViewModel : BindableBase, IDialogAware
    {
        private string _message;
        private string _text = "Notification";

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(IRegionManager regionManager, IMessageService messageService)
        {
            //Text = "undefined";
            Message = messageService.GetMessage();
        }


        public bool CanCloseDialog()
        {
            //do something
            return true;
        }

        public void OnDialogClosed()
        {
            //do something
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Text = parameters.GetValue<String>("Text");
            Text = Text;
        }

        public string Title { get; }
        public event Action<IDialogResult> RequestClose;
    }
}