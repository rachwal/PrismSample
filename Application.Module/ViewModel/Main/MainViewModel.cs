// PrismSampleApplication | Application.Module | MainViewModel.cs
// Copyright (c) 2015 Bartosz Rachwal.

using System.ComponentModel;
using System.Runtime.CompilerServices;
using Application.Module.Properties;
using Prism.Events;

namespace Application.Module.ViewModel.Main
{
    public class MainViewModel : IMainViewModel, INotifyPropertyChanged
    {
        private readonly IEventAggregator eventAggregator;

        public MainViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}