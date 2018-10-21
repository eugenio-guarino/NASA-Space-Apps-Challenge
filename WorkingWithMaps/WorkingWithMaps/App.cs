using System;
using Xamarin.Forms;

/*
Glyphish icons from
	http://www.glyphish.com/
under 
	http://creativecommons.org/licenses/by/3.0/us/
support them by buying the full set / Retina versions
*/

namespace WorkingWithMaps
{
	public class App : Application // superclass new in 1.3
	{
        public static double ScreenHeight;
        public static double ScreenWidth;

		public App ()
		{

			var tabs = new TabbedPage ();

			// SEARCH BAR & MAP PAGE - demonstrates the map control with zooming and map-types
			tabs.Children.Add (new MapPage {Title = "Pollution Map", Icon = "glyphish_74_location.png"});

			// TESTING PINS - demonstrates the map control with zooming and map-types
			tabs.Children.Add (new PinPage {Title = "Pins", Icon = "glyphish_07_map_marker.png"});

            // ABOUT STATION & HEALTH WARNINGS PAGE opens the platform's native Map app
            tabs.Children.Add (new MapAppPage {Title = "Map App", Icon = "glyphish_103_map.png"});




            // demonstrates the Geocoder class
            //tabs.Children.Add (new GeocoderPage {Title = "Geocode", Icon = "glyphish_13_target.png"});

            MainPage = tabs;
		}


        // Put in call to API to initialise it.
        protected override void OnStart()
        {

        }
	}
}

