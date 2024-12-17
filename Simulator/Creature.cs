using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public class Creature
{
    public string Name { get; set; } = "Unknown";
    public int Level { get; set; } = 1;

    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level;
    }

    public Creature() { }

    public void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name} at level {Level}!");
    }

    public string Info => $"{Name} <{Level}>";
}