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
    }
}
