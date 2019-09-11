using Foundation;
using System;
using UIKit;
using MapKit;
using CoreLocation;
using CoreGraphics; 
namespace UberClone
{
    public partial class MapViewController : UIViewController
    {
        private MapViewDelegate mapDelegate;
        private MKMapView mapView; 
        public MapViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            // set the map view 
            mapView = new MKMapView(UIScreen.MainScreen.Bounds);
            mapView.MapType = MKMapType.Standard; 
            View = mapView;
            mapView.ShowsUserLocation = true;
            mapView.AddAnnotation(new MKPointAnnotation()
            {
                Title = "Your Location",
                Coordinate = new CLLocationCoordinate2D(42.364260, -71.120824)
            });

            // set the map delegate
            mapDelegate = new MapViewDelegate();
            mapView.Delegate = mapDelegate;


            // Add map center 
            const double lat = 42.374260;
            const double lon = -71.120824;
            var mapCenter = new CLLocationCoordinate2D(lat, lon);
            var mapRegion = MKCoordinateRegion.FromDistance(mapCenter, 2000, 2000);
            mapView.CenterCoordinate = mapCenter;
            mapView.Region = mapRegion;




            // display user's current location 
            CLLocationManager locationManager = new CLLocationManager();
            locationManager.RequestWhenInUseAuthorization();

        }
    }
}