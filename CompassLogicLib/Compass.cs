using System.Collections.Generic;

namespace NASA.Planet.Business.Common
{
    /// <summary>
    /// Utility class to find next cardinal position in Compass when moved clockwise or counter clockwise
    /// </summary>
    public static class Compass
    {
        /// <summary>
        /// Rotate 90 degree clockwise.
        /// </summary>
        /// <param name="currentFacing">Accepts current facing direction</param>
        /// <returns>Direction after rotating 90 degree clockwise</returns>
        public static string Clockwise(string currentFacing)
        {
            List<string> direction = new List<string>() { "N", "E", "S", "W" };
            return direction[(direction.IndexOf(currentFacing) + 1) == direction.Count ? 0 : (direction.IndexOf(currentFacing) + 1)];
        }

        /// <summary>
        /// Rotate 90 degree counter clockwise.
        /// </summary>
        /// <param name="currentFacing">Accepts current facing direction</param>
        /// <returns>Direction after rotating 90 degree counter clockwise</returns>
        public static string CounterClockwise(string currentFacing)
        {
            List<string> direction = new List<string>() { "N", "W", "S", "E" };
            return direction[(direction.IndexOf(currentFacing) + 1) == direction.Count ? 0 : (direction.IndexOf(currentFacing) + 1)];
        }
    }
}
