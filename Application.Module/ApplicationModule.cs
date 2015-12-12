// PrismSampleApplication | Application.Module | ApplicationModule.cs
// Copyright (c) 2015 Bartosz Rachwal.

using Application.Common;
using Application.Module.View.Main;
using Application.Module.View.Menu;
using Application.Module.View.StatusBar;
using Application.Module.ViewModel.Main;
using Application.Module.ViewModel.Menu;
using Application.Module.ViewModel.StatusBar;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace Application.Module
{
    public class ApplicationModule : IModule
    {
        private readonly IUnityContainer container;
        private readonly IRegionManager regionManager;

        public ApplicationModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterTypes();
            RegisterRegions();
            container.Resolve<IMainViewModel>();
        }

        private void RegisterTypes()
        {
            container.RegisterType<IMenuViewModel, MenuViewModel>();
            container.RegisterType<MenuView>();

            container.RegisterType<IMainViewModel, MainViewModel>();
            container.RegisterType<MainView>();

            container.RegisterType<IStatusBarViewModel, StatusBarViewModel>();
            container.RegisterType<StatusBarView>();
        }

        private void RegisterRegions()
        {
            regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, () => container.Resolve<MenuView>());
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, () => container.Resolve<MainView>());
            regionManager.RegisterViewWithRegion(RegionNames.StatusBarRegion, () => container.Resolve<StatusBarView>());
        }
    }
}