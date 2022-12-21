using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.VisualTree;

namespace Dock.Avalonia.Plugin;

/// <summary>
/// Document.
/// </summary>
public class PluginContentPresenter : ContentPresenter
{
    public void DetachFromVisualParent(IControl control)
    {
        VisualChildren.Remove(control);
    }

}
