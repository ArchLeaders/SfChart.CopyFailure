using CommunityToolkit.Mvvm.ComponentModel;
using SfChart.CopyFailure.Models;
using System.Collections.ObjectModel;

namespace SfChart.CopyFailure;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<ChartModel> _chartData = new() {
        new("France", 67.75),
        new("England", 55.27),
        new("Mexico", 128.455),
        new("Russia", 144.377)
    };
}
