using CommunityToolkit.Mvvm.ComponentModel;

namespace SfChart.CopyFailure.Models;

public partial class ChartModel : ObservableObject
{
    [ObservableProperty]
    private string _country;

    [ObservableProperty]
    private double _count;

    public ChartModel(string country, double count)
    {
        _country = country;
        _count = count;
    }
}
