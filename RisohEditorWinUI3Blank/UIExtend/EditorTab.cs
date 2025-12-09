using System.Xml.Linq;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RisohEditorWinUI3Blank.UIExtend
{
    public sealed class EditorTab : TabViewItem
    {
        public EditorTab()
        {
            this.Content = new Grid
            {
                Background = new SolidColorBrush(Color.FromArgb(255, 39, 39, 39)),
            };

            this.Resources = new ResourceDictionary
            {
                { "TabViewItemHeaderBackgroundSelected", new SolidColorBrush(Color.FromArgb(255, 50, 50, 50)) },
                { "TabViewItemHeaderBackgroundPointerOver", new SolidColorBrush(Color.FromArgb(255, 50, 50, 50)) }
            };

            this.CloseRequested += EditorTab_CloseRequested;
        }

        private void EditorTab_CloseRequested(TabViewItem sender, TabViewTabCloseRequestedEventArgs args)
        {
            ((TabViewListView)sender.Parent).Items.Remove(sender);
        }
    }
}
