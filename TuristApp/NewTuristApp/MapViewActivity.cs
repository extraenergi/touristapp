using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Gms.Maps;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps.Model;

namespace NewTuristApp
{
    [Activity(Label = "MapView")]
    public class MapViewActivity : Activity, IOnMapReadyCallback
    {
        //Den här klassen sak ta hand om aktiviteten i kartvyn men än så länge
        //verkar det som om den inte anropas alls. Jag har ingen aning om varför 
        // den funkar trots det.

        public GoogleMap map;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MapView);
            SetUpMap();

            Button fromMapViewToMenuButton = FindViewById<Button>(Resource.Id.backButton);

            fromMapViewToMenuButton.Click += (sender, e) =>
            {
                SetContentView(Resource.Layout.Menu);
            };
        }

        private void SetUpMap()
        {
            if (map == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            map = googleMap;

            LatLng latlngtest = new LatLng(59.377306, 13.518016);
            MarkerOptions options = new MarkerOptions()
            .SetPosition(latlngtest)
            .SetTitle("Hellhagen");

            map.AddMarker(options);
        }
    }
}