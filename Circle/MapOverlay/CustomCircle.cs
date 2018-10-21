using Xamarin.Forms.Maps;

namespace MapOverlay
{
	public class CustomCircle
	{
		public Position Position { get; set; }

		public double Radius { get; set; }

        public int ColorCode { get; set; }

        public CustomCircle()
        {
            // Maroon - 800000 (Hazardous)   
            // Purple - 4B0082 (Very unhealthy)
            // Red - FF0000 (Unhealthy)
            // Dark Orange - FF8C00 (Unhealthy for sensitive groups)
            // Yellow - FFCB00 (Moderate)
            // Green - 008744 (Good)

            // Assume the station is good unless changed.
            ColorCode = 0x66008744;

            Radius = 10000;
        }
	}
}

