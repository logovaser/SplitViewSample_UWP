using Windows.UI.Xaml.Controls;

namespace SplitViewSample_UWP.Controls
{
    public sealed partial class SplitViewPaneItemControl : UserControl
    {
        public SplitViewPaneItemControl()
        {
            this.InitializeComponent();
        }

        public string Glyph
        {
            get { return this.GlyphTextBlock.Text; }
            set { this.GlyphTextBlock.Text = value; }
        }

        public string Text
        {
            get { return this.NameTextBlock.Text; }
            set { this.NameTextBlock.Text = value; }
        }
    }
}
