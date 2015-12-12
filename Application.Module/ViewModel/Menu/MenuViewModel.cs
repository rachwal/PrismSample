// PrismSampleApplication | Application.Module | MenuViewModel.cs
// Copyright (c) 2015 Bartosz Rachwal.

using Prism.Events;

namespace Application.Module.ViewModel.Menu
{
    public class MenuViewModel : IMenuViewModel
    {
        private readonly IEventAggregator eventAggregator;

        public MenuViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }
    }
}