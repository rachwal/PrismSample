// PrismSampleApplication | Application.Shell | App.xaml.cs
// Copyright (c) 2015 Bartosz Rachwal.

using System.Windows;

namespace Application.Shell
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var bootstrapper = new ApplicationBootstrapper();
            bootstrapper.Run();
        }
    }
}