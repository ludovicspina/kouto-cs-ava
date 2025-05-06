using Kouto_clean.ViewModels;

namespace Kouto_clean.Services;

public class NavigationService
{
    private readonly MainViewModel _main;

    public NavigationService(MainViewModel main)
    {
        _main = main;
    }

    public void NavigateTo(ViewModelBase vm)
    {
        _main.CurrentViewModel = vm;
    }
}