using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using VideoKnowledgeSystem.Views;

namespace VideoKnowledgeSystem
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NavView.SelectionChanged += NavView_SelectionChanged;

            ContentFrame.Navigate(typeof(MainPage));
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItemContainer == null)
                return;

            string tag = args.SelectedItemContainer.Tag?.ToString() ?? "";

            switch(tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(MainPage));
                    break;
                case "video":
                    ContentFrame.Navigate(typeof(VideoPage));
                    break;
                case "knowledge":
                    ContentFrame.Navigate(typeof(KnowledgePage));
                    break;
                case "settings":
                    ContentFrame.Navigate(typeof(SettingsPage));
                    break;
            }
        }
    }
}
