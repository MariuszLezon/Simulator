using System;

namespace Simulator.Maps
{
    public class SmallTorusMap : Map
    {
        public int Size { get; }

        public SmallTorusMap(int size)
        {
            if (size < 5 || size > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "Size must be between 5 and 20.");
            }

            Size = size;
        }

        public override bool Exist(Point point)
        {
            return point.X >= 0 && point.X < Size && point.Y >= 0 && point.Y < Size;
        }

        public override Point Next(Point point, Direction direction)
        {
            int nextX = point.X;
            int nextY = point.Y;

            switch (direction)
            {
                case Direction.Up:
                    nextY = (point.Y + 1) % Size;
                    break;
                case Direction.Down:
                    nextY = (point.Y - 1 + Size) % Size;
                    break;
                case Direction.Left:
                    nextX = (point.X - 1 + Size) % Size;
                    break;
                case Direction.Right:
                    nextX = (point.X + 1) % Size;
                    break;
            }

            return new Point(nextX, nextY);
        }

        public override Point NextDiagonal(Point point, Direction direction)
        {
            int nextX = point.X;
            int nextY = point.Y;

            switch (direction)
            {
                case Direction.Up:
                    nextX = (point.X + 1) % Size;
                    nextY = (point.Y + 1) % Size;
                    break;
                case Direction.Down:
                    nextX = (point.X - 1 + Size) % Size;
                    nextY = (point.Y - 1 + Size) % Size;
                    break;
                case Direction.Left:
                    nextX = (point.X - 1 + Size) % Size;
                    nextY = (point.Y + 1) % Size;
                    break;
                case Direction.Right:
                    nextX = (point.X + 1) % Size;
                    nextY = (point.Y - 1 + Size) % Size;
                    break;
            }

            return new Point(nextX, nextY);
        }
    }
}