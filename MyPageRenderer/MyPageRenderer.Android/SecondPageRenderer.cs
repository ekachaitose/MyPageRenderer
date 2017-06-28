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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using MyPageRenderer;
using MyPageRenderer.Droid;

[assembly: ExportRenderer(typeof(SecondPage), typeof(SecondPageRenderer))] //ใช้เช็คในการจับคู่ว่าหน้าไหนที่จะทำการ renderer
namespace MyPageRenderer.Droid
{
    public class SecondPageRenderer : PageRenderer
    {
        public SecondPageRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {

        }
    }

}