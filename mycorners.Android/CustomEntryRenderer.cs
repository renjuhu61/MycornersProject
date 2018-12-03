using System;
using mycorners.Droid;
using mycorners.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Content.Res;
using Android.Content;
using Android.Graphics;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace mycorners.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            //if (Control != null)
            //{
              //  Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
              //  var nativeEditText = (global::Android.Widget.EditText)Control;
              //  var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
              //  //shape.Paint.Color = Xamarin.Forms.Color.Red.ToAndroid();
                //shape.Paint.SetStyle(Paint.Style.Stroke);
              //  nativeEditText.Background = shape;

            //}

            //if (Control != null)
           // {
             //   GradientDrawable gd = new GradientDrawable();

                //this line sets the bordercolor
              //  gd.SetColor(global::Android.Graphics.Color.Red);

                //this.Control.SetBackgroundDrawable(gd);
               // this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
               // Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));
            //}

            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var nativeEditText = (global::Android.Widget.EditText)Control;
                var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
                shape.Paint.Color = Xamarin.Forms.Color.DarkGray.ToAndroid();

                shape.Paint.SetStyle(Paint.Style.Stroke);
                nativeEditText.Background = shape;
                nativeEditText.SetTextColor(Xamarin.Forms.Color.Black.ToAndroid());
                //nativeEditText.Paint.Color = Xamarin.Forms.Color.Red.ToAndroid();
                //Control.SetTextColor(Android.Graphics.Color.Blue);
            }
        }
    
    }
}
