using System.IO;
using System.Windows;
using System.Windows.Markup;

namespace SfChart.CopyFailure.Extensions;

public static class XamlExtension
{
    public static T Copy<T>(this T source) where T : UIElement
    {
        using MemoryStream ms = new();
        XamlWriter.Save(source, ms);
        ms.Seek(0, SeekOrigin.Begin);
        return (T)XamlReader.Load(ms);
    }
}
