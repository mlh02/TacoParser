using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogInfo("Has to be 3 index's");
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // Your going to need to parse your string as a `double`
            // grab the latitude from your array at index 0
            var lat = double.Parse(cells[0]);
            // grab the longitude from your array at index 1
            var lon = double.Parse(cells[1]);
            // grab the name from your array at index 2
            string name = cells[2];

            // DONE You'll need to create a TacoBell class
            // DONE that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var firstPoint = new Point();
            firstPoint.Latitude = lat;
            firstPoint.Longitude = lon;

            TacoBell location1 = new TacoBell();
            location1.Name = name;
            location1.Location = firstPoint;

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return location1;
        }
        public static double ConvertToMile(double num)
        {
            return Math.Round(num % 1609.34, 2);
        }
    }
}