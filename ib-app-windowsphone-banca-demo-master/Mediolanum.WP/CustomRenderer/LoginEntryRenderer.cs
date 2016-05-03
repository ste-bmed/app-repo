using Mediolanum.CustomRenderer;
using Mediolanum.WP.CustomRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;

[assembly: ExportRenderer(typeof(LoginEntry), typeof(LoginEntryRenderer))]
namespace Mediolanum.WP.CustomRenderer
{
    class LoginEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                Control.Background = new SolidColorBrush(Colors.White);
                double textSize = (e.NewElement as LoginEntry).TextSize;
                Control.FontSize = textSize == 0? e.NewElement.FontSize : textSize;
            }
        }
    }
}
