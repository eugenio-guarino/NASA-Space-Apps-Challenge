using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WorkingWithMaps
{
    public class CustomCircle
    {
        public Position Position { get; set; }
        public double Radius { get; set; }
    }

    public class CustomMap:Map
    {
        public CustomCircle Circle { get; set; }
    }

	public class PinPage : ContentPage
	{
		// Map map;

		public PinPage ()
		{
            //map = new Map { 
            //	IsShowingUser = true,
            //	HeightRequest = 100,
            //	WidthRequest = 960,
            //	VerticalOptions = LayoutOptions.FillAndExpand
            //};

            // Create the custom map.
            var customMap = new CustomMap
            {
                MapType = MapType.Street,
                WidthRequest = 960,
                HeightRequest = 100
            };

            // Latitude, Longitude of the pin and circle around it.
            var position = new Position(36.9628066, -122.0194722);

            var pin = new Pin {
				Type = PinType.Place,
				Position = position,
                Label = "Air Quality Index (Station Name)",
				Address = "Location of station"
			};

            
            // Create the circle around the pin.
            customMap.Circle = new CustomCircle
            {
                Position = position,
                Radius = 1000
            };

            // Add the pin to the map and choose where to position the map after creating it.
            customMap.Pins.Add(pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1.0))); // Santa Cruz golf course

            // create buttons
            //var morePins = new Button { Text = "Add more pins" };
            //morePins.Clicked += (sender, e) => {
            //	map.Pins.Add(new Pin {
            //		Position = new Position(36.9641949,-122.0177232),
            //		Label = "Boardwalk"
            //	});
            //	map.Pins.Add(new Pin {
            //		Position = new Position(36.9571571,-122.0173544),
            //		Label = "Wharf"
            //	});
            //	map.MoveToRegion (MapSpan.FromCenterAndRadius (
            //		new Position (36.9628066,-122.0194722), Distance.FromMiles (1.5)));

            //};

            // Re-center back to a certain co-ordinates.
            //var reLocate = new Button { Text = "Re-center" };
            //reLocate.Clicked += (sender, e) => {
            //	map.MoveToRegion (MapSpan.FromCenterAndRadius (
            //		new Position (36.9628066,-122.0194722), Distance.FromMiles (3)));
            //};
            //var buttons = new StackLayout {
            //	Orientation = StackOrientation.Horizontal,
            //	Children = {
            //		morePins, reLocate
            //	}
            //};

            // put the page together
            //Content = new StackLayout { 
            //	Spacing = 0,
            //	Children = {
            //		map,
            //		buttons
            //	}};

            Content = customMap;
		}
	}
}

