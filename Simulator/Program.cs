using System;
using Simulator;
using Simulator.Maps;

class Program
{
    static void Lab5a()
    {
        try
        {
            var rect1 = new Rectangle(2, 2, 5, 5);
            var rect2 = new Rectangle(new Point(1, 1), new Point(4, 4));
            Console.WriteLine(rect1);
            Console.WriteLine(rect2);

            var pointInside = new Point(3, 3);
            var pointOutside = new Point(6, 6);
            Console.WriteLine(rect1.Contains(pointInside));  // True
            Console.WriteLine(rect1.Contains(pointOutside)); // False
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Lab5b()
    {
        try
        {
            var map = new SmallSquareMap(10);
            var point = new Point(5, 5);

            Console.WriteLine(map.Exist(point)); // True
            Console.WriteLine(map.Next(point, Direction.Right)); // (6, 5)
            Console.WriteLine(map.Next(point, Direction.Up)); // (5, 6)
            Console.WriteLine(map.NextDiagonal(point, Direction.Right)); // (6, 4)
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Main(string[] args)
    {
        Lab5a();
        Lab5b();
    }
}