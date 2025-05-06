using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Kouto_clean.Controls;

public partial class TitleBarControl : UserControl
{
    public TitleBarControl()
    {
        InitializeComponent();
    }

    private void TitleBar_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        // Trouve la fenêtre parente et déclenche le déplacement
        (VisualRoot as Window)?.BeginMoveDrag(e);
    }

    private void Minimize_Click(object? sender, RoutedEventArgs e)
    {
        (VisualRoot as Window)!.WindowState = WindowState.Minimized;
    }

    private void Close_Click(object? sender, RoutedEventArgs e)
    {
        (VisualRoot as Window)!.Close();
    }
}