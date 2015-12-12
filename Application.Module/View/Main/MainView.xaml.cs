// PrismSampleApplication | Application.Module | MainView.xaml.cs
// Copyright (c) 2015 Bartosz Rachwal.

using Application.Module.ViewModel.Main;

namespace Application.Module.View.Main
{
    public partial class MainView
    {
        public MainView(IMainViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}