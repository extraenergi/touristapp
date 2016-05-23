using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;

namespace NewTuristApp
{
    [Activity(Label = "NewTuristApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    { 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);
            SetContentView(Resource.Layout.Menu);

            Button fromMenuToMapViewButton = FindViewById<Button>(Resource.Id.mapButton);

            fromMenuToMapViewButton.Click += (sender, e) =>
            {
                SetContentView(Resource.Layout.MapView);
                
                Button fromMapViewToMenuButton = FindViewById<Button>(Resource.Id.backButton);

                fromMapViewToMenuButton.Click += (senderOne, eOne) =>
                {
                    SetContentView(Resource.Layout.Menu);
                };
            };

            Button fromMenuToSettingsButton = FindViewById<Button>(Resource.Id.settingsButton);

            fromMenuToSettingsButton.Click += (sender, e) =>
            {
                SetContentView(Resource.Layout.Settings);

            Button fromSettingsToMapSettingsButton = FindViewById<Button>(Resource.Id.button4);

            fromSettingsToMapSettingsButton.Click += (sendere, ee) =>
                {
                    SetContentView(Resource.Layout.MapSettings);
                };

            Button fromSettingsToMenuButton = FindViewById<Button>(Resource.Id.backButton);

                fromSettingsToMenuButton.Click += (senderOne, eOne) =>
             {
                 SetContentView(Resource.Layout.Menu);
              };
           };
        }
    }
}

