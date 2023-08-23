using SfChart.CopyFailure.Extensions;
using System.Windows;

namespace SfChart.CopyFailure;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var copy = Target.Copy();
        Source.Children.Add(copy);
    }
}
