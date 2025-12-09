using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RisohEditorWinUI3Blank.UIExtend
{
    public sealed partial class WinHeader : UserControl
    {
        public WinHeader()
        {
            this.InitializeComponent();
        }
        public void ChangeColor(Color SetColor)
        {
            this.Root.Background = new SolidColorBrush(SetColor);
        }
    }
}
