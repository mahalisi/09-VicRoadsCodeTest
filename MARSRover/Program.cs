using System;
using System.Collections.Generic;

using NASA.Planet.Business.Logic;
using NASA.Planet.Business.MARS.Logic;

namespace NASA.Planet.Presentation.MARS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read multiple lines of input from user input.
            List<string> instructionSet = new List<string>();
            string inputLine = null;
            Console.WriteLine("Welcome to MARS Explorer");
            Console.WriteLine("Enter one or more lines of text (press blank line to finish..):");
            
                        
            do
            {
                inputLine = Console.ReadLine();
                instructionSet.Add(inputLine);
                
            } while (inputLine != "");

            // Validate the input strings to contain proper instruction sets.
            // i.e First line of input is upper-right coordinates of the plateau
            // second line is rover's position with x coordinate, y coordinate and direction.
            // third line is series of instructions telling rover how to explore.
            // second and third line can be repeated with different instructions for each Rover in the Squad.
            // TODO: This is not required for this demo and hence not implemented.

            // Step 1: Initialise array of x, y coordinates based on first line of input.
            // Get first line of input for Plateau Size.
            string[] firstLine = instructionSet[0].Split(null);
            int xAxis = int.Parse(firstLine[0]);
            int yAxis = int.Parse(firstLine[1]);
            int[,] marsGrid = new int[xAxis, yAxis];

            // Step 2: Loop through remaining lines of input for each rover's instructions
            int instructionSetCount = instructionSet.Count - 1;  // Ignore the first line for plateau coordinates.

            Console.WriteLine("Output is:");

            for (int row = 1; row < instructionSetCount; row += 2)
            {
                // Set starting point for the Rover 1 from input line 2.
                string[] tempPosition = instructionSet[row].Split(null);
                IRover rover = new MARSRover(
                    int.Parse(tempPosition[0]), int.Parse(tempPosition[1]), tempPosition[2].ToString());

                // Step 3: Navigate rover based on input line 3.
                string instructions = instructionSet[row + 1];
                rover.Explore(instructions);

                // Step 4: Print the result
                Console.WriteLine ("{0}", ((MARSRover)rover).Position.Print);                
            }

            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();
        }
    }
}
