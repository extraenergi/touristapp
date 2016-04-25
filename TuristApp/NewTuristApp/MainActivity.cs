using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace NewTuristApp
{
    [Activity(Label = "NewTuristApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);
            SetContentView(Resource.Layout.Menu);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            ToggleButton onlineToggle = FindViewById<ToggleButton>(Resource.Id.toggleOnline);

            onlineToggle.Click += (o, e) =>
            {
                // Perform action on clicks
                if (onlineToggle.Checked)
                    Toast.MakeText(this, "Online", ToastLength.Short).Show();
                else
                    Toast.MakeText(this, "Offline", ToastLength.Short).Show();
            };

            ToggleButton textToggle = FindViewById<ToggleButton>(Resource.Id.TextSettingToggle);

            textToggle.Click += (o, e) =>
            {
                // Perform action on clicks
                if (textToggle.Checked)
                    Toast.MakeText(this, "Text På", ToastLength.Short).Show();
                else
                    Toast.MakeText(this, "Text Av", ToastLength.Short).Show();
            };
        }
    }
}

