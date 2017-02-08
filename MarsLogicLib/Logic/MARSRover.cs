using NASA.Planet.Business.Common;
using NASA.Planet.Business.Logic;
using NASA.Planet.Business.MARS.Data;

namespace NASA.Planet.Business.MARS.Logic
{
    /// <summary>
    /// Mars rover object.
    /// </summary>
    public class MARSRover : IRover
    {
        public MarsGrid Position = new MarsGrid();
        
        /// <summary>
        /// Initialize with Rover's Starting point in the MARS Plateau.
        /// </summary>
        /// <param name="startX">X Coordinate in the Plateau</param>
        /// <param name="startY">Y Coordinate in the Plateau</param>
        /// <param name="startDirection">Facing Direction</param>
        public MARSRover(int startX, int startY, string startDirection)
        {
            Position.XAxis = startX;
            Position.YAxis = startY;
            Position.Direction = startDirection;
        }

        /// <summary>
        /// Move or Rotate Rover based on the instruction set
        /// </summary>
        /// <param name="instructions">Instruction set for the Rover to move or rotate</param>
        public void Explore(string instructions)
        {            
            foreach (char instruction in instructions)
            {
             switch (instruction)
                {
                    case 'L':
                        Position.Direction = Compass.CounterClockwise(Position.Direction);
                        break;

                    case 'R':
                        Position.Direction = Compass.Clockwise(Position.Direction);
                        break;

                    case 'M':
                        this.Move();
                        break;
                }
            }
        }

        #region "Private Methods and Functions"

        /// <summary>
        /// Move the Rover to one position in the grid keeping the facing direction.
        /// </summary>
        private void Move()
        {
            switch (Position.Direction)
            {
                // (X, Y + 1)
                case "N":
                    Position.YAxis += 1;
                    break;

                // (X, Y - 1)
                case "S":
                    Position.YAxis -= 1;
                    break;

                // (X + 1, Y)
                case "E":
                    Position.XAxis += 1;
                    break;

                // (X - 1, Y)
                case "W":
                    Position.XAxis -= 1;
                    break;
            }
        }
        #endregion
    }
}
