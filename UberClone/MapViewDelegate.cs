using System;
using MapKit;
using UIKit; 
namespace UberClone
{
    public class MapViewDelegate : MKMapViewDelegate
    {
        string pId = "PinAnnotation";
        public override MKAnnotationView GetViewForAnnotation(MKMapView mapView, IMKAnnotation annotation)
        {
            MKAnnotationView pinView = null;

            if (annotation is MKUserLocation)
                return pinView;

            pinView = mapView.DequeueReusableAnnotation(pId);

            if (pinView == null)
                pinView = new MKPinAnnotationView(annotation, pId);

            ((MKPinAnnotationView)pinView).PinColor = MKPinAnnotationColor.Red;
            pinView.CanShowCallout = true;
            pinView.RightCalloutAccessoryView = UIButton.FromType(UIButtonType.DetailDisclosure);
            pinView.Draggable = true; 
            return pinView;
        }
    }
}
