using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
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
            this.Header = "Document 0";

            this.HeaderTemplate = CreateHeaderTemplate();

            this.Content = new Grid
            {
                Background = new SolidColorBrush(Color.FromArgb(255,39,39,39)),
            };

            this.Resources = new ResourceDictionary
            {
                { "TabViewItemHeaderBackgroundSelected", new SolidColorBrush(Color.FromArgb(255,50,50,50)) },
                { "TabViewItemHeaderBackgroundPointerOver", new SolidColorBrush(Color.FromArgb(255,50,50,50)) }
            };
        }

        private DataTemplate CreateHeaderTemplate()
        {
            var Xaml = @"
                <DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                <StackPanel Orientation='Horizontal' VerticalAlignment='Center'>
                <Ellipse Height='18' Width='18' StrokeThickness='1.5' Fill='#272727' Stroke='White' Margin='0 0 5 0'/>
                <TextBlock Text='{Binding}' Margin='5,0,0,0'/>
                </StackPanel>
                </DataTemplate>";

            return (DataTemplate)XamlReader.Load(Xaml);
        }
    }

  
}
