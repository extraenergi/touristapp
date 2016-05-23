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

namespace NewTuristApp
{
    [Activity(Label = "SettingsActivity")]
    public class SettingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Settings);

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