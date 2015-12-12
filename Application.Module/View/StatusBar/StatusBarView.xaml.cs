// PrismSampleApplication | Application.Module | StatusBarView.xaml.cs
// Copyright (c) 2015 Bartosz Rachwal.

using Application.Module.ViewModel.StatusBar;

namespace Application.Module.View.StatusBar
{
    public partial class StatusBarView
    {
        public StatusBarView(IStatusBarViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}