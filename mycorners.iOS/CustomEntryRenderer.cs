using System;
using Xamarin.Forms.Platform.iOS;

using mycorners.CustomControls;
using Xamarin.Forms;
using UIKit;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntry))]
namespace mycorners.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}
