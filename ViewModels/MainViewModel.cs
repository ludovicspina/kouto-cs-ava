using Kouto_clean.ViewModels.Pages;
using ReactiveUI;

namespace Kouto_clean.ViewModels;

public class MainViewModel : ViewModelBase
{
    private ViewModelBase _currentViewModel;
    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel;
        set => this.RaiseAndSetIfChanged(ref _currentViewModel, value);
    }

    public MainViewModel()
    {
        // Vue de démarrage
        CurrentViewModel = new DashboardViewModel();
    }
}