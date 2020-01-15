using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Wearable.Views;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Java.Interop;
using Android.Views.Animations;
using RouTor.Backend;

namespace RouTor.Client
{
    [Activity(Label = "RouTor.Client", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.RoundMain);

            var v = FindViewById<WatchViewStub>(Resource.Id.watch_view_stub);
            v.LayoutInflated += delegate
            {
                
                Button button = FindViewById<Button>(Resource.Id.myButton);

                button.Click += delegate
                {
                    //Perform router login
                    SilentWebBrowser oBrowser = new SilentWebBrowser();

                    oBrowser.UserName = Resources.GetString(Resource.String.Username);
                    oBrowser.Password = Resources.GetString(Resource.String.Password);
                    oBrowser.LANIP = Resources.GetString(Resource.String.LANIP);

                    oBrowser.NavigateLogin("http://159.253.72.79/login/login.html");

                    oBrowser.PerformLogin();
                };
            };
        }
    }
}


