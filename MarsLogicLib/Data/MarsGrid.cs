using NASA.Planet.Business.Data;

namespace NASA.Planet.Business.MARS.Data
{
    /// <summary>
    /// Object to hold Mars Plateau information
    /// </summary>
    public class MarsGrid : Plateau
    {
       public string Print 
       {
           get { return this.XAxis + " " + this.YAxis + " " + this.Direction; }
           
       }
    }
}
