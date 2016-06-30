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
    [Activity(Label = "MapSettingsActivity")]
    public class MapSettingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var storageFile = new StorageFileActivity();
            SetContentView(Resource.Layout.MapSettings);
            Button button = FindViewById<Button>(Resource.Id.backButton);
            ToggleButton resturantToggle = FindViewById<ToggleButton>(Resource.Id.toggleButtonResturant);
            resturantToggle.Click += (sender, e) =>
            {
                storageFile.WriteFile(resturantToggle);
            };
            ToggleButton subwayToggle = FindViewById<ToggleButton>(Resource.Id.toggleButtonSubway);
            subwayToggle.Click += (sender, e) =>
            {
                storageFile.WriteFile(subwayToggle);
            };
            ToggleButton busStopToggle = FindViewById<ToggleButton>(Resource.Id.toggleButtonBusStop);
            busStopToggle.Click += (sender, e) =>
            {
                storageFile.WriteFile(busStopToggle);
            };
            ToggleButton chargingStationToggle = FindViewById<ToggleButton>(Resource.Id.toggleButtonChargingStation);
            chargingStationToggle.Click += (sender, e) =>
            {
                storageFile.WriteFile(chargingStationToggle);
            };
            ToggleButton hotelToggle = FindViewById<ToggleButton>(Resource.Id.toggleButtonHotel);
            hotelToggle.Click += (sender, e) =>
            {
                storageFile.WriteFile(hotelToggle);
            };
        }
    }
}