using System;

public abstract class Creature
{
    public string Name { get; set; }
    public int Level { get; set; }

    public Creature(string name = "Unknown", int level = 1)
    {
        Name = name;
        Level = level;
    }

    public abstract void SayHi();


    public abstract int Power { get; }
    public abstract string Info { get; }
}

public class Orc : Creature
{
    private int _rage;

    public int Rage
    {
        get { return _rage; }
        set { _rage = Math.Max(0, Math.Min(value, 10)); }  
    }

    public Orc(string name = "Gorbag", int level = 1, int rage = 1) : base(name, level)
    {
        Rage = rage;  
    }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name}, my level is {Level}, my rage is {Rage}.");
    }

    public override int Power => 7 * Level + 3 * Rage;

 
    public override string Info => $"{Name} [{Level}][{Rage}]";

    public void Hunt()
    {
        if (Level % 2 == 0) 
        {
            Rage = Math.Min(Rage + 1, 10);
        }
        Level++;  
    }
}


public class Elf : Creature
{
    private int _agility;

    public int Agility
    {
        get { return _agility; }
        set { _agility = Math.Max(0, Math.Min(value, 10)); } 
    }

    public Elf(string name = "Legolas", int level = 1, int agility = 1) : base(name, level)
    {
        Agility = agility; 
    }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name}, my level is {Level}, my agility is {Agility}.");
    }

   
    public override int Power => 8 * Level + 2 * Agility;

    
    public override string Info => $"{Name} [{Level}][{Agility}]";

   
    public void Sing()
    {
        if (Level % 3 == 0) 
        {
            Agility = Math.Min(Agility + 1, 10);
        }
        Level++;  
    }
}


public static class Validator
{
    public static int Limiter(int value, int min, int max)
    {
        return Math.Max(min, Math.Min(value, max)); 
    }

    public static string Shortener(string value, int min, int max, char placeholder)
    {
        if (value.Length < min)
        {
            return value.PadRight(min, placeholder);  
        }
        if (value.Length > max)
        {
            return value.Substring(0, max);  
        }
        return value;
    }
}


public class Animals
{
    public string Description { get; set; }
    public int Size { get; set; }

    public virtual string Info => $"{Description} <{Size}>";

    public override string ToString()
    {
        return $"{this.GetType().Name.ToUpper()}: {Info}";
    }
}

public class Birds : Animals
{
    public bool CanFly { get; set; } = true; 

    public override string Info => $"{Description} (fly{(CanFly ? "+" : "-")}) <{Size}>";

    public override string ToString()
    {
        return $"{this.GetType().Name.ToUpper()}: {Info}";
    }
}


class Program
{
    static void Lab4a()
    {
        Console.WriteLine("HUNT TEST\n");
        var o = new Orc("Gorbag", rage: 7);
        o.SayHi();
        for (int i = 0; i < 10; i++)
        {
            o.Hunt();
            o.SayHi();
        }

        Console.WriteLine("\nSING TEST\n");
        var e = new Elf("Legolas", agility: 2);
        e.SayHi();
        for (int i = 0; i < 10; i++)
        {
            e.Sing();
            e.SayHi();
        }

        Console.WriteLine("\nPOWER TEST\n");
        Creature[] creatures = {
            o,
            e,
            new Orc("Morgash", 3, 8),
            new Elf("Elandor", 5, 3)
        };
        foreach (Creature creature in creatures)
        {
            Console.WriteLine($"{creature.Name,-15}: {creature.Power}");
        }
    }

    static void Lab4b()
    {
        object[] myObjects = {
            new Animals() { Description = "dogs", Size = 3 },
            new Birds() { Description = "eagles", Size = 10 },
            new Elf("e", 15, -3),
            new Orc("morgash", 6, 4)
        };
        Console.WriteLine("\nMy objects:");
        foreach (var o in myObjects) Console.WriteLine(o);
    }

    static void Main(string[] args)
    {
        Lab4a();
        Lab4b();
    }
}
