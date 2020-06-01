using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Desktop.Views
{
    public class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}