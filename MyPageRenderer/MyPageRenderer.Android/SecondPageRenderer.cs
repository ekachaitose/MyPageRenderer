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
using MyPageRenderer;
using MyPageRenderer.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(SecondPage), typeof(SecondPageRenderer))] //ใช้เช็คในการจับคู่ว่าหน้าไหนที่จะทำการ renderer
namespace MyPageRenderer.Droid
{
    public class SecondPageRenderer : PageRenderer
    {
        Android.Views.View view;
        public SecondPageRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            var page = e.NewElement as SecondPage;
            var activity = Context as Activity;
             view = activity.LayoutInflater.Inflate(Resource.Layout.Dummy_Layout,this,false);
            var button = view.FindViewById<Android.Widget.Button>(Resource.Id.MyButton);

            button.Click += delegate 
            {
                Toast.MakeText(activity, "555", ToastLength.Long).Show();
                page.Navigation.PushAsync(new ThirdPage());
            };

            AddView(view);

        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            var msw = MeasureSpec.MakeMeasureSpec(r - l, MeasureSpecMode.Exactly);
            var msh = MeasureSpec.MakeMeasureSpec(b - t, MeasureSpecMode.Exactly);
            view.Measure(msw, msh);
            view.Layout(0, 0, r - l, b - t);
        }
    }

}