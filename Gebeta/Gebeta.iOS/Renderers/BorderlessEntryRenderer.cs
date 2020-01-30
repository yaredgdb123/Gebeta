using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Gebeta.Controls.BorderlessEntry), typeof(Gebeta.iOS.BorderlessEntryRenderer))]

namespace Gebeta.iOS
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (this.Control != null)
            {
                this.Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}