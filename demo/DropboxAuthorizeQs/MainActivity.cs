using Android.App;
using Android.Widget;
using Android.OS;
using Com.Dropbox.Core;
using System;
using Android.Webkit;
using Android.Content;
using Com.Dropbox.Core.Android;

namespace DropboxAuthorizeQs
{
    [Activity(Label = "DropboxAuthorizeQs", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.myButton);

        }
    }

}

