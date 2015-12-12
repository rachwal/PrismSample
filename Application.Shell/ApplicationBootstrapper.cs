// PrismSampleApplication | Application.Shell | ApplicationBootstrapper.cs
// Copyright (c) 2015 Bartosz Rachwal.

using System.Windows;
using Application.Module;
using Application.Shell.View;
using Prism.Modularity;
using Prism.Unity;

namespace Application.Shell
{
    public class ApplicationBootstrapper : UnityBootstrapper
    {
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            var moduleCatalog = (ModuleCatalog) ModuleCatalog;
            moduleCatalog.AddModule(typeof (ApplicationModule));
        }

        protected override DependencyObject CreateShell()
        {
            var view = Container.TryResolve<ShellView>();
            return view;
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            System.Windows.Application.Current.MainWindow = (Window) Shell;
            System.Windows.Application.Current.MainWindow.Show();
        }
    }
}