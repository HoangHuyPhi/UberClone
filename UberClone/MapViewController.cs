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
            // Add annotations 
            mapView.AddAnnotation(new MKPointAnnotation()
            {
                Title = "Your Location",
                Coordinate = new CLLocationCoordinate2D(-35.3160, 149.1070)
            });
            mapView.AddAnnotation(new DriverAnnotation(("Driver Location"), new CLLocationCoordinate2D(-35.3169, 149.1075)));

            // set the map delegate
            mapDelegate = new MapViewDelegate();
            mapView.Delegate = mapDelegate;


            // Add map center 
            const double lat = -35.3160;
            const double lon = 149.1070;
            var mapCenter = new CLLocationCoordinate2D(lat, lon);
            var mapRegion = MKCoordinateRegion.FromDistance(mapCenter, 100, 100);
            mapView.CenterCoordinate = mapCenter;
            mapView.Region = mapRegion;
        }
    }
}