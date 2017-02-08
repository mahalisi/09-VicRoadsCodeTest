
namespace NASA.Planet.Business.Data
{
    /// <summary>
    /// Object represention of Plateau in 2D geograhic.
    /// </summary>
    public class Plateau
    {
        /// <summary>
        /// X-Coordinate of the Plateau
        /// </summary>
        public int XAxis { get; set; }

        /// <summary>
        /// Y Coordinate of the Plateau
        /// </summary>
        public int YAxis { get; set; }

        /// <summary>
        /// Direction which includes only North, South, East and West.
        /// </summary>
        public string Direction { get; set; }
    }
}
