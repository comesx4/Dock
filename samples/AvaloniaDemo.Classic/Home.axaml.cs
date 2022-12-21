using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dock.Model.Avalonia.Controls;

namespace AvaloniaDemo
{
    public partial class Home : Document
    {
        public Home()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
