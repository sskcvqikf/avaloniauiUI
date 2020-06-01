using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Desktop.Views
{
    public class RequestCredentialsView : UserControl
    {
        public RequestCredentialsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}