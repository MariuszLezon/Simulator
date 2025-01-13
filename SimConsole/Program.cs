using System;
using System.Collections.Generic;
using Simulator;

namespace SimConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallSquareMap map = new(5);
            List<Creature> creatures = new List<Creature> { new Orc("Gorbag"), new Elf("Elandor") };
            List<Point> points = new List<Point> { new Point(2, 2), new Point(3, 1) };
            string moves = "dlrludl";

            Simulation simulation = new(map, creatures, points, moves);
            MapVisualizer mapVisualizer = new(simulation.Map);

            // Example of running the simulation
            while (!simulation.Finished)
            {
                mapVisualizer.Draw();
                simulation.Turn();
            }
        }
    }
}
