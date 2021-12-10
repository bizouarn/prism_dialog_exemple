using FullApp1.Modules.ModuleName;
using FullApp1.Modules.ModuleName.Views;
using FullApp1.Services;
using FullApp1.Services.Interfaces;
using FullApp1.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;

namespace FullApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register the Dialog and allow the ViewModelLocator to locate the ViewModel by convention
            containerRegistry.RegisterDialog<ViewA>();
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }

        
    }
}
