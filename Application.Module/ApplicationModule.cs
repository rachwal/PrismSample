// PrismSampleApplication | Application.Module | ApplicationModule.cs
// Copyright (c) 2015 Bartosz Rachwal.

using Application.Common;
using Application.Module.View.Main;
using Application.Module.View.Menu;
using Application.Module.ViewModel.Main;
using Application.Module.ViewModel.Menu;
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
            container.RegisterType<IMainViewModel, MainViewModel>();
            container.RegisterType<MainView>();

            container.RegisterType<IMenuViewModel, MenuViewModel>();
            container.RegisterType<MenuView>();
        }

        private void RegisterRegions()
        {
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, () => container.Resolve<MainView>());
            regionManager.RegisterViewWithRegion(RegionNames.LeftRegion, () => container.Resolve<MenuView>());
        }
    }
}