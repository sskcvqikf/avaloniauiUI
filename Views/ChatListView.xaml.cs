using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Desktop.Views
{
    public class ChatListView : UserControl
    {
        public ChatListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}