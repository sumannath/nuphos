using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Wpf.Ui.Controls;
using Wpf.Ui.Common;
using Nuphos.Views.Pages;

namespace Nuphos.ViewModels.Windows;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _applicationTitle = "Nuphos";

    [ObservableProperty]
    private ICollection<object> _menuItems = new ObservableCollection<object>
    {
        new NavigationViewItem("Home", SymbolRegular.Home24, typeof(DashboardPage))
    };

    [ObservableProperty]
    private ICollection<object> _footerMenuItems = new ObservableCollection<object>()
    {
        new NavigationViewItem
        {
            Content = "Settings",
            Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
            TargetPageType = typeof(SettingsPage)
        }
    };

    [ObservableProperty]
    private ObservableCollection<MenuItem> _trayMenuItems =
        new()
        {
            new Wpf.Ui.Controls.MenuItem { Header = "Home", Tag = "tray_home" },
            new Wpf.Ui.Controls.MenuItem { Header = "Close", Tag = "tray_close" }
        };
}
