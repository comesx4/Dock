using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Dock.Avalonia.Controls;
using Dock.Model.Core;

namespace AvaloniaDemo.Classic;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private async void FileOpenLayout_OnClick(object? sender, RoutedEventArgs e)
    {
    }

    private async void FileSaveLayout_OnClick(object? sender, RoutedEventArgs e)
    {
       
    }

    private void FileCloseLayout_OnClick(object? sender, RoutedEventArgs e)
    {
        var dock = this.FindControl<DockControl>("Dock");
        if (dock is { })
        {
            dock.Layout = null;
        }
    }

    private Window? GetWindow()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
        {
            return desktopLifetime.MainWindow;
        }
        return null;
    }
}
