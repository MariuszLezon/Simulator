using System;

namespace Simulator
{
    public abstract class Creature
    {
        public string Name { get; set; }
        private int _level;
        public int Level
        {
            get => _level;
            set => _level = Validator.Limiter(value, 1, 10);
        }

        public abstract int Power { get; }
        public abstract string Info { get; }

        public Creature(string name = "Unknown", int level = 1)
        {
            Name = name;
            Level = level;
        }

        public abstract void SayHi();

        public override string ToString() => $"{GetType().Name.ToUpper()}: {Info}";
    }
}