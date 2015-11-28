using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SplitViewSample_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ItemsList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainSplitView.IsPaneOpen = false;

            ItemsList.SelectedItem = e.ClickedItem;

            ChangeSidePanel((SlitViewListItem)ItemsList.SelectedIndex);
        }

        private void ChangeSidePanel(SlitViewListItem type)
        {
            switch (type)
            {
                case SlitViewListItem.Map:
                    // Do something
                    break;
                case SlitViewListItem.Search:
                    // Do something
                    break;
                case SlitViewListItem.Filters:
                    // Do something
                    break;
                default:
                    // Do something
                    break;
            }
        }

        private void ToggleSplitViewButton_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }
    }

    public enum SlitViewListItem
    {
        Map, Search, Filters
    }
}
