using System;
using Simulator;

namespace SimConsole
{
    public class MapVisualizer
    {
        private readonly Map _map;

        public MapVisualizer(Map map)
        {
            _map = map;
        }

        public void Draw()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int y = 0; y < _map.Size; y++)
            {
                for (int x = 0; x < _map.Size; x++)
                {
                    
                    Console.Write(" "); 
                }
                Console.WriteLine();
            }
        }
    }
}
