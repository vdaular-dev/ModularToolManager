using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModularToolManager.Views;
public partial class DependencyView : UserControl
{
    public DependencyView()
    {
        InitializeComponent();
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
