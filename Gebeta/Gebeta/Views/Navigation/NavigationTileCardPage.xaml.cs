﻿using Gebeta.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Gebeta.Views.Navigation
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationTileCardPage
    {
        public NavigationTileCardPage()
        {
            InitializeComponent();
            this.BindingContext = NavigationDataService.Instance.NavigationViewModel;
        }
    }
}