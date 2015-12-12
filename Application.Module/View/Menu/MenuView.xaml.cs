// PrismSampleApplication | Application.Module | MenuView.xaml.cs
// Copyright (c) 2015 Bartosz Rachwal.

using Application.Module.ViewModel.Menu;

namespace Application.Module.View.Menu
{
    public partial class MenuView
    {
        public MenuView(IMenuViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}