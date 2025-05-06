using Avalonia.Controls;
using Avalonia.Interactivity;
using Kouto_clean.ViewModels;
using Kouto_clean.ViewModels.Pages;
using Kouto_clean.Services;


namespace Kouto_clean.Controls;

public partial class NavigationSidebarControl : UserControl
{
    public NavigationSidebarControl()
    {
        InitializeComponent();
    }

    private void Dashboard_Click(object? sender, RoutedEventArgs e)
    {
        if (VisualRoot is Window window && window.DataContext is MainViewModel main)
            new NavigationService(main).NavigateTo(new DashboardViewModel());
    }

    private void Install_Click(object? sender, RoutedEventArgs e)
    {
        if (VisualRoot is Window window && window.DataContext is MainViewModel main)
            new NavigationService(main).NavigateTo(new InstallationViewModel());
    }
}