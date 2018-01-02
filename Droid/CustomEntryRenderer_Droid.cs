using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DDDIPocLayoutDemo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Android.OS.DropBoxManager;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Entry), typeof(CustomEntryRenderer_Droid))]
namespace DDDIPocLayoutDemo.Droid
{
    public class CustomEntryRenderer_Droid:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }

    }
}