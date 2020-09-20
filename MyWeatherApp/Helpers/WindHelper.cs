using System;

namespace MyWeatherApp.Helpers
{
    public static class WindHelper
    {
        public static string DegreesToGeogrpahicalDirections(double degrees)
        {
            string[] directions = { "↓ N", " ↙ NE", " ← E", "↖ SE", "↑ S", "↗ SW", "→ W", "↘ NW", "↓ N" };
            return directions[(int)Math.Round(((double)degrees % 360) / 45)];
        }

        public static string MpsToKmph(double mps)
        {
            return Math.Round(3.6 * mps,1).ToString();
        }
    }
}
