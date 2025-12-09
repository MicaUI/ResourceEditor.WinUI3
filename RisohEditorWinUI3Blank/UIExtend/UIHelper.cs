using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Windows.UI;

namespace RisohEditorWinUI3Blank.UIExtend
{
    public class UIHelper
    {
        public static int TabWidth = 300;
        public static void ApplyDarkStyle(WinHeader Head)
        {
            Head.ChangeColor(Color.FromArgb(255, 32, 32, 32));
        }

        public static Color TabViewColor = Color.FromArgb(255, 39, 39, 39);
        public static Color TabViewSelectColor = Color.FromArgb(255, 50, 50, 50);
        public static TabViewItem CreatTab(string TabName)
        {
            TabViewItem Tab = new TabViewItem();

            Tab.Background = new SolidColorBrush(TabViewColor);

            Tab.Header = TabName;
     


            return Tab;
        }
    }
}
