using System;
using System.Collections.Generic;
using Simulator.Maps;

namespace Simulator
{
    public class Simulation
    {
        public Map Map { get; }
        public List<Creature> Creatures { get; }
        public List<Point> Positions { get; }
        public string Moves { get; }
        public bool Finished { get; private set; }

        private int _currentMoveIndex = 0;

        public Creature CurrentCreature
        {
            get
            {
                int currentIndex = _currentMoveIndex % Creatures.Count;
                return Creatures[currentIndex];
            }
        }

        public string CurrentMoveName
        {
            get
            {
                return Moves[_currentMoveIndex % Moves.Length].ToString().ToLower();
            }
        }

        public Simulation(Map map, List<Creature> creatures, List<Point> positions, string moves)
        {
            if (creatures == null || creatures.Count == 0)
                throw new ArgumentException("Creatures list cannot be empty.");

            if (creatures.Count != positions.Count)
                throw new ArgumentException("Number of creatures must match number of starting positions.");

            Map = map;
            Creatures = creatures;
            Positions = positions;
            Moves = moves;
            Finished = false;
        }

        public void Turn()
        {
            if (Finished)
                throw new InvalidOperationException("Simulation is already finished.");

            
            _currentMoveIndex++;
            if (_currentMoveIndex >= Moves.Length)
            {
                Finished = true;
            }
        }
    }
}